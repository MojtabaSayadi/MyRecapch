using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyRecapch.Core.Services.Implementations;
using MyRecapch.Core.Services.Interfaces;
using MyRecapch.Domain.Models.Web;
using MyRecapch.Domain.ViewModel.ContacUs;
using MyRecapch.Domain.ViewModel.Security;
using Recap.Models;


namespace Recap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebContactUsService WebContactUsService;
        public IRecaptchaService recaptchaService { get; set; }

        public HomeController(ILogger<HomeController> logger, IWebContactUsService _webContactUsService)
        {
            WebContactUsService =_webContactUsService;
            _logger = logger;
            IRecaptchaService _recaptchaService;
        }
    

        [HttpGet]
        public IActionResult Index(string AlertMessage)
        {
            if(!string.IsNullOrEmpty(AlertMessage))
                ViewBag.AlertMessage = AlertMessage;
            #region GoogleRecapcha
            GoogleRecapchaForViewViewModel tmp = new GoogleRecapchaForViewViewModel()
            {
                SiteKey = GoogleRecapchaViewModel.SiteKey
            };
            //private IWebContactUsService _webContactUsService;

            ViewData["SiteKey"] = tmp;
            #endregion

            return View(new ContacUSViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ContacUSViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (!recaptchaService.ReCaptchaPassed(model.Token, GoogleRecapchaViewModel.SecretKey))
                {
                    string err = "لطفا مجددا صفحه را بارگزاری کنید.";
                    return RedirectToAction("Index", "Home", new { errmessage = err });
                }

                bool isPhoneNumber = true;
                foreach (var item in model.PhoneNumber)
                {
                    isPhoneNumber = int.TryParse(item.ToString(), out int result);
                    if (isPhoneNumber == false)
                        break;
                }


                if (isPhoneNumber)
                {
                    WebContactUs webContactUs = new WebContactUs()
                    {
                        CreatedDate = DateTime.Now,
                        Fullname = model.Fullname,
                        Message = model.Message,
                        PhoneNumber = model.PhoneNumber,
                    };
                    WebContactUsService.Add(webContactUs);//.AddWebContactUs(webContactUs);
                    //return View(new WebContactUsViewModel());
                    return RedirectToAction("Index", "Home", new { AlertMessage = "پیام شما با موفقیت دریافت شد" });
                }

                else
                {
                    ModelState.AddModelError("PhoneNumber", "فرمت وارد شده صحیح نمی باشد.");

                }
            }
            else
            {
                ModelState.AddModelError("Message", "خطا در مقادیر ورودی. لطفا عبارات را بدرستی وارد کنید.");
            }

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
