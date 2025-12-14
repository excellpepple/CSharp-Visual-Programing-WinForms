using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public partial class SemesterCreationForm : Form
    {
        public Semester semester; // public semester object to hold semester data

        /*
         * Constructor for SemesterCreationForm
         * @param Semester inputSemester - optional parameter to load an existing semester
         * @note If inputSemester is null, a new semester will be created
         */
        public SemesterCreationForm(Semester inputSemester=null)
        {
            InitializeComponent();
            semester = inputSemester ?? new Semester(); // checks if semester is null, if so create a new one

            textName.Text = semester.Name;
            textYear.Text = semester.Year.ToString();
            UpdateCourses(); // Populate the course list
        }

        private void UpdateCourses()
        {
            listBoxCoursePreview.Items.Clear(); // Clear existing items
            if (semester.Courses.Count == 0) // Check if there are no courses
            {
                //REQUIRED: Hide edit and delete buttons if no courses exist
                btnDeleteCourse.Visible = false; 
                btnEditCourse.Visible = false;
            }
            else
            {
                // Show edit and delete buttons if courses exist
                btnDeleteCourse.Visible = true;
                btnEditCourse.Visible = true;
                // Populate the list box with courses
                foreach (var (id, course) in semester.Courses)
                {
                    listBoxCoursePreview.Items.Add(course);
                }
            }
        }


        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            ClassCreationForm courseForm; // reference to ClassCreationForm
            // Check if no course is selected for editing
            if (listBoxCoursePreview.SelectedIndex == -1)
            {
                // Create a new course and open the form
                Course newCourse = new Course();
                courseForm = new ClassCreationForm(newCourse);
                
            }
            else
            {
                // Edit the selected course
                Course selectedCourse = (Course)listBoxCoursePreview.SelectedItem;
                courseForm = new ClassCreationForm(selectedCourse);
            }
            courseForm.Owner = this;
            courseForm.ShowDialog();
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            // Check if a course is selected
            if (listBoxCoursePreview.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course to edit.");
                return;
            }
            // Open the ClassCreationForm with the selected course
            var selectedCourse = (Course)listBoxCoursePreview.SelectedItem; // Cast the selected item to Course
            ClassCreationForm courseForm = new ClassCreationForm(selectedCourse);
            courseForm.Owner = this;
            courseForm.ShowDialog();

        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            // Check if a course is selected
            if (listBoxCoursePreview.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }
            // Remove the selected course from the semester and update the list
            Course selectedCourse = (Course)listBoxCoursePreview.SelectedItem;
            semester.Courses.Remove(selectedCourse.Id);
            listBoxCoursePreview.Items.Remove(selectedCourse);
            UpdatePage(); // Refresh the course list
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate user input before saving
            if (!ValidateInput())
            {
                return;
            }
            // Save semester details
            semester.Name = textName.Text;
            semester.Year = int.Parse(textYear.Text);
            Program.semesterDB = semester;
            // Navigate to GPA summary form
            GPAForm summary = new GPAForm();
            Program.Appctx.RegisterForm(summary); // using application context to manage forms and navigate to a new form 
            this.Close();
        }

        /*
         * Validate user input for semester name and year
         * @return bool - true if input is valid, false otherwise
         */
        private bool ValidateInput()
        {
            // Validate semester name
            if (textName.Text.Length <= 2) //REQUIRED: Using If Statements to validate user input and Use of logical operators
            {
                MessageBox.Show("Please enter a valid semester name.");
                return false;
            }
            // Validate semester year
            if (!int.TryParse(textYear.Text, out int year) || year < 1900 || year > DateTime.Now.Year + 10) // year must be a valid integer within a reasonable range
            {
                MessageBox.Show("Please enter a valid year.");
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Navigate back to the main form
            MainForm homepage = new MainForm();
            Program.Appctx.RegisterForm(homepage);

            this.Close();
        }

        /*
         * Updates the course list display
         */
        public void UpdatePage()
        {
            // Clear existing items
            listBoxCoursePreview.Items.Clear();
            // Check if there are no courses and update button visibility accordingly
            if (semester.Courses.Count == 0)
            {
                btnDeleteCourse.Visible = false; //REQUIRED: Hide edit and delete buttons if no courses exist
                btnEditCourse.Visible = false;
            }
            else
            {
                // Show edit and delete buttons if courses exist
                btnDeleteCourse.Visible = true;
                btnEditCourse.Visible = true;
                // Populate the list box with courses
                foreach (var (id, course) in semester.Courses)
                {
                    listBoxCoursePreview.Items.Add(course);
                }
            }
        }
    }
}
