using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=CINKAYA;database=TicketSystemDBB; integrated security=true;");
        }

        public DbSet<employeeinfo> employeeinfos { get; set; }
        public DbSet<status> statuss { get; set; }
        public DbSet<unitname> unitnames { get; set; }
        public DbSet<level> levels { get; set; }
        public DbSet<title> titles { get; set; }
        public DbSet<request> requests { get; set; }
        public DbSet<login> logins { get; set; }



    }
}
