namespace GPA_Calculator
{
    partial class GPAForm
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
            listViewCourses = new ListView();
            ID = new ColumnHeader();
            Title = new ColumnHeader();
            CeditHours = new ColumnHeader();
            Grade = new ColumnHeader();
            lblCreditHours = new Label();
            lblGPA = new Label();
            lblTitle = new Label();
            btnExit = new Button();
            btnEditGrades = new Button();
            btnAddCourse = new Button();
            btnSaveSemester = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // listViewCourses
            // 
            listViewCourses.Columns.AddRange(new ColumnHeader[] { ID, Title, CeditHours, Grade });
            listViewCourses.Location = new Point(14, 129);
            listViewCourses.Margin = new Padding(3, 4, 3, 4);
            listViewCourses.Name = "listViewCourses";
            listViewCourses.Size = new Size(765, 331);
            listViewCourses.TabIndex = 0;
            listViewCourses.UseCompatibleStateImageBehavior = false;
            listViewCourses.View = View.Details;
            listViewCourses.SelectedIndexChanged += listViewCourses_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 150;
            // 
            // Title
            // 
            Title.Text = "Course Title";
            Title.Width = 300;
            // 
            // CeditHours
            // 
            CeditHours.Text = "Credit Hours";
            CeditHours.Width = 150;
            // 
            // Grade
            // 
            Grade.Text = "Grade";
            // 
            // lblCreditHours
            // 
            lblCreditHours.AutoSize = true;
            lblCreditHours.Location = new Point(530, 81);
            lblCreditHours.Name = "lblCreditHours";
            lblCreditHours.Size = new Size(132, 20);
            lblCreditHours.TabIndex = 1;
            lblCreditHours.Text = "Total Credit Hours:";
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Location = new Point(530, 29);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(108, 20);
            lblGPA.TabIndex = 2;
            lblGPA.Text = "Semester GPA: ";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F);
            lblTitle.Location = new Point(32, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(274, 41);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Semester Summary";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(693, 522);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 31);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEditGrades
            // 
            btnEditGrades.Location = new Point(12, 468);
            btnEditGrades.Margin = new Padding(3, 4, 3, 4);
            btnEditGrades.Name = "btnEditGrades";
            btnEditGrades.Size = new Size(104, 48);
            btnEditGrades.TabIndex = 5;
            btnEditGrades.Text = "Edit Grades";
            btnEditGrades.UseVisualStyleBackColor = true;
            btnEditGrades.Click += btnEditGrades_Click;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(14, 523);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(94, 29);
            btnAddCourse.TabIndex = 6;
            btnAddCourse.Text = "Add Course";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // btnSaveSemester
            // 
            btnSaveSemester.Location = new Point(608, 484);
            btnSaveSemester.Name = "btnSaveSemester";
            btnSaveSemester.Size = new Size(171, 32);
            btnSaveSemester.TabIndex = 7;
            btnSaveSemester.Text = "Save Semester";
            btnSaveSemester.UseVisualStyleBackColor = true;
            btnSaveSemester.Click += btnSaveSemester_Click;
            // 
            // GPAForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 568);
            Controls.Add(btnSaveSemester);
            Controls.Add(btnAddCourse);
            Controls.Add(btnEditGrades);
            Controls.Add(btnExit);
            Controls.Add(lblTitle);
            Controls.Add(lblGPA);
            Controls.Add(lblCreditHours);
            Controls.Add(listViewCourses);
            Name = "GPAForm";
            Text = "GPAForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewCourses;
        private ColumnHeader ID;
        private ColumnHeader Title;
        private ColumnHeader CeditHours;
        private ColumnHeader Grade;
        private Label lblCreditHours;
        private Label lblGPA;
        private Label lblTitle;
        private Button btnExit;
        private Button btnEditGrades;
        private Button btnAddCourse;
        private Button btnSaveSemester;
        private SaveFileDialog saveFileDialog1;
    }
}