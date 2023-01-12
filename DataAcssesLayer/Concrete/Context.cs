using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAcssesLayer.Concrete
{
    public class Context:IdentityDbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-62IRRBA; database=DbAgriCulture; integrated security=true;");
        }

        public DbSet<Adres> Adres { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<SosialMedia> SosialMedias { get; set; }
        public DbSet<About> Abouts { get; set; }

        public DbSet<Admin> Admins { get; set; }





    }
}
