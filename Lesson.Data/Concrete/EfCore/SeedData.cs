using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            LessonContext context = app.ApplicationServices.GetRequiredService<LessonContext>();

            context.Database.Migrate();

            //if (!context.Dersler.Any())
            //{
            //    context.Dersler.AddRange(
            //    //new Ders() { lessonName = "Pdp", weeklyHour= 3,lessonTeacher=" Fatih Adak"},
            //    //new Ders() { lessonName = "Signals and Systems", weeklyHour = 4, lessonTeacher = " Kursat Ayan" },
            //    //new Ders() { lessonName = "Data Structers", weeklyHour = 5, lessonTeacher = " Devrim Akgun" }

            //    );

            //    context.SaveChanges();
            //}
            context.SaveChanges();
        }

    }
}
