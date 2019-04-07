using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AteneoAPI.Data;
using AteneoAPI.Models;

namespace AteneoAPI.Data
{
    public class AlertContext : DbContext

    {
        public AlertContext(DbContextOptions<AlertContext> options) : base (options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<StudentCourse>().HasKey(x => new { x.CourseId, x.StudentId });
        //    base.OnModelCreating(modelBuilder);
        //}

        public DbSet<Student> Students { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }
    }
}
