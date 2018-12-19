namespace StudentEnrollment
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label12 = new System.Windows.Forms.Label();
			this.printRoster = new System.Windows.Forms.Button();
			this.enrollStudent = new System.Windows.Forms.Button();
			this.dropStudent = new System.Windows.Forms.Button();
			this.applySearchCriteria = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.searchStudentByZid = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.searchCourseByDept = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.studentNameTB = new System.Windows.Forms.TextBox();
			this.studentZidTB = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.addStudent = new System.Windows.Forms.Button();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.courseNumTB = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.sectionNumTB = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.StudentMajorCB = new System.Windows.Forms.ComboBox();
			this.StudentAcadYearCB = new System.Windows.Forms.ComboBox();
			this.DeptCodeCB = new System.Windows.Forms.ComboBox();
			this.addCourse = new System.Windows.Forms.Button();
			this.outputDisplay = new System.Windows.Forms.RichTextBox();
			this.courseCapacity = new System.Windows.Forms.NumericUpDown();
			this.studDisplay = new System.Windows.Forms.ListBox();
			this.courDisplay = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.courseCapacity)).BeginInit();
			this.SuspendLayout();
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(270, 9);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(365, 25);
			this.label12.TabIndex = 0;
			this.label12.Text = "NIU Enrollment Management System";
			// 
			// printRoster
			// 
			this.printRoster.Location = new System.Drawing.Point(30, 60);
			this.printRoster.Name = "printRoster";
			this.printRoster.Size = new System.Drawing.Size(123, 26);
			this.printRoster.TabIndex = 1;
			this.printRoster.Text = "Print Course Roster";
			this.printRoster.UseVisualStyleBackColor = true;
			this.printRoster.Click += new System.EventHandler(this.printRoster_Click);
			// 
			// enrollStudent
			// 
			this.enrollStudent.Location = new System.Drawing.Point(30, 92);
			this.enrollStudent.Name = "enrollStudent";
			this.enrollStudent.Size = new System.Drawing.Size(123, 26);
			this.enrollStudent.TabIndex = 2;
			this.enrollStudent.Text = "Enroll Student";
			this.enrollStudent.UseVisualStyleBackColor = true;
			this.enrollStudent.Click += new System.EventHandler(this.enrollStudent_Click);
			// 
			// dropStudent
			// 
			this.dropStudent.Location = new System.Drawing.Point(30, 124);
			this.dropStudent.Name = "dropStudent";
			this.dropStudent.Size = new System.Drawing.Size(123, 26);
			this.dropStudent.TabIndex = 3;
			this.dropStudent.Text = "Drop Student";
			this.dropStudent.UseVisualStyleBackColor = true;
			this.dropStudent.Click += new System.EventHandler(this.dropStudent_Click);
			// 
			// applySearchCriteria
			// 
			this.applySearchCriteria.Location = new System.Drawing.Point(30, 156);
			this.applySearchCriteria.Name = "applySearchCriteria";
			this.applySearchCriteria.Size = new System.Drawing.Size(123, 26);
			this.applySearchCriteria.TabIndex = 4;
			this.applySearchCriteria.Text = "Apply Search Criteria ";
			this.applySearchCriteria.UseVisualStyleBackColor = true;
			this.applySearchCriteria.Click += new System.EventHandler(this.applySearchCriteria_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(172, 60);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(128, 13);
			this.label13.TabIndex = 5;
			this.label13.Text = "Search Student ( by ZID )";
			// 
			// searchStudentByZid
			// 
			this.searchStudentByZid.Location = new System.Drawing.Point(175, 77);
			this.searchStudentByZid.Name = "searchStudentByZid";
			this.searchStudentByZid.Size = new System.Drawing.Size(125, 20);
			this.searchStudentByZid.TabIndex = 6;
			this.searchStudentByZid.TextChanged += new System.EventHandler(this.searchStudentByZid_TextChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(172, 105);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(129, 13);
			this.label14.TabIndex = 7;
			this.label14.Text = "Search Course ( by Dept )";
			// 
			// searchCourseByDept
			// 
			this.searchCourseByDept.Location = new System.Drawing.Point(175, 121);
			this.searchCourseByDept.Name = "searchCourseByDept";
			this.searchCourseByDept.Size = new System.Drawing.Size(125, 20);
			this.searchCourseByDept.TabIndex = 8;
			this.searchCourseByDept.TextChanged += new System.EventHandler(this.searchCourseByDept_TextChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(27, 208);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(111, 13);
			this.label15.TabIndex = 9;
			this.label15.Text = "Last Name,First Name";
			// 
			// studentNameTB
			// 
			this.studentNameTB.Location = new System.Drawing.Point(30, 225);
			this.studentNameTB.Name = "studentNameTB";
			this.studentNameTB.Size = new System.Drawing.Size(120, 20);
			this.studentNameTB.TabIndex = 10;
			this.studentNameTB.TextChanged += new System.EventHandler(this.studentNameTB_TextChanged);
			// 
			// studentZidTB
			// 
			this.studentZidTB.Location = new System.Drawing.Point(175, 225);
			this.studentZidTB.Name = "studentZidTB";
			this.studentZidTB.Size = new System.Drawing.Size(120, 20);
			this.studentZidTB.TabIndex = 11;
			this.studentZidTB.TextChanged += new System.EventHandler(this.studentZidTB_TextChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(175, 208);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(28, 13);
			this.label16.TabIndex = 12;
			this.label16.Text = "Z-ID";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(27, 252);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(33, 13);
			this.label17.TabIndex = 13;
			this.label17.Text = "Major";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(175, 252);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(79, 13);
			this.label18.TabIndex = 14;
			this.label18.Text = "Academic Year";
			// 
			// addStudent
			// 
			this.addStudent.Location = new System.Drawing.Point(30, 303);
			this.addStudent.Name = "addStudent";
			this.addStudent.Size = new System.Drawing.Size(108, 23);
			this.addStudent.TabIndex = 17;
			this.addStudent.Text = "Add Student";
			this.addStudent.UseVisualStyleBackColor = true;
			this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(30, 353);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(90, 13);
			this.label19.TabIndex = 18;
			this.label19.Text = "Department Code";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(172, 353);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(80, 13);
			this.label20.TabIndex = 20;
			this.label20.Text = "Course Number";
			// 
			// courseNumTB
			// 
			this.courseNumTB.Location = new System.Drawing.Point(175, 369);
			this.courseNumTB.Name = "courseNumTB";
			this.courseNumTB.Size = new System.Drawing.Size(120, 20);
			this.courseNumTB.TabIndex = 21;
			this.courseNumTB.TextChanged += new System.EventHandler(this.courseNumTB_TextChanged);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(30, 396);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(83, 13);
			this.label21.TabIndex = 22;
			this.label21.Text = "Section Number";
			// 
			// sectionNumTB
			// 
			this.sectionNumTB.Location = new System.Drawing.Point(30, 412);
			this.sectionNumTB.Name = "sectionNumTB";
			this.sectionNumTB.Size = new System.Drawing.Size(120, 20);
			this.sectionNumTB.TabIndex = 23;
			this.sectionNumTB.TextChanged += new System.EventHandler(this.sectionNumTB_TextChanged);
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(175, 396);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(48, 13);
			this.label22.TabIndex = 24;
			this.label22.Text = "Capacity";
			// 
			// StudentMajorCB
			// 
			this.StudentMajorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.StudentMajorCB.FormattingEnabled = true;
			this.StudentMajorCB.Location = new System.Drawing.Point(30, 269);
			this.StudentMajorCB.Name = "StudentMajorCB";
			this.StudentMajorCB.Size = new System.Drawing.Size(121, 21);
			this.StudentMajorCB.TabIndex = 25;
			this.StudentMajorCB.SelectedIndexChanged += new System.EventHandler(this.StudentMajorCB_SelectedIndexChanged);
			// 
			// StudentAcadYearCB
			// 
			this.StudentAcadYearCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.StudentAcadYearCB.FormattingEnabled = true;
			this.StudentAcadYearCB.Location = new System.Drawing.Point(175, 269);
			this.StudentAcadYearCB.Name = "StudentAcadYearCB";
			this.StudentAcadYearCB.Size = new System.Drawing.Size(121, 21);
			this.StudentAcadYearCB.TabIndex = 26;
			this.StudentAcadYearCB.SelectedIndexChanged += new System.EventHandler(this.StudentAcadYearCB_SelectedIndexChanged);
			// 
			// DeptCodeCB
			// 
			this.DeptCodeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DeptCodeCB.FormattingEnabled = true;
			this.DeptCodeCB.Location = new System.Drawing.Point(30, 367);
			this.DeptCodeCB.Name = "DeptCodeCB";
			this.DeptCodeCB.Size = new System.Drawing.Size(121, 21);
			this.DeptCodeCB.TabIndex = 27;
			this.DeptCodeCB.SelectedIndexChanged += new System.EventHandler(this.DeptCodeCB_SelectedIndexChanged);
			// 
			// addCourse
			// 
			this.addCourse.Location = new System.Drawing.Point(30, 447);
			this.addCourse.Name = "addCourse";
			this.addCourse.Size = new System.Drawing.Size(108, 23);
			this.addCourse.TabIndex = 29;
			this.addCourse.Text = "Add Course";
			this.addCourse.UseVisualStyleBackColor = true;
			this.addCourse.Click += new System.EventHandler(this.addCourse_Click);
			// 
			// outputDisplay
			// 
			this.outputDisplay.Location = new System.Drawing.Point(30, 486);
			this.outputDisplay.Name = "outputDisplay";
			this.outputDisplay.ReadOnly = true;
			this.outputDisplay.Size = new System.Drawing.Size(824, 135);
			this.outputDisplay.TabIndex = 30;
			this.outputDisplay.Text = "";
			this.outputDisplay.TextChanged += new System.EventHandler(this.outputDisplay_TextChanged);
			// 
			// courseCapacity
			// 
			this.courseCapacity.Location = new System.Drawing.Point(175, 411);
			this.courseCapacity.Name = "courseCapacity";
			this.courseCapacity.Size = new System.Drawing.Size(120, 20);
			this.courseCapacity.TabIndex = 33;
			this.courseCapacity.ValueChanged += new System.EventHandler(this.courseCapacity_ValueChanged);
			// 
			// studDisplay
			// 
			this.studDisplay.FormattingEnabled = true;
			this.studDisplay.Location = new System.Drawing.Point(340, 65);
			this.studDisplay.Name = "studDisplay";
			this.studDisplay.Size = new System.Drawing.Size(241, 407);
			this.studDisplay.TabIndex = 34;
			this.studDisplay.SelectedIndexChanged += new System.EventHandler(this.studDisplay_SelectedIndexChanged);
			// 
			// courDisplay
			// 
			this.courDisplay.FormattingEnabled = true;
			this.courDisplay.Location = new System.Drawing.Point(613, 65);
			this.courDisplay.Name = "courDisplay";
			this.courDisplay.Size = new System.Drawing.Size(241, 407);
			this.courDisplay.TabIndex = 35;
			this.courDisplay.SelectedIndexChanged += new System.EventHandler(this.courDisplay_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(879, 633);
			this.Controls.Add(this.courDisplay);
			this.Controls.Add(this.studDisplay);
			this.Controls.Add(this.courseCapacity);
			this.Controls.Add(this.outputDisplay);
			this.Controls.Add(this.addCourse);
			this.Controls.Add(this.DeptCodeCB);
			this.Controls.Add(this.StudentAcadYearCB);
			this.Controls.Add(this.StudentMajorCB);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.sectionNumTB);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.courseNumTB);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.addStudent);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.studentZidTB);
			this.Controls.Add(this.studentNameTB);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.searchCourseByDept);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.searchStudentByZid);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.applySearchCriteria);
			this.Controls.Add(this.dropStudent);
			this.Controls.Add(this.enrollStudent);
			this.Controls.Add(this.printRoster);
			this.Controls.Add(this.label12);
			this.Name = "Form1";
			this.Text = " Student Enrollment Application";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.courseCapacity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button printCourseRoster;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox3;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button printRoster;
		private System.Windows.Forms.Button enrollStudent;
		private System.Windows.Forms.Button dropStudent;
		private System.Windows.Forms.Button applySearchCriteria;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox searchStudentByZid;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox searchCourseByDept;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox studentNameTB;
		private System.Windows.Forms.TextBox studentZidTB;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Button addStudent;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox courseNumTB;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox sectionNumTB;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.ComboBox StudentMajorCB;
		private System.Windows.Forms.ComboBox StudentAcadYearCB;
		private System.Windows.Forms.ComboBox DeptCodeCB;
		private System.Windows.Forms.Button addCourse;
		private System.Windows.Forms.RichTextBox outputDisplay;
		private System.Windows.Forms.NumericUpDown courseCapacity;
		private System.Windows.Forms.ListBox studDisplay;
		private System.Windows.Forms.ListBox courDisplay;
	}
}

