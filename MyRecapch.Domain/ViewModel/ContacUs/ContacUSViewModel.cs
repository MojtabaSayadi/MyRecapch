using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRecapch.Domain.ViewModel.Security;

namespace MyRecapch.Domain.ViewModel.ContacUs
{
    public class ContacUSViewModel : ReCaptcha
    {
        [Required(ErrorMessage = "لطفا {0} خود را وارد کنید")]
        [Display(Name = "نام و نام خانوادگی")]
        [MaxLength(100, ErrorMessage = "{0} شما بسیار طولانی می باشد.")]
        [MinLength(3, ErrorMessage = "{0} شما بسیار کوتاه می باشد.")]

        public string Fullname { get; set; }

        [Required(ErrorMessage = "لطفا {0} خود را وارد کنید")]
        [Display(Name = "شماره تماس")]
        [MaxLength(20, ErrorMessage = "{0} شما بسیار طولانی می باشد.")]
        [MinLength(6, ErrorMessage = "{0} شما بسیار کوتاه می باشد.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "لطفا {0} خود را وارد کنید")]
        [Display(Name = "متن پیام")]
        [MaxLength(2000, ErrorMessage = "{0} شما بسیار طولانی می باشد.")]
        public string Message { get; set; }
    }
}
