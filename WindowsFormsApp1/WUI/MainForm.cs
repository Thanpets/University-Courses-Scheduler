using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private const string _JsonFile = "UniversityScheduleData.json";
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

            //initialize/load mock data to prof,student,course grids
            if (File.Exists(_JsonFile))
            {
                DeserializeFromJson();

            }
            else
            {
                University.InitMockData();

            }
            LoadDataToGrids();
            RefreshSchedule();
            // todo : load data on enter!
        }



        private void ctrlAddNewSchedule_Click(object sender, EventArgs e)
        {

            GetSelectedValues(out Guid courseID, out Guid professorID, out Guid studentID, out DateTime calendar, out string courseTime);

            if (ScheduleValidations(calendar, professorID, studentID, courseID, courseTime) == false)
            {
                return;
            }
            else
            {
                University.AddScheduledCourse(courseID, professorID, studentID, calendar.Date, courseTime);
                RefreshSchedule();
            }

            // TODO: 1. CANNOT ADD SAME STUDENT + PROFESSOR IN SAME DATE & HOUR

            // TODO: 2. EACH STUDENT CANNOT HAVE MORE THAN 3 COURSES PER DAY!

            // TODO: 3. A PROFESSOR CANNOT TEACH MORE THAN 4 COURSES PER DAY AND 40 COURSES PER WEEK
        }


        private void ctrlUpdateSelected_Click(object sender, EventArgs e)
        {
            var selectedSchedule = crtlScheduleGrid.SelectedRows;
            if (University.ScheduledCourses.Count < 1 || selectedSchedule.Count == 0)
            {
                MessageBox.Show("Please select a schedule to update");
                return;
            }

            GetSelectedValues(out Guid scheduleID, out Guid courseID, out Guid professorID, out Guid studentID, out DateTime calendar, out string courseTime);

            if (ScheduleValidations(calendar, professorID, studentID, courseID, courseTime) == false)
            {
                return;
            }
            else
            {
                University.UpdateScheduledCourse(scheduleID, courseID, professorID, studentID, calendar.Date, courseTime);

                RefreshSchedule();
            }




        }



        private void ctrlDeleteSchedule_Click(object sender, EventArgs e)
        {


            if (University.ScheduledCourses.Count < 1)
            {
                MessageBox.Show("No selected schedule found to delete.");
                return;
            }
            var selectedSchedule = crtlScheduleGrid.SelectedRows;
            if (selectedSchedule.Count == 0)
            {
                MessageBox.Show("Please select a schedule to  delete.");
                return;
            }
            if (MessageBox.Show("Do you really want to delete selected schedule?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var scheduleID = (Guid)selectedSchedule[0].Cells[7].Value;

                University.DeleteScheduledCourse(scheduleID);
                RefreshSchedule();
            }

        }
        private void ctrlExitApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit? Any unsaved changes will be lost", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        private void ctrlSaveChanges_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to save all changes to schedules?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SerializeToJson();
            }
        }

        private void ctrlMenuSaveChanges_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to save all changes to schedules?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SerializeToJson();
            }

        }

        private bool ScheduleValidations(DateTime calendar, Guid professorID, Guid studentID, Guid courseID, string courseTime)
        {
            if (string.IsNullOrEmpty(courseTime))
            {
                MessageBox.Show("Please pick a Course Time before updating selected schedule");
                return false;
            }
            if (ValidateWeekend(calendar) == false)
            {
                return false;
            }
            if (ProfessorAndStudentCourseCheck(professorID,  studentID, courseID)==false)
            {
                return false;
            }

            if (ProfessorStudentHasSimilarCourses(professorID, studentID) == false)
            {
                return false;
            }
            if (ValidateStudentCourses(calendar, studentID) == false)
            {
                return false;
            }
            if (ValidateProfessorCourses(calendar, professorID) == false)
            {
                return false;
            }
            if (ValidateStudentAvailability(courseTime, calendar, studentID) == false)
            {
                return false;
            }
            if (ValidateProfessorAvailability(courseTime, calendar, professorID) == false)
            {
                return false;
            }
            return true;

        }
        private bool ValidateWeekend(DateTime calendar)
        {
            if (calendar.Date.DayOfWeek == DayOfWeek.Saturday || calendar.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Get a life ....");
                return false;
            }
            return true;
        }

        public bool ValidateProfessorCourses(DateTime calendar, Guid professorID)
        {
            // validates if professor is not occupied with another course at time.
            var professorSchedule = University.ScheduledCourses.Where(x => x.ProfessorID == professorID);
            var countDailyCourses = professorSchedule.Count(x => x.Date.Date == calendar.Date);

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
            var countDailyLessons = studentSchedule.Count(x => x.Date.Date == calendar.Date);

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
                if (schedule.Date.Date == calendar.Date && schedule.CourseTime == courseTime)
                {

                    MessageBox.Show("Selected Student is in another course in selected hour");
                    return false;

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
                if (schedule.Date.Date == calendar.Date && schedule.CourseTime == courseTime)
                {

                    MessageBox.Show("Selected Professor is in another scheduled course in selected hour");
                    return false;

                }
            }
            return true;
        }




        private bool ProfessorAndStudentCourseCheck(Guid professorID, Guid studentID,Guid courseID)
        {
            Professor professor = University.Professors.FirstOrDefault(x => x.ID == professorID);
            Student student = University.Students.FirstOrDefault(x => x.ID == studentID);
            Course course = University.Courses.FirstOrDefault(x => x.ID == courseID);
            bool professorCanTeach = false;
            bool studentCanLearn = false;
            foreach (var professorCourse in professor.TeachingCourses)
            {
                if (professorCourse==course.Category)
                {
                    professorCanTeach = true;
                }
            }
            foreach (var studentCourse in student.AttendingCourses)
            {
                if (studentCourse == course.Category)
                {
                    studentCanLearn = true;
                }

            }
            if (professorCanTeach == true && studentCanLearn == true)
            {
                return true;
            }
            else
            {
                if (professorCanTeach == false)
                {
                    MessageBox.Show("Professor cannot teach the selected course");
                }
                if (studentCanLearn== false )
                {
                    MessageBox.Show("Student cannot learn the selected course");
                }
                return false;
            }

        }
        private bool ProfessorStudentHasSimilarCourses(Guid professorID, Guid studentID)
        {
            Professor professor = University.Professors.FirstOrDefault(x => x.ID == professorID);
            Student student = University.Students.FirstOrDefault(x => x.ID == studentID);
            foreach (var professorCanTeach in professor.TeachingCourses)
            {
                foreach (var studentCanLearn in student.AttendingCourses)
                {
                    if (professorCanTeach == studentCanLearn)
                    {
                        return true;
                    }

                }

            }
            MessageBox.Show("Professor with student  should have at least one same course");
            return false;
           


        }






        private void SerializeToJson()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string data = serializer.Serialize(University);
            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            File.WriteAllText(path, data);

        }
        private void DeserializeFromJson()
        {
            try
            {

                JavaScriptSerializer serializer = new JavaScriptSerializer();

                string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

                if (File.Exists(path))
                {
                    string data = File.ReadAllText(path);

                    University = serializer.Deserialize<University>(data);

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



        private void RefreshSchedule()
        {

            crtlScheduleGrid.DataSource = University.ScheduledCourses;
            crtlScheduleGrid.Refresh();
        }
        private void LoadDataToGrids()
        {
            ctrlProfessorGrid.DataSource = University.Professors;
            ctrlStudentGrid.DataSource = University.Students;
            ctrlCourseGrid.DataSource = University.Courses;
        }

        private void GetSelectedValues(out Guid courseID, out Guid professorID, out Guid studentID, out DateTime date, out string courseTime)
        {
            DataGridViewSelectedRowCollection selectedProfessor = ctrlProfessorGrid.SelectedRows;
            DataGridViewSelectedRowCollection selectedCourse = ctrlCourseGrid.SelectedRows;
            DataGridViewSelectedRowCollection selectedStudent = ctrlStudentGrid.SelectedRows;
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
            DataGridViewSelectedRowCollection selectedProfessor = ctrlProfessorGrid.SelectedRows;
            DataGridViewSelectedRowCollection selectedCourse = ctrlCourseGrid.SelectedRows;
            DataGridViewSelectedRowCollection selectedStudent = ctrlStudentGrid.SelectedRows;
            //getting selected IDS
            professorID = (Guid)selectedProfessor[0].Cells[4].Value;                 //cannot get cells.{"ID"} because ID column is hidden
            studentID = (Guid)selectedStudent[0].Cells[4].Value;
            courseID = (Guid)selectedCourse[0].Cells[4].Value;


            var selectedSchedule = crtlScheduleGrid.SelectedRows;    //schedule id 

            scheduleID = (Guid)selectedSchedule[0].Cells[7].Value;

            ctrlDatePicker.CustomFormat = "dd/MM/yyyy";  //change format to remove hour from calendar

            date = ctrlDatePicker.Value;

            courseTime = ctrlCourseHours.Text;

        }



        #endregion
    }
}

