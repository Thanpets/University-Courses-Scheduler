using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1.WUI
{

    public partial class MainForm : Form
    {

        private const string _JsonFile = "UniversityData.json";
        private University University = new University();

        public MainForm()
        {
            InitializeComponent();
        }

        #region old code
        //private void DataForm_Load(object sender, EventArgs e) {

        //    // todo : load data on enter!
        //}

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            JavaScriptSerializer r = new JavaScriptSerializer();

            University = r.Deserialize<University>(File.ReadAllText("Data.json"));

            foreach (Student item in University.Students)
            {
                crtlCourseList.Items.Add(item.Name + " " + item.Surname);
            }

            for (int i = 0; i < University.Courses.Count - 1; i++)
            {

                crtlProfessorList.Items.Add(University.Courses[i].Code + "--" + University.Courses[i].Subject);
            }


            foreach (Professor item in University.Professors)
            {
                crtlStudentList.Items.Add(string.Format("{0}  {1}", item.Name, item.Surname));
            }
        }

        private void saveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JavaScriptSerializer save_Serializer = new JavaScriptSerializer();

            File.WriteAllText("Data.json", save_Serializer.Serialize(University));
        }
        #endregion

        #region new code
        private void MainForm_Load(object sender, EventArgs e)
        {
            //SerializeToJson();

            LoadMockDataToLists();

            //load mock data to prof,student,course grids
            ctrlProfessorList2.DataSource = University.Professors;
            crtlStudentList2.DataSource = University.Students;
            crtlCourseList2.DataSource = University.Courses;



            // todo : load data on enter!
        }




        private void crtlAddNewSchedule_Click(object sender, EventArgs e)
        {



            DataGridViewSelectedRowCollection selectedProfessorItem = ctrlProfessorList2.SelectedRows;
            DataGridViewSelectedRowCollection selectedCourseItem = crtlCourseList2.SelectedRows;
            DataGridViewSelectedRowCollection selectedStudentItem = crtlStudentList2.SelectedRows;
            //getting selected IDS
            var professorID = (Guid)selectedProfessorItem[0].Cells[4].Value;
            var studentID = (Guid)selectedStudentItem[0].Cells[4].Value;
            var courseID = (Guid)selectedCourseItem[0].Cells[4].Value;

            crtlDatePicker.CustomFormat = "dd/MM/yyyy";

            DateTime calendar = crtlDatePicker.Value;

            string lessonTime = ctrlAvailableHours.Text;

            if (string.IsNullOrEmpty(lessonTime))
            {
                MessageBox.Show("Please pick a Course Time before adding a new schedule");
                return;
            }

            if (ValidateStudentCourses(calendar,studentID) == false)
            {
                return;
            }
            if (ValidateProfessorCourses(calendar,professorID) == false)
            {
                return;
            }

            


            if (ValidateStudentAvailability(lessonTime, calendar, studentID) == false)
            {
                return;
            }
            if (ValidateProfessorAvailability(lessonTime, calendar, professorID) == false)
            {
                return;
            }
            if (true)
            {

            }


            University.AddScheduledCourse(courseID, professorID, studentID, calendar.Date, lessonTime); //adding new scheduledcourse

            crtlScheduleList.DataSource = University.ScheduledCourses;  //showing data to scheduleGrid


            // TODO: 1. CANNOT ADD SAME STUDENT + PROFESSOR IN SAME DATE & HOUR

            // TODO: 2. EACH STUDENT CANNOT HAVE MORE THAN 3 COURSES PER DAY!

            // TODO: 3. A PROFESSOR CANNOT TEACH MORE THAN 4 COURSES PER DAY AND 40 COURSES PER WEEK



        }

        public bool ValidateProfessorCourses(DateTime calendar,Guid professorID)
        {
            var professorSchedule = University.ScheduledCourses.Where(x => x.ProfessorID == professorID);
            var countDailyLessons = professorSchedule.Count(x => x.Date == calendar.Date);

            if (countDailyLessons >= 4)
            {
                MessageBox.Show("Selected Professor already scheduled to 4 courses in this day");
                return false;
            }
            return true;
        }


        public bool ValidateStudentCourses(DateTime calendar,Guid studentID)
        {
            //Validates if student is signed to 3 lessons in selected day/date
            var studentSchedule = University.ScheduledCourses.Where(x => x.StudentID == studentID);
            var countDailyLessons = studentSchedule.Count(x => x.Date == calendar.Date);

            if (countDailyLessons >= 3)
            {
                MessageBox.Show("Selected Student already scheduled to  3 courses in this day");
                return false;
            }
            return true;
        }
        public bool ValidateStudentAvailability(string lessonTime, DateTime calendar, Guid studentID)
        {
            //validates if student is not occupied with another lesson at time.
            IEnumerable<Schedule> studentSchedule = University.ScheduledCourses.Where(x => x.StudentID == studentID);
            foreach (Schedule schedule in studentSchedule)
            {
                if (schedule.Date == calendar.Date)
                {
                    if (schedule.LessonTime == lessonTime)
                    {
                        MessageBox.Show("Selected Student is in another course in selected hour");
                        return false;
                    }
                }
            }
            return true;
        }

        public bool ValidateProfessorAvailability(string lessonTime, DateTime calendar, Guid professorID)
        {
            //validates if professor is not occupied with another lesson at time.
            IEnumerable<Schedule> professorSchedule = University.ScheduledCourses.Where(x => x.ProfessorID == professorID);
            foreach (Schedule schedule in professorSchedule)
            {
                if (schedule.Date == calendar.Date)
                {
                    if (schedule.LessonTime == lessonTime)
                    {
                        MessageBox.Show("Selected Professor is in another scheduled course in selected hour");
                        return false;
                    }
                }
            }
            return true;
        }



        public void validate_professorCourse_with_studentCourse()
        {

            //TODO: ???

        }

        #endregion

        private void button11_Click(object sender, EventArgs e)
        {



            //University.LoadMockData();

            //foreach (Student item in University.Students) {
            //    crtlCourseList.Items.Add($"{item.Name} {item.Surname}");
            //}

            //foreach (Course course in University.Courses) {
            //    crtlProfessorList.Items.Add(course.Code + "--" + course.Subject);
            //}


            //foreach (Professor cc1 in University.Professors) {

            //    crtlStudentList.Items.Add(string.Format("{0}  {1}", cc1.Name, cc1.Surname));
            //}

            //should run only once!
            //button11.Hide();
        }

        private void addToScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // todo : display on a grid??

            // todo: add exception handling?
            //University.Schedules.Add(new Schedule() { 
            //    Course = crtlProfessorList.SelectedItem.ToString(),
            //    Student = crtlCourseList.SelectedItem.ToString(),
            //    Professor = crtlStudentList.SelectedItem.ToString(), 
            //    Calendar = dateTimePicker2.Value });

            //ctrlSchedule.Items.Clear();
            //foreach (Schedule schedule in University.ScheduledCourses) {

            //    ctrlSchedule.Items.Add(
            //        schedule.Calendar + " " + 
            //        schedule.Courses + " " + 
            //        schedule.Students + " " + 
            //        schedule.Professors);

            //}

        }
        private void SerializeToJson()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string data = serializer.Serialize(University);
            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            File.WriteAllText(path, data);

        }




        private void LoadMockDataToLists()
        {
            University.LoadMockData();    //load mock data to object

            PopulateListBoxColumns();

            foreach (Professor professor in University.Professors)
            {
                // we add to the list
                crtlProfessorList.Items.Add($"{professor.ID}\t{professor.Name}\t{professor.Surname}\t{professor.Age}\t{professor.Rank}");
            }
            foreach (Student student in University.Students)
            {
                // we add to the list
                crtlStudentList.Items.Add($"{student.ID}\t{student.Name}\t{student.Surname}\t{student.Age}\t{student.RegistrationNumber}");
            }
            foreach (Course course in University.Courses)
            {
                // we add to the list
                crtlCourseList.Items.Add($"{course.ID}\t{course.Code}\t{course.Subject}\t{course.Hours}");
            }
        }

        private void PopulateListBoxColumns()
        {
            string professorListBoxDetails = "{0, -15}{1, -15}{2, -17}{3, -17}";
            crtlProfessorList.Items.Add(String.Format(professorListBoxDetails, "Name", "Surname", "Age", "Rank"));

            string studentListBoxDetails = "{0, -15}{1, -15}{2, -15}{3, -8}";
            crtlStudentList.Items.Add(String.Format(studentListBoxDetails, "Name", "Surname", "Age", "RegNumber"));

            string courseListBoxDetails = "{0, -20}{1, -25}{2, -15}";
            crtlCourseList.Items.Add(String.Format(courseListBoxDetails, "Code", "Subject", "Hours"));
        }

        private void crtlExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

