using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ContosoMvcApp.ViewModels
{
    public class EnrollmentDateGroup
    {
        [Display(Name="Enrollment Date")]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name="Student Count")]
        public int StudentCount { get; set; }
    }
}