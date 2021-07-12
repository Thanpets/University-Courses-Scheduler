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

        #endregion

        #region new code
        private void MainForm_Load(object sender, EventArgs e)
        {
            //SerializeToJson();



            //load mock data to prof,student,course grids
            University.LoadMockData();
            ctrlProfessorList.DataSource = University.Professors;
            ctrlStudentList.DataSource = University.Students;
            ctrlCourseList.DataSource = University.Courses;



            // todo : load data on enter!
        }




        private void ctrlAddNewSchedule_Click(object sender, EventArgs e)
        {

            GetSelectedValues(out Guid courseID, out Guid professorID, out Guid studentID, out DateTime calendar, out string courseTime);

            if (string.IsNullOrEmpty(courseTime))
            {
                MessageBox.Show("Please pick a Course Time before adding a new schedule");
                return;
            }

            if (ValidateStudentCourses(calendar, studentID) == false)
            {
                return;
            }
            if (ValidateProfessorCourses(calendar, professorID) == false)
            {
                return;
            }




            if (ValidateStudentAvailability(courseTime, calendar, studentID) == false)
            {
                return;
            }
            if (ValidateProfessorAvailability(courseTime, calendar, professorID) == false)
            {
                return;
            }
            if (true)
            {

            }


            University.AddScheduledCourse(courseID, professorID, studentID, calendar.Date, courseTime); //adding new scheduledcourse

            RefreshSchedule();  //showing data to scheduleGrid


            // TODO: 1. CANNOT ADD SAME STUDENT + PROFESSOR IN SAME DATE & HOUR

            // TODO: 2. EACH STUDENT CANNOT HAVE MORE THAN 3 COURSES PER DAY!

            // TODO: 3. A PROFESSOR CANNOT TEACH MORE THAN 4 COURSES PER DAY AND 40 COURSES PER WEEK



        }

        public bool ValidateProfessorCourses(DateTime calendar, Guid professorID)
        {
            // validates if professor is not occupied with another course at time.
            var professorSchedule = University.ScheduledCourses.Where(x => x.ProfessorID == professorID);
            var countDailyCourses = professorSchedule.Count(x => x.Date == calendar.Date);

            if (countDailyCourses >= 4)
            {
                MessageBox.Show("Selected Professor already scheduled to 4 courses in this day");
                return false;
            }
            return true;
        }


        public bool ValidateStudentCourses(DateTime calendar, Guid studentID)
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
        public bool ValidateStudentAvailability(string courseTime, DateTime calendar, Guid studentID)
        {
            //validates if student is not occupied with another course at time.
            IEnumerable<Schedule> studentSchedule = University.ScheduledCourses.Where(x => x.StudentID == studentID);
            foreach (Schedule schedule in studentSchedule)
            {
                if (schedule.Date == calendar.Date)
                {
                    if (schedule.CourseTime == courseTime)
                    {
                        MessageBox.Show("Selected Student is in another course in selected hour");
                        return false;
                    }
                }
            }
            return true;
        }

        public bool ValidateProfessorAvailability(string courseTime, DateTime calendar, Guid professorID)
        {
            //validates if professor is not occupied with another lesson at time.
            IEnumerable<Schedule> professorSchedule = University.ScheduledCourses.Where(x => x.ProfessorID == professorID);
            foreach (Schedule schedule in professorSchedule)
            {
                if (schedule.Date == calendar.Date)
                {
                    if (schedule.CourseTime == courseTime)
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




        private void SerializeToJson()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string data = serializer.Serialize(University);
            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            File.WriteAllText(path, data);

        }








        private void ctrlExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ctrlUpdateSelected_Click(object sender, EventArgs e)
        {
            
            if (University.ScheduledCourses.Count < 1)
            {
                MessageBox.Show("Please select a schedule to update");
                return;
            }
            GetSelectedValues(out Guid scheduleID, out Guid courseID, out Guid professorID, out Guid studentID, out DateTime calendar, out string courseTime);
            University.UpdateScheduledCourse(scheduleID, courseID, professorID, studentID, calendar.Date, courseTime);
            
            RefreshSchedule();


        }



        private void ctrlDeleteSchedule_Click(object sender, EventArgs e)
        {


            if (University.ScheduledCourses.Count < 1)
            {
                MessageBox.Show("No selected schedule found to delete.");
                return;
            }
            var selectedSchedule = ctrlScheduleList.SelectedRows;
            var scheduleID = (Guid)selectedSchedule[0].Cells[7].Value;
            University.DeleteScheduledCourse(scheduleID);
        }

        private void RefreshSchedule()
        {
            
            ctrlScheduleList.DataSource = University.ScheduledCourses;
        }

        private void GetSelectedValues(out Guid courseID, out Guid professorID, out Guid studentID, out DateTime date, out string courseTime)
        {
            DataGridViewSelectedRowCollection selectedProfessor = ctrlProfessorList.SelectedRows;
            DataGridViewSelectedRowCollection selectedCourse = ctrlCourseList.SelectedRows;
            DataGridViewSelectedRowCollection selectedStudent = ctrlStudentList.SelectedRows;
            //getting selected IDS
            professorID = (Guid)selectedProfessor[0].Cells[4].Value;
            studentID = (Guid)selectedStudent[0].Cells[4].Value;
            courseID = (Guid)selectedCourse[0].Cells[4].Value;

            ctrlDatePicker.CustomFormat = "dd/MM/yyyy";  //change format to remove hour from calendar

            date = ctrlDatePicker.Value;

            courseTime = ctrlCourseHours.Text;
        }

        private void GetSelectedValues(out Guid scheduleID, out Guid courseID, out Guid professorID, out Guid studentID, out DateTime date, out string courseTime)
        {
            //overload method with scheduleid
            DataGridViewSelectedRowCollection selectedProfessor = ctrlProfessorList.SelectedRows;
            DataGridViewSelectedRowCollection selectedCourse = ctrlCourseList.SelectedRows;
            DataGridViewSelectedRowCollection selectedStudent = ctrlStudentList.SelectedRows;
            //getting selected IDS
            professorID = (Guid)selectedProfessor[0].Cells[4].Value;
            studentID = (Guid)selectedStudent[0].Cells[4].Value;
            courseID = (Guid)selectedCourse[0].Cells[4].Value;

            
            var selectedSchedule = ctrlScheduleList.SelectedRows;    //schedule id 
            scheduleID = (Guid)selectedSchedule[0].Cells[7].Value;

            ctrlDatePicker.CustomFormat = "dd/MM/yyyy";  //change format to remove hour from calendar

            date = ctrlDatePicker.Value;

            courseTime = ctrlCourseHours.Text;
        }
    }
}

