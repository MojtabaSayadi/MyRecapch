using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyRecapch.Domain.Models.Auth;

namespace MyRecapch.Data.Context
{
    public class RecapchaContext:DbContext
    {
        public RecapchaContext(DbContextOptions<RecapchaContext> options):base(options)
        {
        }
            
        public DbSet<User> Users { get; set; }
        
    }
}
