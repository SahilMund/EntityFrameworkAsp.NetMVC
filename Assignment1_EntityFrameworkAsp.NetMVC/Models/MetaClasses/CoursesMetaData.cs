using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Assignment1_EntityFrameworkAsp.NetMVC.Models
{

    public class CoursesMetaData
    {
        [Required]
        public int CourseID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Course Name")]
        public string Title { get; set; }
    }

    //this partial class should be in same namespace as of the course model namespace

    [MetadataType(typeof(CoursesMetaData))]
    public partial class Course
    {

    }
}