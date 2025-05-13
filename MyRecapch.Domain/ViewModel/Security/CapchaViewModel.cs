using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecapch.Domain.ViewModel.Security
{


    public class GoogleRecapchaForViewViewModel
    {
        public string SiteKey { get; set; }
    }

    public class GoogleRecapchaViewModel
    {
        public static string SiteKey { get; set; }

        public static string SecretKey { get; set; }
    }
    public class ReCaptcha
    {
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Token { get; set; }
    }


}
