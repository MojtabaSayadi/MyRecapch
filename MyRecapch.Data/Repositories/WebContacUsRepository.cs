using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRecapch.Data.Context;
using MyRecapch.Domain.Interfaces;
using MyRecapch.Domain.Models.Web;
using MyRecapch.Domain.Models.Web;

namespace MyRecapch.Data.Repositories
{
    public class WebContacUsRepository:IWebContactUsRepository
    {
        private readonly RecapchaContext context;

        public WebContacUsRepository(RecapchaContext _context)
        {
            context = _context;
        }

        public void Add(WebContactUs webContactUs)
        {
            context.webContactUs.Add(webContactUs);
       
        }

        public void Delete(int id)
        {
            context.webContactUs.Remove(GetById(id));
        }

        public void Delete(WebContactUs webContactUs)
        {
            context.webContactUs.Remove(webContactUs);
        }

        public List<WebContactUs> GetAll()
        {
            return context.webContactUs.ToList();
        }

        public WebContactUs GetById(int id)
        {
            return context.webContactUs.Find(id);
        }

        public bool IsExist(int Id)
        {
            return context.webContactUs.Any(p => p.Id == Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(WebContactUs webContactUs)
        {
            context.webContactUs.Update(webContactUs);
        }
    }
}

