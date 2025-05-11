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
        public IWebContactUsRepository webContactUsRepository;

        public WebContactUsService(IWebContactUsRepository _webContactUsRepository)
        {
            webContactUsRepository = _webContactUsRepository;
        }
        public void Add(WebContactUs webContactUs)
        {
            webContactUsRepository.Add(webContactUs);
            Save();
        }

        public void Delete(int id)
        {
            webContactUsRepository.Delete(GetById(id));
            Save();
        }

        public void Delete(WebContactUs webContactUs)
        {
            webContactUsRepository.Delete(webContactUs);
            Save();
        }

        public List<WebContactUs> GetAll()
        {
           return webContactUsRepository.GetAll();
        }

        public WebContactUs GetById(int id)
        {
            return webContactUsRepository.GetById(id);
        }

        public bool IsExist(int Id)
        {
           return webContactUsRepository.IsExist(Id);
        }

        public void Save()
        {
            webContactUsRepository.Save();
        }

        public void Update(WebContactUs webContactUs)
        {
            webContactUsRepository.Update(webContactUs);
            Save();
        }
    }
}
