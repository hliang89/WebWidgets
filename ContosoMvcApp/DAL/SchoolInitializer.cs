using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContosoMvcApp.Models;

namespace ContosoMvcApp.DAL
{
    public class SchoolInitializer:DropCreateDatabaseAlways<SchoolDBContext>
    {
        protected override void Seed(SchoolDBContext context)
        {
            var Students = new List<Student>()
            {
                new Student { FirstMidName = "Carson",   LastName = "Alexander", EnrollmentDate = DateTime.Parse("2005-09-01") },
                new Student { FirstMidName = "Meredith", LastName = "Alonso",    EnrollmentDate = DateTime.Parse("2002-09-01") },
                new Student { FirstMidName = "Arturo",   LastName = "Anand",     EnrollmentDate = DateTime.Parse("2003-09-01") },
                new Student { FirstMidName = "Gytis",    LastName = "Barzdukas", EnrollmentDate = DateTime.Parse("2002-09-01") },
                new Student { FirstMidName = "Yan",      LastName = "Li",        EnrollmentDate = DateTime.Parse("2002-09-01") },
                new Student { FirstMidName = "Peggy",    LastName = "Justice",   EnrollmentDate = DateTime.Parse("2001-09-01") },
                new Student { FirstMidName = "Laura",    LastName = "Norman",    EnrollmentDate = DateTime.Parse("2003-09-01") },
                new Student { FirstMidName = "Nino",     LastName = "Olivetto",  EnrollmentDate = DateTime.Parse("2005-09-01") }
            };            

            Students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var Courses = new List<Course>()
            {
                 new Course { Title = "Chemistry",      Credits = 3, },
                new Course { Title = "Microeconomics", Credits = 3, },
                new Course { Title = "Macroeconomics", Credits = 3, },
                new Course { Title = "Calculus",       Credits = 4, },
                new Course { Title = "Trigonometry",   Credits = 4, },
                new Course { Title = "Composition",    Credits = 3, },
                new Course { Title = "Literature",     Credits = 4, }
            };

            Courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();

            var enrollments = new List<Enrollment>()
            {
                new Enrollment { StudentID = 1, CourseID = 1, Grade = 1 },
                new Enrollment { StudentID = 1, CourseID = 2, Grade = 3 },
                new Enrollment { StudentID = 1, CourseID = 3, Grade = 1 },
                new Enrollment { StudentID = 2, CourseID = 4, Grade = 2 },
                new Enrollment { StudentID = 2, CourseID = 5, Grade = 4 },
                new Enrollment { StudentID = 2, CourseID = 6, Grade = 4 },
                new Enrollment { StudentID = 3, CourseID = 1            },
                new Enrollment { StudentID = 4, CourseID = 1,           },
                new Enrollment { StudentID = 4, CourseID = 2, Grade = 4 },
                new Enrollment { StudentID = 5, CourseID = 3, Grade = 3 },
                new Enrollment { StudentID = 6, CourseID = 4            },
                new Enrollment { StudentID = 7, CourseID = 5, Grade = 2 },
            };

            enrollments.ForEach(e => context.Enrollments.Add(e));
            context.SaveChanges();
        }
    }
}