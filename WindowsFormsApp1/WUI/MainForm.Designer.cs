
namespace WindowsFormsApp1.WUI {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.ctrlSchedule = new System.Windows.Forms.ListBox();
            this.crtlStudentList = new System.Windows.Forms.ListBox();
            this.crtlCourseList = new System.Windows.Forms.ListBox();
            this.crtlProfessorList = new System.Windows.Forms.ListBox();
            this.crtlAddNewSchedule = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.crtlDatePicker = new System.Windows.Forms.DateTimePicker();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initializeDedomenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addToScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crtlExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crtlCourseList2 = new System.Windows.Forms.DataGridView();
            this.crtlStudentList2 = new System.Windows.Forms.DataGridView();
            this.ctrlProfessorList2 = new System.Windows.Forms.DataGridView();
            this.crtlScheduleList = new System.Windows.Forms.DataGridView();
            this.scheduleProfessorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleProfessorSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleStudentSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleCourseSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctrlAvailableHours = new System.Windows.Forms.ComboBox();
            this.scheduleLessonTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtlCourseList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlStudentList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProfessorList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlScheduleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlSchedule
            // 
            this.ctrlSchedule.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlSchedule.FormattingEnabled = true;
            this.ctrlSchedule.ItemHeight = 25;
            this.ctrlSchedule.Location = new System.Drawing.Point(1071, 493);
            this.ctrlSchedule.Name = "ctrlSchedule";
            this.ctrlSchedule.Size = new System.Drawing.Size(526, 179);
            this.ctrlSchedule.TabIndex = 7;
            // 
            // crtlStudentList
            // 
            this.crtlStudentList.BackColor = System.Drawing.Color.LightBlue;
            this.crtlStudentList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.crtlStudentList.FormattingEnabled = true;
            this.crtlStudentList.ItemHeight = 21;
            this.crtlStudentList.Location = new System.Drawing.Point(379, -26);
            this.crtlStudentList.Name = "crtlStudentList";
            this.crtlStudentList.Size = new System.Drawing.Size(350, 109);
            this.crtlStudentList.TabIndex = 6;
            // 
            // crtlCourseList
            // 
            this.crtlCourseList.BackColor = System.Drawing.Color.LightBlue;
            this.crtlCourseList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.crtlCourseList.FormattingEnabled = true;
            this.crtlCourseList.ItemHeight = 21;
            this.crtlCourseList.Location = new System.Drawing.Point(758, -15);
            this.crtlCourseList.Name = "crtlCourseList";
            this.crtlCourseList.Size = new System.Drawing.Size(350, 109);
            this.crtlCourseList.TabIndex = 5;
            // 
            // crtlProfessorList
            // 
            this.crtlProfessorList.BackColor = System.Drawing.Color.LightBlue;
            this.crtlProfessorList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.crtlProfessorList.FormattingEnabled = true;
            this.crtlProfessorList.ItemHeight = 21;
            this.crtlProfessorList.Location = new System.Drawing.Point(23, -15);
            this.crtlProfessorList.Name = "crtlProfessorList";
            this.crtlProfessorList.Size = new System.Drawing.Size(350, 109);
            this.crtlProfessorList.TabIndex = 4;
            // 
            // crtlAddNewSchedule
            // 
            this.crtlAddNewSchedule.Location = new System.Drawing.Point(749, 103);
            this.crtlAddNewSchedule.Name = "crtlAddNewSchedule";
            this.crtlAddNewSchedule.Size = new System.Drawing.Size(187, 47);
            this.crtlAddNewSchedule.TabIndex = 8;
            this.crtlAddNewSchedule.Text = "Add New Schedule";
            this.crtlAddNewSchedule.UseVisualStyleBackColor = true;
            this.crtlAddNewSchedule.Click += new System.EventHandler(this.crtlAddNewSchedule_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(838, 659);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(143, 32);
            this.button8.TabIndex = 9;
            this.button8.Text = "Remove";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // crtlDatePicker
            // 
            this.crtlDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.crtlDatePicker.Location = new System.Drawing.Point(393, 114);
            this.crtlDatePicker.Name = "crtlDatePicker";
            this.crtlDatePicker.Size = new System.Drawing.Size(200, 20);
            this.crtlDatePicker.TabIndex = 10;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(866, 621);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(143, 32);
            this.button9.TabIndex = 11;
            this.button9.Text = "Load";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(693, 621);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(143, 32);
            this.button10.TabIndex = 12;
            this.button10.Text = "Save";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(398, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(426, 42);
            this.label6.TabIndex = 13;
            this.label6.Text = "University Courses Scheduler";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(693, 679);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(187, 32);
            this.button11.TabIndex = 14;
            this.button11.Text = "Initialize (only run once!)";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.crtlExitApplication});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1427, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializeDedomenaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addToScheduleToolStripMenuItem,
            this.toolStripMenuItem2,
            this.loadDataToolStripMenuItem,
            this.saveDataToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // initializeDedomenaToolStripMenuItem
            // 
            this.initializeDedomenaToolStripMenuItem.Name = "initializeDedomenaToolStripMenuItem";
            this.initializeDedomenaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.initializeDedomenaToolStripMenuItem.Text = "Initialize Dedomena";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 6);
            // 
            // addToScheduleToolStripMenuItem
            // 
            this.addToScheduleToolStripMenuItem.Name = "addToScheduleToolStripMenuItem";
            this.addToScheduleToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addToScheduleToolStripMenuItem.Text = "Add To Schedule...";
            this.addToScheduleToolStripMenuItem.Click += new System.EventHandler(this.addToScheduleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(175, 6);
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.loadDataToolStripMenuItem.Text = "Load Data";
            this.loadDataToolStripMenuItem.Click += new System.EventHandler(this.loadDataToolStripMenuItem_Click);
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveDataToolStripMenuItem.Text = "Save Data";
            this.saveDataToolStripMenuItem.Click += new System.EventHandler(this.saveDataToolStripMenuItem_Click);
            // 
            // crtlExitApplication
            // 
            this.crtlExitApplication.Name = "crtlExitApplication";
            this.crtlExitApplication.Size = new System.Drawing.Size(38, 20);
            this.crtlExitApplication.Text = "Exit";
            this.crtlExitApplication.Click += new System.EventHandler(this.crtlExitApplication_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.ctrlAvailableHours);
            this.panel1.Controls.Add(this.crtlCourseList2);
            this.panel1.Controls.Add(this.crtlStudentList2);
            this.panel1.Controls.Add(this.ctrlProfessorList2);
            this.panel1.Controls.Add(this.crtlProfessorList);
            this.panel1.Controls.Add(this.crtlStudentList);
            this.panel1.Controls.Add(this.crtlCourseList);
            this.panel1.Controls.Add(this.crtlDatePicker);
            this.panel1.Controls.Add(this.crtlAddNewSchedule);
            this.panel1.Location = new System.Drawing.Point(56, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 373);
            this.panel1.TabIndex = 17;
            // 
            // crtlCourseList2
            // 
            this.crtlCourseList2.AllowUserToAddRows = false;
            this.crtlCourseList2.AllowUserToDeleteRows = false;
            this.crtlCourseList2.AutoGenerateColumns = false;
            this.crtlCourseList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crtlCourseList2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn3});
            this.crtlCourseList2.DataSource = this.courseBindingSource;
            this.crtlCourseList2.Location = new System.Drawing.Point(867, 167);
            this.crtlCourseList2.Name = "crtlCourseList2";
            this.crtlCourseList2.ReadOnly = true;
            this.crtlCourseList2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.crtlCourseList2.Size = new System.Drawing.Size(369, 150);
            this.crtlCourseList2.TabIndex = 14;
            // 
            // crtlStudentList2
            // 
            this.crtlStudentList2.AllowUserToAddRows = false;
            this.crtlStudentList2.AllowUserToDeleteRows = false;
            this.crtlStudentList2.AutoGenerateColumns = false;
            this.crtlStudentList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crtlStudentList2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.surnameDataGridViewTextBoxColumn1,
            this.registrationNumberDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn1,
            this.iDDataGridViewTextBoxColumn2});
            this.crtlStudentList2.DataSource = this.studentBindingSource;
            this.crtlStudentList2.Location = new System.Drawing.Point(379, 167);
            this.crtlStudentList2.Name = "crtlStudentList2";
            this.crtlStudentList2.ReadOnly = true;
            this.crtlStudentList2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.crtlStudentList2.Size = new System.Drawing.Size(445, 150);
            this.crtlStudentList2.TabIndex = 13;
            // 
            // ctrlProfessorList2
            // 
            this.ctrlProfessorList2.AllowUserToAddRows = false;
            this.ctrlProfessorList2.AllowUserToDeleteRows = false;
            this.ctrlProfessorList2.AutoGenerateColumns = false;
            this.ctrlProfessorList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctrlProfessorList2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.ctrlProfessorList2.DataSource = this.professorBindingSource;
            this.ctrlProfessorList2.Location = new System.Drawing.Point(37, 100);
            this.ctrlProfessorList2.Name = "ctrlProfessorList2";
            this.ctrlProfessorList2.ReadOnly = true;
            this.ctrlProfessorList2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctrlProfessorList2.Size = new System.Drawing.Size(299, 147);
            this.ctrlProfessorList2.TabIndex = 12;
            // 
            // crtlScheduleList
            // 
            this.crtlScheduleList.AllowUserToAddRows = false;
            this.crtlScheduleList.AllowUserToDeleteRows = false;
            this.crtlScheduleList.AutoGenerateColumns = false;
            this.crtlScheduleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crtlScheduleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.courseIDDataGridViewTextBoxColumn,
            this.professorIDDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.scheduleProfessorName,
            this.scheduleProfessorSurname,
            this.scheduleStudentName,
            this.scheduleStudentSurname,
            this.scheduleCourseSubject,
            this.scheduleLessonTime,
            this.scheduleDate});
            this.crtlScheduleList.DataSource = this.scheduleBindingSource;
            this.crtlScheduleList.Location = new System.Drawing.Point(56, 463);
            this.crtlScheduleList.Name = "crtlScheduleList";
            this.crtlScheduleList.ReadOnly = true;
            this.crtlScheduleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.crtlScheduleList.Size = new System.Drawing.Size(792, 168);
            this.crtlScheduleList.TabIndex = 18;
            // 
            // scheduleProfessorName
            // 
            this.scheduleProfessorName.DataPropertyName = "ProfessorName";
            this.scheduleProfessorName.HeaderText = "Professor Name";
            this.scheduleProfessorName.Name = "scheduleProfessorName";
            this.scheduleProfessorName.ReadOnly = true;
            // 
            // scheduleProfessorSurname
            // 
            this.scheduleProfessorSurname.DataPropertyName = "ProfessorSurname";
            this.scheduleProfessorSurname.HeaderText = "Professor Surname";
            this.scheduleProfessorSurname.Name = "scheduleProfessorSurname";
            this.scheduleProfessorSurname.ReadOnly = true;
            // 
            // scheduleStudentName
            // 
            this.scheduleStudentName.DataPropertyName = "StudentName";
            this.scheduleStudentName.HeaderText = "Student Name";
            this.scheduleStudentName.Name = "scheduleStudentName";
            this.scheduleStudentName.ReadOnly = true;
            // 
            // scheduleStudentSurname
            // 
            this.scheduleStudentSurname.DataPropertyName = "StudentSurname";
            this.scheduleStudentSurname.HeaderText = "Student Surname";
            this.scheduleStudentSurname.Name = "scheduleStudentSurname";
            this.scheduleStudentSurname.ReadOnly = true;
            // 
            // scheduleCourseSubject
            // 
            this.scheduleCourseSubject.DataPropertyName = "CourseSubject";
            this.scheduleCourseSubject.HeaderText = "Course Subject";
            this.scheduleCourseSubject.Name = "scheduleCourseSubject";
            this.scheduleCourseSubject.ReadOnly = true;
            // 
            // ctrlAvailableHours
            // 
            this.ctrlAvailableHours.FormattingEnabled = true;
            this.ctrlAvailableHours.Items.AddRange(new object[] {
            "08:00-10:00",
            "10:00-12:00",
            "12:00-14:00",
            "14:00-16:00",
            "16:00-18:00",
            "18:00-20:00"});
            this.ctrlAvailableHours.Location = new System.Drawing.Point(608, 113);
            this.ctrlAvailableHours.Name = "ctrlAvailableHours";
            this.ctrlAvailableHours.Size = new System.Drawing.Size(121, 21);
            this.ctrlAvailableHours.TabIndex = 15;
            // 
            // scheduleLessonTime
            // 
            this.scheduleLessonTime.DataPropertyName = "LessonTime";
            this.scheduleLessonTime.HeaderText = "Lesson Time";
            this.scheduleLessonTime.Name = "scheduleLessonTime";
            this.scheduleLessonTime.ReadOnly = true;
            // 
            // scheduleDate
            // 
            this.scheduleDate.DataPropertyName = "Date";
            this.scheduleDate.HeaderText = "Date";
            this.scheduleDate.Name = "scheduleDate";
            this.scheduleDate.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // professorIDDataGridViewTextBoxColumn
            // 
            this.professorIDDataGridViewTextBoxColumn.DataPropertyName = "ProfessorID";
            this.professorIDDataGridViewTextBoxColumn.HeaderText = "ProfessorID";
            this.professorIDDataGridViewTextBoxColumn.Name = "professorIDDataGridViewTextBoxColumn";
            this.professorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.professorIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(WindowsFormsApp1.Impl.Schedule);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "Hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            this.hoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            this.iDDataGridViewTextBoxColumn3.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn3.Visible = false;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(WindowsFormsApp1.Impl.Course);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            this.surnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            this.registrationNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn1
            // 
            this.ageDataGridViewTextBoxColumn1.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn1.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn1.Name = "ageDataGridViewTextBoxColumn1";
            this.ageDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn2.Visible = false;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(WindowsFormsApp1.Impl.Student);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "Rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "Rank";
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            this.rankDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(WindowsFormsApp1.Impl.Professor);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1427, 723);
            this.Controls.Add(this.crtlScheduleList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.ctrlSchedule);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crtlCourseList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlStudentList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProfessorList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlScheduleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        
        private System.Windows.Forms.Button button6;
 
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
  
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox ctrlSchedule;
        private System.Windows.Forms.ListBox crtlStudentList;
        private System.Windows.Forms.ListBox crtlCourseList;
        private System.Windows.Forms.ListBox crtlProfessorList;
        private System.Windows.Forms.Button crtlAddNewSchedule;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DateTimePicker crtlDatePicker;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initializeDedomenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crtlExitApplication;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ctrlProfessorList2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView crtlStudentList2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridView crtlCourseList2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.DataGridView crtlScheduleList;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleProfessorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleProfessorSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleStudentSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleCourseSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn calendarDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox ctrlAvailableHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleLessonTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleDate;
    }
}