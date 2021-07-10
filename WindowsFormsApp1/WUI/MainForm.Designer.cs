
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
            this.ctrlSchedule = new System.Windows.Forms.ListBox();
            this.crtlStudentList = new System.Windows.Forms.ListBox();
            this.crtlCourseList = new System.Windows.Forms.ListBox();
            this.crtlProfessorList = new System.Windows.Forms.ListBox();
            this.crtlAddNewSchedule = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
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
            this.crtlScheduleList = new System.Windows.Forms.DataGridView();
            this.gridProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtlScheduleList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlSchedule
            // 
            this.ctrlSchedule.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlSchedule.FormattingEnabled = true;
            this.ctrlSchedule.ItemHeight = 25;
            this.ctrlSchedule.Location = new System.Drawing.Point(1165, 513);
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
            this.crtlStudentList.Location = new System.Drawing.Point(379, 55);
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
            this.crtlCourseList.Location = new System.Drawing.Point(751, 55);
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
            this.crtlProfessorList.Location = new System.Drawing.Point(13, 55);
            this.crtlProfessorList.Name = "crtlProfessorList";
            this.crtlProfessorList.Size = new System.Drawing.Size(350, 109);
            this.crtlProfessorList.TabIndex = 4;
            // 
            // crtlAddNewSchedule
            // 
            this.crtlAddNewSchedule.Location = new System.Drawing.Point(593, 214);
            this.crtlAddNewSchedule.Name = "crtlAddNewSchedule";
            this.crtlAddNewSchedule.Size = new System.Drawing.Size(175, 47);
            this.crtlAddNewSchedule.TabIndex = 8;
            this.crtlAddNewSchedule.Text = "Add New Schedule";
            this.crtlAddNewSchedule.UseVisualStyleBackColor = true;
            this.crtlAddNewSchedule.Click += new System.EventHandler(this.crtlAddNewSchedule_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1014, 406);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(143, 32);
            this.button8.TabIndex = 9;
            this.button8.Text = "Remove";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(379, 225);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(842, 406);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(143, 32);
            this.button9.TabIndex = 11;
            this.button9.Text = "Load";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(693, 406);
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
            this.button11.Location = new System.Drawing.Point(1185, 406);
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
            this.menuStrip1.Size = new System.Drawing.Size(1372, 24);
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
            // crtlScheduleList
            // 
            this.crtlScheduleList.BackgroundColor = System.Drawing.Color.LightBlue;
            this.crtlScheduleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crtlScheduleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridProfessor,
            this.gridStudent,
            this.gridCourse,
            this.gridDateTime});
            this.crtlScheduleList.Location = new System.Drawing.Point(96, 462);
            this.crtlScheduleList.Name = "crtlScheduleList";
            this.crtlScheduleList.Size = new System.Drawing.Size(444, 204);
            this.crtlScheduleList.TabIndex = 16;
            // 
            // gridProfessor
            // 
            this.gridProfessor.HeaderText = "Professor";
            this.gridProfessor.Name = "gridProfessor";
            // 
            // gridStudent
            // 
            this.gridStudent.HeaderText = "Student";
            this.gridStudent.Name = "gridStudent";
            // 
            // gridCourse
            // 
            this.gridCourse.HeaderText = "Course";
            this.gridCourse.Name = "gridCourse";
            // 
            // gridDateTime
            // 
            this.gridDateTime.HeaderText = "Date";
            this.gridDateTime.Name = "gridDateTime";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.crtlProfessorList);
            this.panel1.Controls.Add(this.crtlStudentList);
            this.panel1.Controls.Add(this.crtlCourseList);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.crtlAddNewSchedule);
            this.panel1.Location = new System.Drawing.Point(56, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 331);
            this.panel1.TabIndex = 17;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1372, 723);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crtlScheduleList);
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
            ((System.ComponentModel.ISupportInitialize)(this.crtlScheduleList)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
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
        private System.Windows.Forms.DataGridView crtlScheduleList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridDateTime;
    }
}