using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRecapch.Data.Context;
using MyRecapch.Domain.Interfaces;
using MyRecapch.Domain.Models.Auth;

namespace MyRecapch.Data.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly RecapchaContext context;

        public UserRepository(RecapchaContext _context)
        {
            context = _context;
        }

        public void Add(User user)
        {
            context.Users.Add(user);
        }

        public void Delete(int id)
        {
            context.Users.Remove(GetById(id));
        }

        public void Delete(User user)
        {
            context.Users.Remove(user);

        }

        public List<User> GetAll()
        {
            return context.Users.ToList();
        }

        public User GetById(int id)
        {
            return context.Users.Find(id);
        }

        public bool IsExist(int Id)
        {
            return context.Users.Any(u => u.Id == Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(User user)
        {
            context.Users.Update(user);
        }
    }
}
