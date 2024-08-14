using EF_1.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Contexts
{
    public class ITIcontext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Coreses> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Crsins> Crsins { get; set; }
        public DbSet<Stdcrs> stdcrs { get; set; }
        public DbSet<Dept> depts { get; set; }
        public DbSet<Topic> Topics { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=ITI_EF; Trusted_Connection=True; TrustServerCertificate=True;");
        }
    }
}
