using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ContosoMvcApp.Models
{
    public class SchoolDBContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            modelBuilder.Entity<Instructor>().HasOptional(i => i.OfficeAssignment).WithRequired(o => o.Instructor);
            modelBuilder.Entity<Course>().HasMany(c => c.Instructors).WithMany(i => i.Courses).Map(t => t.MapLeftKey("CourseID").MapRightKey("InstructorID").ToTable("CourseInstructor"));
            modelBuilder.Entity<Department>().HasOptional(d => d.Administrator);
        }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}