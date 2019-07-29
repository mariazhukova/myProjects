using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonPlanerDataLayer
{
    public class LessonContext:DbContext
    {
        public LessonContext():base("name=PlannerDB")
        {

        }

        public DbSet<Lesson> Lessons { get; set; }
    }
}
