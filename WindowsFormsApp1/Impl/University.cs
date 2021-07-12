using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Base;

namespace WindowsFormsApp1.Impl
{

    public class University : Entity
    {

        public List<Student> Students { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Course> Courses { get; set; }
        public BindingList<Schedule> ScheduledCourses { get; set; }

        public University()
        {
            Students = new List<Student>();
            Professors = new List<Professor>();
            Courses = new List<Course>();
            ScheduledCourses = new BindingList<Schedule>();
        }

        public void InitMockData()
        {
            // TODO: MUST IMPLEMENT ENUMERATION FOR CATEGORY ?
            Courses.Add(new Course()
            {

                Code = "01",
                Subject = "Quantum Physics",
                Category = CoursesCategoryEnum.Physics, // physics
                Hours = 2
            });

            Courses.Add(new Course()
            {

                Code = "02",
                Subject = "Electo-Dynamics",
                Category = CoursesCategoryEnum.Physics, // physics ?
                Hours = 2
            });

            Courses.Add(new Course()
            {

                Code = "03",
                Subject = "Basic Chemistry",
                Category = CoursesCategoryEnum.Chemistry,  // Chemistry
                Hours = 2
            });

            Courses.Add(new Course()
            {

                Code = "04",
                Subject = "Financial II",
                Category = CoursesCategoryEnum.Financial,  // Financial
                Hours = 2
            });

            Courses.Add(new Course()
            {

                Code = "05",
                Subject = "Mathematics I",
                Category = CoursesCategoryEnum.Mathematics,
                Hours = 2
            });




            Students.Add(new Student()
            {

                Name = "Thanasis",
                Surname = "Petsinas",
                Age = 29,
                RegistrationNumber = 1234,
                AttendingCourses = new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Physics, CoursesCategoryEnum.Mathematics }
            });


            Students.Add(new Student()
            {
                Name = "Giwrgos",
                Surname = "Papadopoulos",
                Age = 24,
                RegistrationNumber = 1235,
                AttendingCourses = new List<CoursesCategoryEnum>() { CoursesCategoryEnum.CivilEngineering, CoursesCategoryEnum.Mathematics }
            });

            Students.Add(new Student()
            {
                Name = "Alexandra",
                Surname = "Sionti",
                Age = 24,
                RegistrationNumber = 1236,
                AttendingCourses = new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Physics, CoursesCategoryEnum.Sociology }
            });

            Students.Add(new Student()
            {
                Name = "Angelos",
                Surname = "Renginas",
                Age = 24,
                RegistrationNumber = 1237,
                AttendingCourses = new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Financial, CoursesCategoryEnum.Chemistry }
            });

            Students.Add(new Student()
            {
                Name = "Alexandros",
                Surname = "Papazoglou",
                Age = 24,
                RegistrationNumber = 1238,
                AttendingCourses = new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Mathematics, CoursesCategoryEnum.Sociology }
            });

            Students.Add(new Student()
            {
                Name = "Dorothea",
                Surname = "Sarri",
                Age = 24,
                RegistrationNumber = 1239,
                AttendingCourses = new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Physics, CoursesCategoryEnum.Chemistry }
            });





            Professors.Add(new Professor()
            {
                Name = "Dimitris",
                Surname = "Raptodimos",
                Age = 30,
                Rank = "Senior",
                TeachingCourses = new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Physics, CoursesCategoryEnum.Mathematics }
            });
            Professors.Add(new Professor()
            {
                Name = "Fotis",
                Surname = "Chrysoulas",
                Age = 30,
                Rank = "Senior",
                TeachingCourses = new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Chemistry, CoursesCategoryEnum.Physics }
            });
            Professors.Add(new Professor()
            {
                Name = "Stavros",
                Surname = "Kasidis",
                Age = 30,
                Rank = "Senior",
                TeachingCourses = new List<CoursesCategoryEnum>() { CoursesCategoryEnum.CivilEngineering, CoursesCategoryEnum.Mathematics }
            });
            Professors.Add(new Professor()
            {
                Name = "Thodoris",
                Surname = "Kapiris",
                Age = 30,
                Rank = "Senior",
                TeachingCourses = new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Sociology, CoursesCategoryEnum.Financial }
            });
            Professors.Add(new Professor()
            {
                Name = "Argurhs",
                Surname = "Roussos",
                Age = 30,
                Rank = "Senior",
                TeachingCourses = new List<CoursesCategoryEnum>() { CoursesCategoryEnum.CivilEngineering, CoursesCategoryEnum.Sociology }
            });
        }

        public void AddScheduledCourse(Guid courseID, Guid professorID, Guid studentID, DateTime date, string courseTime)
        {

            string professorName = Professors.FirstOrDefault(x => x.ID == professorID).Name;
            string studentName = Students.FirstOrDefault(x => x.ID == studentID).Name;
            string courseSubject = Courses.FirstOrDefault(x => x.ID == courseID).Subject;

            string professorSurname = Professors.FirstOrDefault(x => x.ID == professorID).Surname;
            string studentSurname = Students.FirstOrDefault(x => x.ID == studentID).Surname;


            Schedule schedule = new Schedule()
            {
                Date = date,
                CourseID = courseID,
                ProfessorID = professorID,
                StudentID = studentID,
                ProfessorName = professorName,
                StudentName = studentName,
                ProfessorSurname = professorSurname,
                StudentSurname = studentSurname,
                CourseSubject = courseSubject,
                CourseTime = courseTime

            };

            ScheduledCourses.Add(schedule);
        }
        public void DeleteScheduledCourse(Guid scheduleID)
        {
            //targeting whole object because of binding list -->linq
            Schedule specificSchedule = ScheduledCourses.FirstOrDefault(x => x.ID == scheduleID);
            ScheduledCourses.Remove(specificSchedule);

        }

        public void UpdateScheduledCourse(Guid scheduleID, Guid courseID, Guid professorID, Guid studentID, DateTime date, string courseTime)
        {

            // locate schedule
            Schedule schedule = ScheduledCourses.FirstOrDefault(x => x.ID == scheduleID);

            string professorName = Professors.FirstOrDefault(x => x.ID == professorID).Name;
            string studentName = Students.FirstOrDefault(x => x.ID == studentID).Name;
            string courseSubject = Courses.FirstOrDefault(x => x.ID == courseID).Subject;

            string professorSurname = Professors.FirstOrDefault(x => x.ID == professorID).Surname;
            string studentSurname = Students.FirstOrDefault(x => x.ID == studentID).Surname;
            //update schedule
            schedule.Date = date;
            schedule.CourseID = courseID;
            schedule.ProfessorID = professorID;
            schedule.StudentID = studentID;
            schedule.ProfessorName = professorName;
            schedule.StudentName = studentName;
            schedule.ProfessorSurname = professorSurname;
            schedule.StudentSurname = studentSurname;
            schedule.CourseSubject = courseSubject;
            schedule.CourseTime = courseTime;
        }
    }
}

