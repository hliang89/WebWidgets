using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ContosoMvcApp.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorID { get; set; }

        [MaxLength(50)]
        [Display(Name="Office Location")]
        public string Location { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}