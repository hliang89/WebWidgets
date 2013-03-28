using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoMvcApp.Models
{
    public class Instructor
    {
        public int InstructorID { get; set; }

        [Required(ErrorMessage="First Name is required")]
        [Column("FirstName")]
        [Display(Name="First Name")]
        [MaxLength(50)]
        public string FirstMidName { get; set; }


        [Required(ErrorMessage="Last Name is required")]
        [Display(Name="Last Name")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Display(Name="Hired Date")]
        public DateTime? HireDate { get; set; }

        [Display(Name="Full Name")]
        public string FullName 
        {
            get { return (FirstMidName + "," + LastName); }
        }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual OfficeAssignment OfficeAssignment { get; set; }
    }
}