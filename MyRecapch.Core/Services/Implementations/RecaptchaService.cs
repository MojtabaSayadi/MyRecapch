using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MyRecapch.Core.Services.Interfaces;
using Newtonsoft.Json.Linq;

namespace MyRecapch.Core.Services.Implementations
{
    public class RecaptchaService:IRecaptchaService
    {
        public bool ReCaptchaPassed(string gRecaptchaResponse, string secretKey)
        {
            HttpClient httpClient = new HttpClient();

            var res = httpClient.GetAsync($"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={gRecaptchaResponse}").Result;

            if (res.StatusCode != HttpStatusCode.OK)//200
            {
                return false;
            }
            string JSONres = res.Content.ReadAsStringAsync().Result;
            dynamic JSONdata = JObject.Parse(JSONres);

            if (JSONdata.success != "true" || JSONdata.score <= 0.5m)
            {
                return false;
            }
            return true;
        }
    }
}

    

