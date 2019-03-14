using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson.Entity
{
    public class Ders
    {
        public int DersId { get; set; }
        public string dersIsmi { get; set; }
        public int haftalikSaat { get; set; }

        public string dersKodu { get; set; }
        public string dersOgretmeni { get; set; }
    }
}
