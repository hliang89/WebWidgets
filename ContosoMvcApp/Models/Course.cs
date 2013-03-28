using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoMvcApp.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name="Number")]
        public int CourseID { get; set; }

        [Required(ErrorMessage="Title is required")]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required(ErrorMessage="Credit is required")]
        [Range(0,5,ErrorMessage="Credit must between 0 and 5")]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}