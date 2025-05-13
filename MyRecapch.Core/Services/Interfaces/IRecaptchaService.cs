using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecapch.Core.Services.Interfaces
{
    public interface IRecaptchaService
    {
        bool ReCaptchaPassed(string gRecaptchaResponse, string secretKey);
    }
}
