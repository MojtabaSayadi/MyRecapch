using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRecapch.Domain.Models.Web;

namespace MyRecapch.Domain.Interfaces
{
    public interface IWebContactUsRepository
    {
        WebContactUs GetById(int id);// find
        bool IsExist(int Id);
        List<WebContactUs> GetAll();// select *
        void Add(WebContactUs webContactUs);// insert
        void Update(WebContactUs webContactUs);// update
        void Delete(int id);// delete
        void Delete(WebContactUs webContactUs);
        void Save(); // commit
    }
}
