using Microsoft.EntityFrameworkCore;
using PracticeApplication.Models.CoreTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeApplication.Models
{
    public class dbContext:DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) :base(options)
        {
            Database.SetCommandTimeout(1500000);
        }
       public DbSet<UserTable> UserTable { get; set; }
    }
}
