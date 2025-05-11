using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRecapch.Domain.Models.Auth;

namespace MyRecapch.Domain.Interfaces
{
    public interface IUserRepository
    {
        User GetById(int id);// find
        bool IsExist(int Id);
        List<User> GetAll();// select *
        void Add(User user);// insert
        void Update(User user);// update
        void Delete(int id);// delete
        void Delete(User user);
        void Save(); // commit
    }
}
