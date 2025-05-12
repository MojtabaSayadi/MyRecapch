using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRecapch.Core.Services.Interfaces;
using MyRecapch.Domain.Interfaces;
using MyRecapch.Domain.Models.Web;

namespace MyRecapch.Core.Services.Implementations
{
    public class WebContactUsService : IWebContactUsService
    {
        public IWebContactUsRepository WebContactUsRepository;

        public WebContactUsService(IWebContactUsRepository _webContactUsRepository)
        {
            WebContactUsRepository = _webContactUsRepository;
        }
        public void Add(WebContactUs webContactUs)
        {
            WebContactUsRepository.Add(webContactUs);
            Save();
        }

        public void Delete(int id)
        {
            WebContactUsRepository.Delete(GetById(id));
            Save();
        }

        public void Delete(WebContactUs webContactUs)
        {
            WebContactUsRepository.Delete(webContactUs);
            Save();
        }

        public List<WebContactUs> GetAll()
        {
           return WebContactUsRepository.GetAll();
        }

        public WebContactUs GetById(int id)
        {
            return WebContactUsRepository.GetById(id);
        }

        public bool IsExist(int Id)
        {
           return WebContactUsRepository.IsExist(Id);
        }

        public void Save()
        {
            WebContactUsRepository.Save();
        }

        public void Update(WebContactUs webContactUs)
        {
            WebContactUsRepository.Update(webContactUs);
            Save();
        }
    }
}
