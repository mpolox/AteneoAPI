using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AteneoAPI.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public virtual List<StudentCourse> Students { get; set; }
    }
}
