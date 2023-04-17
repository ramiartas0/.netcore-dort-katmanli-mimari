using Microsoft.EntityFrameworkCore;
using ProduKey.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduKey.DataAccess
{
    public class ProduKeyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-GQA8ILH\SQLEXPRESS;Database=ProduKey;Trusted_Connection=True;");
        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<AboutContent> aboutContents { get; set; }
        public DbSet<AboutImage> aboutImages { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Educator> Educators { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Inbox> Inboxs { get; set; }
    }
}
