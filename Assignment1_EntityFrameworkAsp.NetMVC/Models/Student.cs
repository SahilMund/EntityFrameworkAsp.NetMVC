//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment1_EntityFrameworkAsp.NetMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int CourseId { get; set; }
    
        public virtual Course Course { get; set; }
    }
}
