using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRecapch.Domain.Models.Web;

namespace MyRecapch.Core.Services.Interfaces
{
    public interface IWebContactUsService
    {
        WebContactUs GetById(int id);
        List<WebContactUs> GetAll();
        bool IsExist(int Id);
        void Add(WebContactUs webContactUs);
        void Update(WebContactUs webContactUs);
        void Delete(int id);
        void Delete(WebContactUs webContactUs);
        void Save();
    }
}
