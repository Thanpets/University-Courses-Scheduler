using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1.WUI {

    public partial class MainForm : Form {

        private const string _JsonFile = "UniversityData.json";
        private University University = new University();

        public MainForm() {
            InitializeComponent();
        }

        #region old code
        //private void DataForm_Load(object sender, EventArgs e) {

        //    // todo : load data on enter!
        //}

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e) {

            JavaScriptSerializer r = new JavaScriptSerializer();

            University = r.Deserialize<University>(File.ReadAllText("Data.json"));

            foreach (Student item in University.Students) {
                crtlCourseList.Items.Add(item.Name + " " + item.Surname);
            }

            for (int i = 0; i < University.Courses.Count - 1; i++) {

                crtlProfessorList.Items.Add(University.Courses[i].Code + "--" + University.Courses[i].Subject);
            }


            foreach (Professor item in University.Professors) {
                crtlStudentList.Items.Add(string.Format("{0}  {1}", item.Name, item.Surname));
            }
        }

        private void saveDataToolStripMenuItem_Click(object sender, EventArgs e) {
            JavaScriptSerializer save_Serializer = new JavaScriptSerializer();

            File.WriteAllText("Data.json", save_Serializer.Serialize(University));
        }
        #endregion

        #region new code
        private void MainForm_Load(object sender, EventArgs e) {
            SerializeToJson();
            
            LoadMockDataToLists();           
            // todo : load data on enter!
        }

        //private void initializeDedomenaToolStripMenuItem_Click(object sender, EventArgs e) {

        //    //University.LoadMockData();

        //    foreach (Student a in University.Students) {
        //        crtlCourseList.Items.Add(a.Name + " " + a.Surname);
        //    }

        //    foreach (Course bb in University.Courses) {
        //        crtlProfessorList.Items.Add(bb.Code + "--" + bb.Subject);
        //    }


        //    foreach (Professor cc1 in University.Professors) {

        //        crtlStudentList.Items.Add(string.Format("{0}  {1}", cc1.Name, cc1.Surname));
        //    }

        //    //should run only once!
        //    button11.Hide();
        //}

        //private void button9_Click(object sender, EventArgs e) {

        //    JavaScriptSerializer GG = new JavaScriptSerializer();

        //    University = GG.Deserialize<University>(File.ReadAllText("Data.json"));

        //    foreach (Student item in University.Students) {
        //        crtlCourseList.Items.Add(item.Name + " " + item.Surname);
        //    }

        //    for (int i = 0; i < University.Courses.Count - 1; i++) {

        //        crtlProfessorList.Items.Add(University.Courses[i].Code + "--" + University.Courses[i].Subject);
        //    }

        //    // we do a loop
        //    foreach (Professor item in University.Professors) {
        //        // we add to the list
        //        crtlStudentList.Items.Add(string.Format("{0}  {1}", item.Name, item.Surname));
        //    }

        //}

        //private void button10_Click(object sender, EventArgs e) {
        //    JavaScriptSerializer ff = new JavaScriptSerializer();

        //    File.WriteAllText("Data.json", ff.Serialize(University));
        //}

        private void crtlAddNewSchedule_Click(object sender, EventArgs e) {

            try {
                Schedule newSchedule = new Schedule();
                //newSchedule = (Schedule)crtlProfessorList.SelectedItem;
                University.ScheduledCourses.Add(newSchedule);
                gridCourse = (DataGridViewTextBoxColumn)crtlCourseList.SelectedItem;
                gridProfessor = (DataGridViewTextBoxColumn)crtlProfessorList.SelectedItem;
                gridStudent = (DataGridViewTextBoxColumn)crtlStudentList.SelectedItem;
                // TODO: 1. CANNOT ADD SAME STUDENT + PROFESSOR IN SAME DATE & HOUR

                // TODO: 2. EACH STUDENT CANNOT HAVE MORE THAN 3 COURSES PER DAY!

                // TODO: 3. A PROFESSOR CANNOT TEACH MORE THAN 4 COURSES PER DAY AND 40 COURSES PER WEEK

                //University.ScheduledCourses.Add(new Schedule() { 
                    //Professors.Add(crtlProfessorList.SelectedItem),
                    //Courses = crtlCourseList.SelectedItem.ToString(), 
                    //Students = crtlStudentList.SelectedItem.ToString(),
                    //Calendar = dateTimePicker2.Value });

                ctrlSchedule.Items.Clear();
                foreach (Schedule item in University.ScheduledCourses) {

                    ctrlSchedule.Items.Add(item.Calendar + " | " + item.Courses + " | " + item.Students + " | " + item.Professors);

                }
            }
            catch { 
            
            }
            //finally {
            //    MessageBox.Show("all ok!");

            //}
        }

        public void validate_professorCourse_with_studentCourse() { 
        
            //TODO: ???

        }

        #endregion

        private void button11_Click(object sender, EventArgs e) {

            

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

        private void addToScheduleToolStripMenuItem_Click(object sender, EventArgs e) {

            // todo : display on a grid??

            // todo: add exception handling?
                //University.Schedules.Add(new Schedule() { 
                //    Course = crtlProfessorList.SelectedItem.ToString(),
                //    Student = crtlCourseList.SelectedItem.ToString(),
                //    Professor = crtlStudentList.SelectedItem.ToString(), 
                //    Calendar = dateTimePicker2.Value });

                ctrlSchedule.Items.Clear();
                foreach (Schedule schedule in University.ScheduledCourses) {

                    ctrlSchedule.Items.Add(
                        schedule.Calendar + " " + 
                        schedule.Courses + " " + 
                        schedule.Students + " " + 
                        schedule.Professors);

                }
        
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
                crtlProfessorList.Items.Add($"{professor.Name}\t{professor.Surname}\t{professor.Age}\t{professor.Rank}");
            }
            foreach (Student student in University.Students)
            {
                // we add to the list
                crtlStudentList.Items.Add($"{student.Name}\t{student.Surname}\t{student.Age}\t{student.RegistrationNumber}");
            }
            foreach (Course course in University.Courses)
            {
                // we add to the list
                crtlCourseList.Items.Add($"{course.Code}\t{course.Subject}\t  {course.Hours}");
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

