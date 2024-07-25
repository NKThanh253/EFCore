using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenKhacThanh_EFCore;

namespace SchoolDomain
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SchoolDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

            //Property Configurations
            modelBuilder.Entity<Student>()
                    //.Property(s => s.StudentId)
                    //.HasColumnName("Id")
                    //.HasDefaultValue(0)
                    //.IsRequired()
                    .HasOne<Grade>(s => s.Grade)
                    .WithMany(g => g.Students);
        }
    }
}
