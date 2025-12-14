using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GPA_Calculator
{

    public partial class GPAForm : Form
    {
        public StreamWriter OutputStream; // Output stream for writing to the movie database file
        public GPAForm()
        {
            InitializeComponent();
            btnEditGrades.Enabled = false; // Disable edit button initially
            UpdateSummary(); // Update the GPA summary display
        }

        /*
         * Updates the GPA summary display with the current semester information.
         */
        private void UpdateSummary()
        {
            // Update semester title, GPA, and total credit hours
            lblTitle.Text = $"Semester: {Program.semesterDB.Name} ({Program.semesterDB.Year})";
            double gpa = 0.0;
            int totalCreditHours = 0;
            gpa = Program.semesterDB.CalculateGPA();
            //Sum credit hours using LINQ
            totalCreditHours = Program.semesterDB.Courses.Count > 0 ? Program.semesterDB.Courses.Sum(c => c.Value.Credits) : 0;
            // Format GPA to two decimal places
            lblGPA.Text = $"GPA: {gpa:F2}";
            // Display total credit hours
            lblCreditHours.Text = $"Total Credit Hours: {totalCreditHours}";
            
            // Update the course list view
            listViewCourses.Items.Clear();
            foreach (var (id, course) in Program.semesterDB.Courses)
            {
                // Create a new list view item for each course
                ListViewItem item = new ListViewItem(id.ToString());
                // Add course details as sub-items
                item.SubItems.Add(course.Name);
                item.SubItems.Add(course.Credits.ToString());
                item.SubItems.Add(course.letterGrade.ToString());
                // Add the item to the list view
                listViewCourses.Items.Add(item);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the GPA form and return to the main form
            MainForm homepage = new MainForm();
            Program.Appctx.RegisterForm(homepage);
            this.Close();

        }

        private void btnEditGrades_Click(object sender, EventArgs e)
        {
            // Ensure an item is selected
            if (listViewCourses.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select an Item");
                return;
            }
            // Get the selected course ID
            ListViewItem selectedItem = listViewCourses.SelectedItems[0];
            // Parse the course ID from the selected item
            Guid courseId = Guid.Parse(selectedItem.SubItems[0].Text);
            // Retrieve the course from the semester database
            if (Program.semesterDB.Courses.TryGetValue(courseId, out Course selectedCourse)) 
            {
                // Open the ClassCreationForm for editing the selected course
                ClassCreationForm courseForm = new ClassCreationForm(selectedCourse);
                courseForm.Owner = this;
                courseForm.ShowDialog();
                UpdateSummary();
                return;
            }
            MessageBox.Show("Course not found.");


        }

        private void btnSaveSemester_Click(object sender, EventArgs e)
        {
            // Writing semester data to a file
            // Configure and display the SaveFileDialog
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //REQUIRED: writing to a file with exception handling
            {
                Program.DBPath = saveFileDialog1.FileName; // Set the database path to the selected file
                try //REQUIRED: Exception Handling
                {
                    OutputStream = new StreamWriter(Program.DBPath); // Create a StreamWriter for the file
                    OutputStream.Write(Program.semesterDB.ToString()); // Write the semester data to the file
                    MessageBox.Show("Semester data saved");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                    Console.WriteLine(exception);
                    throw;
                }
                finally
                {
                    // Ensure the output stream is closed
                    OutputStream.Close();
                    OutputStream = null;
                }
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            // Create a new course and open the ClassCreationForm for adding a new course
            Course newCourse = new Course();
            ClassCreationForm courseForm = new ClassCreationForm(newCourse);
            courseForm.Owner = this;
            courseForm.ShowDialog();
            UpdateSummary();
        }

        private void listViewCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Changes the enabled state of the edit button based on selection
            btnEditGrades.Enabled = listViewCourses.SelectedItems.Count != 0; //REQUIRED: Enable/disable edit button based on selection
        }
    }
}
