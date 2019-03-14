using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson.Entity
{
    public class ApplicationUser : IdentityUser
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }

        public List<Ders> Ders { get; set; }

        //public List<Ders> Dersler { get; set; }

    }
}
