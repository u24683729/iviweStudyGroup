using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iviweStudyGroup.Models
{
    public class Student
    {

        [Display(Name = "STUDENT NUMBER")]
        public int Std_ID { get; set; }

        [Display(Name = "NAME")]
        public string Std_Name { get; set; }

        [Display(Name = "SURNAME")]
        public string Std_Surname { get; set; }

        [Display(Name = "EMAIL ADDRESS")]
        public string Std_Email { get; set; }
    }

}