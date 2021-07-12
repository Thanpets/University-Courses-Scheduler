
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ctrlAddNewSchedule = new System.Windows.Forms.Button();
            this.ctrlDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctrlMenuSaveChanges = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ctrlUpdateSchedule = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ctrlCourseHours = new System.Windows.Forms.ComboBox();
            this.ctrlCourseGrid = new System.Windows.Forms.DataGridView();
            this.ctrlStudentGrid = new System.Windows.Forms.DataGridView();
            this.ctrlProfessorGrid = new System.Windows.Forms.DataGridView();
            this.crtlScheduleGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.ctrlDeleteSchedule = new System.Windows.Forms.Button();
            this.ctrlSaveChanges = new System.Windows.Forms.Button();
            this.scheduleProfessorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleProfessorSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleStudentSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleCourseSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleCourseTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeachingCourses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendingCourses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCourseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlStudentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProfessorGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlScheduleGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlAddNewSchedule
            // 
            this.ctrlAddNewSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlAddNewSchedule.Location = new System.Drawing.Point(634, 295);
            this.ctrlAddNewSchedule.Name = "ctrlAddNewSchedule";
            this.ctrlAddNewSchedule.Size = new System.Drawing.Size(146, 55);
            this.ctrlAddNewSchedule.TabIndex = 8;
            this.ctrlAddNewSchedule.Text = "Add New Schedule";
            this.ctrlAddNewSchedule.UseVisualStyleBackColor = false;
            this.ctrlAddNewSchedule.Click += new System.EventHandler(this.ctrlAddNewSchedule_Click);
            // 
            // ctrlDatePicker
            // 
            this.ctrlDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctrlDatePicker.Location = new System.Drawing.Point(655, 254);
            this.ctrlDatePicker.Name = "ctrlDatePicker";
            this.ctrlDatePicker.Size = new System.Drawing.Size(115, 20);
            this.ctrlDatePicker.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(698, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(426, 42);
            this.label6.TabIndex = 13;
            this.label6.Text = "University Courses Scheduler";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.ctrlExitApplication});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1842, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.ctrlMenuSaveChanges});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.mainToolStripMenuItem.Text = "Main Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(195, 6);
            // 
            // ctrlMenuSaveChanges
            // 
            this.ctrlMenuSaveChanges.Name = "ctrlMenuSaveChanges";
            this.ctrlMenuSaveChanges.Size = new System.Drawing.Size(198, 22);
            this.ctrlMenuSaveChanges.Text = "Save Schedule Changes";
            this.ctrlMenuSaveChanges.Click += new System.EventHandler(this.ctrlMenuSaveChanges_Click);
            // 
            // ctrlExitApplication
            // 
            this.ctrlExitApplication.Name = "ctrlExitApplication";
            this.ctrlExitApplication.Size = new System.Drawing.Size(38, 20);
            this.ctrlExitApplication.Text = "Exit";
            this.ctrlExitApplication.Click += new System.EventHandler(this.ctrlExitApplication_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ctrlUpdateSchedule);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ctrlCourseHours);
            this.panel1.Controls.Add(this.ctrlCourseGrid);
            this.panel1.Controls.Add(this.ctrlStudentGrid);
            this.panel1.Controls.Add(this.ctrlProfessorGrid);
            this.panel1.Controls.Add(this.ctrlDatePicker);
            this.panel1.Controls.Add(this.ctrlAddNewSchedule);
            this.panel1.Location = new System.Drawing.Point(184, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1464, 352);
            this.panel1.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(796, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Course Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(671, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Course Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1220, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Courses";
            // 
            // ctrlUpdateSchedule
            // 
            this.ctrlUpdateSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlUpdateSchedule.Location = new System.Drawing.Point(786, 295);
            this.ctrlUpdateSchedule.Name = "ctrlUpdateSchedule";
            this.ctrlUpdateSchedule.Size = new System.Drawing.Size(139, 55);
            this.ctrlUpdateSchedule.TabIndex = 19;
            this.ctrlUpdateSchedule.Text = "Update Selected Schedule";
            this.ctrlUpdateSchedule.UseVisualStyleBackColor = false;
            this.ctrlUpdateSchedule.Click += new System.EventHandler(this.ctrlUpdateSelected_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(760, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Students";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(187, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Professors";
            // 
            // ctrlCourseHours
            // 
            this.ctrlCourseHours.FormattingEnabled = true;
            this.ctrlCourseHours.Items.AddRange(new object[] {
            "08:00-10:00",
            "10:00-12:00",
            "12:00-14:00",
            "14:00-16:00",
            "16:00-18:00",
            "18:00-20:00"});
            this.ctrlCourseHours.Location = new System.Drawing.Point(793, 254);
            this.ctrlCourseHours.Name = "ctrlCourseHours";
            this.ctrlCourseHours.Size = new System.Drawing.Size(101, 21);
            this.ctrlCourseHours.TabIndex = 15;
            // 
            // ctrlCourseGrid
            // 
            this.ctrlCourseGrid.AllowUserToAddRows = false;
            this.ctrlCourseGrid.AllowUserToDeleteRows = false;
            this.ctrlCourseGrid.AutoGenerateColumns = false;
            this.ctrlCourseGrid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.ctrlCourseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctrlCourseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn3});
            this.ctrlCourseGrid.DataSource = this.courseBindingSource;
            this.ctrlCourseGrid.Location = new System.Drawing.Point(1083, 30);
            this.ctrlCourseGrid.MultiSelect = false;
            this.ctrlCourseGrid.Name = "ctrlCourseGrid";
            this.ctrlCourseGrid.ReadOnly = true;
            this.ctrlCourseGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctrlCourseGrid.Size = new System.Drawing.Size(343, 189);
            this.ctrlCourseGrid.TabIndex = 14;
            // 
            // ctrlStudentGrid
            // 
            this.ctrlStudentGrid.AllowUserToAddRows = false;
            this.ctrlStudentGrid.AllowUserToDeleteRows = false;
            this.ctrlStudentGrid.AutoGenerateColumns = false;
            this.ctrlStudentGrid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.ctrlStudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctrlStudentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.surnameDataGridViewTextBoxColumn1,
            this.ageDataGridViewTextBoxColumn1,
            this.registrationNumberDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn2,
            this.AttendingCourses});
            this.ctrlStudentGrid.DataSource = this.studentBindingSource;
            this.ctrlStudentGrid.Location = new System.Drawing.Point(560, 30);
            this.ctrlStudentGrid.MultiSelect = false;
            this.ctrlStudentGrid.Name = "ctrlStudentGrid";
            this.ctrlStudentGrid.ReadOnly = true;
            this.ctrlStudentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctrlStudentGrid.Size = new System.Drawing.Size(500, 189);
            this.ctrlStudentGrid.TabIndex = 13;
            // 
            // ctrlProfessorGrid
            // 
            this.ctrlProfessorGrid.AllowUserToAddRows = false;
            this.ctrlProfessorGrid.AllowUserToDeleteRows = false;
            this.ctrlProfessorGrid.AutoGenerateColumns = false;
            this.ctrlProfessorGrid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.ctrlProfessorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctrlProfessorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.TeachingCourses});
            this.ctrlProfessorGrid.DataSource = this.professorBindingSource;
            this.ctrlProfessorGrid.Location = new System.Drawing.Point(30, 30);
            this.ctrlProfessorGrid.MultiSelect = false;
            this.ctrlProfessorGrid.Name = "ctrlProfessorGrid";
            this.ctrlProfessorGrid.ReadOnly = true;
            this.ctrlProfessorGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctrlProfessorGrid.Size = new System.Drawing.Size(483, 189);
            this.ctrlProfessorGrid.TabIndex = 12;
            // 
            // crtlScheduleGrid
            // 
            this.crtlScheduleGrid.AllowUserToAddRows = false;
            this.crtlScheduleGrid.AutoGenerateColumns = false;
            this.crtlScheduleGrid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.crtlScheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crtlScheduleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scheduleProfessorName,
            this.scheduleProfessorSurname,
            this.scheduleStudentName,
            this.scheduleStudentSurname,
            this.scheduleCourseSubject,
            this.scheduleCourseTime,
            this.scheduleDate,
            this.iDDataGridViewTextBoxColumn1,
            this.studentIDDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn,
            this.professorIDDataGridViewTextBoxColumn});
            this.crtlScheduleGrid.DataSource = this.scheduleBindingSource;
            this.crtlScheduleGrid.Location = new System.Drawing.Point(197, 53);
            this.crtlScheduleGrid.Name = "crtlScheduleGrid";
            this.crtlScheduleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.crtlScheduleGrid.Size = new System.Drawing.Size(743, 246);
            this.crtlScheduleGrid.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.ctrlSaveChanges);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.ctrlDeleteSchedule);
            this.panel2.Controls.Add(this.crtlScheduleGrid);
            this.panel2.Location = new System.Drawing.Point(184, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1464, 352);
            this.panel2.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(510, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 24);
            this.label14.TabIndex = 21;
            this.label14.Text = "Schedules";
            // 
            // ctrlDeleteSchedule
            // 
            this.ctrlDeleteSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlDeleteSchedule.Location = new System.Drawing.Point(1011, 53);
            this.ctrlDeleteSchedule.Name = "ctrlDeleteSchedule";
            this.ctrlDeleteSchedule.Size = new System.Drawing.Size(239, 56);
            this.ctrlDeleteSchedule.TabIndex = 20;
            this.ctrlDeleteSchedule.Text = "Delete Selected Schedule";
            this.ctrlDeleteSchedule.UseVisualStyleBackColor = false;
            this.ctrlDeleteSchedule.Click += new System.EventHandler(this.ctrlDeleteSchedule_Click);
            // 
            // ctrlSaveChanges
            // 
            this.ctrlSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlSaveChanges.Location = new System.Drawing.Point(1011, 243);
            this.ctrlSaveChanges.Name = "ctrlSaveChanges";
            this.ctrlSaveChanges.Size = new System.Drawing.Size(239, 56);
            this.ctrlSaveChanges.TabIndex = 22;
            this.ctrlSaveChanges.Text = "Save Schedule Changes";
            this.ctrlSaveChanges.UseVisualStyleBackColor = false;
            this.ctrlSaveChanges.Click += new System.EventHandler(this.ctrlSaveChanges_Click);
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
            // scheduleCourseTime
            // 
            this.scheduleCourseTime.DataPropertyName = "CourseTime";
            this.scheduleCourseTime.HeaderText = "Course Time";
            this.scheduleCourseTime.Name = "scheduleCourseTime";
            this.scheduleCourseTime.ReadOnly = true;
            this.scheduleCourseTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // scheduleDate
            // 
            this.scheduleDate.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.scheduleDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.scheduleDate.HeaderText = "Date";
            this.scheduleDate.Name = "scheduleDate";
            this.scheduleDate.ReadOnly = true;
            // 
            // TeachingCourses
            // 
            this.TeachingCourses.DataPropertyName = "TeachingCoursesString";
            this.TeachingCourses.HeaderText = "Teaching Courses";
            this.TeachingCourses.Name = "TeachingCourses";
            this.TeachingCourses.ReadOnly = true;
            this.TeachingCourses.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TeachingCourses.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TeachingCourses.Width = 150;
            // 
            // AttendingCourses
            // 
            this.AttendingCourses.DataPropertyName = "AttendingCoursesString";
            this.AttendingCourses.HeaderText = "Attending Courses";
            this.AttendingCourses.Name = "AttendingCourses";
            this.AttendingCourses.ReadOnly = true;
            this.AttendingCourses.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendingCourses.Width = 150;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Visible = false;
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
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(WindowsFormsApp1.Impl.Schedule);
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.hoursDataGridViewTextBoxColumn.Width = 50;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 50;
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
            // ageDataGridViewTextBoxColumn1
            // 
            this.ageDataGridViewTextBoxColumn1.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn1.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn1.Name = "ageDataGridViewTextBoxColumn1";
            this.ageDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn1.Width = 40;
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.HeaderText = "Registration Number";
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            this.registrationNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.registrationNumberDataGridViewTextBoxColumn.Width = 65;
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
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.ageDataGridViewTextBoxColumn.Width = 30;
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "Rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "Rank";
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            this.rankDataGridViewTextBoxColumn.ReadOnly = true;
            this.rankDataGridViewTextBoxColumn.Width = 60;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(WindowsFormsApp1.Impl.Professor);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1842, 889);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCourseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlStudentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProfessorGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlScheduleGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button ctrlAddNewSchedule;
        private System.Windows.Forms.DateTimePicker ctrlDatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ctrlMenuSaveChanges;
        private System.Windows.Forms.ToolStripMenuItem ctrlExitApplication;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ctrlProfessorGrid;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView ctrlStudentGrid;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridView ctrlCourseGrid;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.DataGridView crtlScheduleGrid;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn calendarDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox ctrlCourseHours;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ctrlDeleteSchedule;
        private System.Windows.Forms.Button ctrlUpdateSchedule;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ctrlSaveChanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleProfessorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleProfessorSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleStudentSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleCourseSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleCourseTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeachingCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendingCourses;
    }
}