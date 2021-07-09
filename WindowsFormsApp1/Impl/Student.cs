using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Base;

namespace WindowsFormsApp1.Impl
{
    public class Student : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string RegistrationNumber { get; set; }
        public int Age { get; set; }
        public List<CoursesCategoryEnum> AttendingCourses { get; set; }
        
    }
}
