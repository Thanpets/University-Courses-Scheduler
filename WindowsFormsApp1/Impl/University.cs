using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Base;

namespace WindowsFormsApp1.Impl {

    public class University : Entity  {

        public List<Student> Students { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Course> Courses { get; set; }
        public List<Schedule> Schedules { get; set; }

        public University() {
            Students = new List<Student>();
            Professors = new List<Professor>();
            Courses = new List<Course>();
            Schedules = new List<Schedule>();
        }

        //public List<Schedule> ScheduleList { get; set; }

        public void LoadMockData() {
            // TODO: MUST IMPLEMENT ENUMERATION FOR CATEGORY ?
            Courses.Add( new Course() {
                 
                Code = "01",
                Subject = "Quantum Physics",
                Category = CoursesCategoryEnum.Physics, // physics
                Hours = 100
            });

            Courses.Add(new Course() {
               
                Code = "02",
                Subject = "Electo-Dynamics",
                Category = CoursesCategoryEnum.Physics, // physics ?
                Hours = 50
            });

            Courses.Add(new Course() {
               
                Code = "03",
                Subject = "Basic Chemistry",
                Category = CoursesCategoryEnum.Chemistry,  // Chemistry
                Hours = 50
            });

            Courses.Add(new Course() {
                
                Code = "04",
                Subject = "Financial II",
                Category = CoursesCategoryEnum.Financial,  // Financial
                Hours = 50
            });

            Courses.Add(new Course() {
               
                Code = "05",
                Subject = "Mathematics I",
                Category = CoursesCategoryEnum.Mathematics,
                Hours = 50
            });

            Students.Add(new Student() {
                
                Name = "Fotis",
                Surname = "Chrysoulas",
                RegistrationNumber = "1234",
                AttendingCourses = new List<CoursesCategoryEnum>() {CoursesCategoryEnum.Physics,CoursesCategoryEnum.Mathematics}
            });


            Students.Add(new Student()
            {
                Name = "Dimitris",
                Surname = "Raptodimos",
                RegistrationNumber = "1235",
                AttendingCourses = new List<CoursesCategoryEnum>() { CoursesCategoryEnum.CivilEngineering, CoursesCategoryEnum.Mathematics }
            });

            Professors.Add(new Professor() {
                Name = "Maria",
                Surname = "Papadopoulou",
                Rank = "1",
                TeachingCourses = new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Physics, CoursesCategoryEnum.Mathematics }                
            });
        } 
    }   
}

