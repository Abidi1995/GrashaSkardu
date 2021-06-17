using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrashaSkardu.Models
{
    public class Student
    {
        [Key]
        
        public int StudentId { get; set; }
        [Required(ErrorMessage ="input your complete name")]
        public string StudentName { get; set; }
        [Required(ErrorMessage ="input your father name")]
        public string StudentFname { get; set; }
        [Required(ErrorMessage ="please enter your class")]
        public string StudentClass { get; set; }
        [Required(ErrorMessage ="enter your program")]
        public string StudentPrgram { get; set; }
        [Required(ErrorMessage ="enter your section")]
        public string StudentSection { get; set; }
    }
}
  