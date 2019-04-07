using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AteneoAPI.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Matricula { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string SecondFamilyName { get; set; }
        public DateTime BirthDay { get; set; }

        public virtual List<StudentCourse> Courses { get; set; }
    }
}
