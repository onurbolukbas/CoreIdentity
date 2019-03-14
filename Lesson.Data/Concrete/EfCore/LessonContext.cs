using Lesson.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson.Data.Concrete.EfCore
{
    public class LessonContext : IdentityDbContext<ApplicationUser>
    {
        public LessonContext(DbContextOptions<LessonContext> options)
        : base(options)
        {

        }
      
        //  public DbSet<Person> Persons { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<ApplicationUser> applicationUsers {get; set;}




    }
}
