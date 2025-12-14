using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public partial class ClassCreationForm : Form
    {
        public Course course; // public course object to hold course data

        /*
         * Constructor for ClassCreationForm
         * @param Course Incourse - course object to load existing course data
         *
         */
        public ClassCreationForm(Course Incourse)
        {
            InitializeComponent();

            course = Incourse;
            // Load existing course data into form fields
            textName.Text = course.Name;
            textHours.Text = course.Credits.ToString();

            comboBxLetterGrade.DataSource = Enum.GetValues(typeof(Grade));
            comboBxLetterGrade.SelectedItem = course.letterGrade;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input and save course data
            if (validateInput())
            {
                course.Name = textName.Text;
                course.Credits = int.Parse(textHours.Text); //REQUIRED: Convert string to int
                course.letterGrade = (Grade)comboBxLetterGrade.SelectedItem;
                // Save course to appropriate location based on owner form
                if (Owner is SemesterCreationForm semesterForm) // if this form was opened by SemesterCreationForm we save to that semester
                {
                    semesterForm.semester.Courses[course.Id] = course;
                    semesterForm.UpdatePage();
                }
                else // otherwise we save to the global semester database
                {
                    Program.semesterDB.Courses[course.Id] = course;
                }
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*
        * Validate user input for course name and credit hours
        * @return bool - true if input is valid, false otherwise
        */
        private bool validateInput() //REQUIRED: Validate user input
        {
            // Validate course name
            if (textName.Text.Length <= 0)
            {
                MessageBox.Show("Please enter a course name.");
                return false;
            }
            // Validate credit hours
            if (!int.TryParse(textHours.Text, out int credits) || credits <= 0)
            {
                MessageBox.Show("Please enter a valid number of credit hours.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
