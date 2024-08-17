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
            optionsBuilder.UseSqlServer("server= .; database=ITI_EF; Trusted_Connection=True; TrustServerCertificate=True;");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Crsins>().HasKey(c => new { c.InstructorId, c.CoresesId });

            modelBuilder.Entity<Crsins>()
                .HasOne(c => c.Instructor)
                .WithMany(i => i.Crsins)
                .HasForeignKey(c => c.InstructorId);

            modelBuilder.Entity<Crsins>()
                .HasOne(c => c.coreses)
                .WithMany()
                .HasForeignKey(c => c.CoresesId);

            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Dept)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.DeptId);


            modelBuilder.Entity<Stdcrs>()
                .HasOne(c => c.Corese)
                .WithMany(i => i.Stdcrs)
                .HasForeignKey(c => c.Coreseid);

            modelBuilder.Entity<Stdcrs>()
                .HasOne(c => c.Student)
                .WithMany()
                .HasForeignKey(c => c.Studentid);
        }
    }
}
