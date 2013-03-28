using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ContosoMvcApp.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage = "Budget is required")]
        [DataType(DataType.Currency)]
        public decimal? Budget { get; set; }

        [Required(ErrorMessage="Start Time is required")]
        [DataType(DataType.Date)]
        [Display(Name="Start Time")]
        public DateTime StartTime { get; set; }

        [Display(Name="Administrator")]
        public int? InstructorID { get; set; }

        public virtual Instructor Administrator { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}