using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ContosoMvcApp.Models
{
    public class Student
    {
        public int ID { get; set; }
        
        [Required(ErrorMessage="Last Name is required")]
        [Display(Name="Last Name")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage="First Name is required")]
        [Display(Name="First Name")]
        [MaxLength(50)]
        public string FirstMidName { get; set; }

        [Required(ErrorMessage="Enrollment Date is required")]
        [Display(Name="Enrollment Date")]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}