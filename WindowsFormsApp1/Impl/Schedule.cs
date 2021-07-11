using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Base;

namespace WindowsFormsApp1.Impl
{
    public class Schedule : Entity
    {
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public Guid StudentID { get; set; }
     
        public string ProfessorName { get; set; }
        public string ProfessorSurname { get; set; }
        public string CourseSubject { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname{ get; set; }
        public string LessonTime { get; set; }
        public DateTime Date { get; set; }
        


        

    }
}
