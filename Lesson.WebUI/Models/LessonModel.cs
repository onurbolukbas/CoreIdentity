using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson.WebUI.Models
{
    public class LessonModel
    {
        [Required]
        public string dersIsmi { get; set; }
        [Required]
        public int haftalikSaat { get; set; }
        [Required]
        public string dersKodu { get; set; }
        [Required]
        public string dersOgretmeni { get; set; }
    }
}
