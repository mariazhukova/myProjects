using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCProject.Models
{
    public class MVCLessonsContext : DbContext
    {
        public MVCLessonsContext (DbContextOptions<MVCLessonsContext> options)
            : base(options)
        {
        }

        public DbSet<MVCProject.Models.LessonItemViewModel> LessonItemViewModel { get; set; }
    }
}
