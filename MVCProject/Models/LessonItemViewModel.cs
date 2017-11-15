using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class LessonItemViewModel
    {
        public int ID { get; set; }
        public string Group { get; set; }
        public int Room { get; set; }
        public string Trainer { get; set; }

    }
}
