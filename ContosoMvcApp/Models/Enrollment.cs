using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoMvcApp.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public decimal? Grade { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}