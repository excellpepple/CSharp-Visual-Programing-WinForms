namespace GPA_Calculator
{
    public partial class MainForm : Form
    {
        StreamReader InputStream;
        public MainForm()
        {
            InitializeComponent();

        }

        private void btnStartSemester_Click(object sender, EventArgs e)
        {
            // Start a new semester and open the semester creation form
            SemesterCreationForm newSemester = new SemesterCreationForm();
            Program.Appctx.RegisterForm(newSemester);
            this.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btnLoadSemester_Click(object sender, EventArgs e)
        {
            //REQUIRED: Reading from a file and loading the semester data
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Load the selected semester file
                Program.DBPath = openFileDialog1.FileName;
                if (!System.IO.File.Exists(Program.DBPath)) //check if file exists
                {
                    MessageBox.Show("File does not exist: Please Select a valid file");
                    return;
                }
                // Clear existing semester data
                Program.semesterDB = null;
                InputStream = new StreamReader(Program.DBPath); //open file for reading
                Semester loadedSemester = new Semester(); //create new semester object
                // Read data from file
                while (!InputStream.EndOfStream)
                {
                    // read semester data
                    var line = InputStream.ReadLine().Split(','); //expected format: SemesterName,SemesterYear,CourseCount
                    var semesterName = line[0];
                    var semesterYear = int.Parse(line[1]);
                    int COURSE_COUNT = int.Parse(line[2]);
                    loadedSemester.Name = semesterName;
                    loadedSemester.Year = semesterYear;
                    // read course data
                    for (int i = 0; i < COURSE_COUNT; i++)
                    {
                        var courseLine = InputStream.ReadLine().Split(','); //expected format: CourseName,CourseCredits,CourseGrade
                        var courseName = courseLine[0];
                        var courseCredits = int.Parse(courseLine[1]);
                        var courseGrade = (Grade)Enum.Parse(typeof(Grade), courseLine[2]);
                        // create and add course to semester
                        Course loadedCourse = new Course(courseName, courseCredits, courseGrade);
                        loadedSemester.Courses.Add(loadedCourse.Id, loadedCourse);
                    }
                }
                // Set the loaded semester as the current semester
                Program.semesterDB = loadedSemester;
                InputStream.Close(); //close the file stream
                InputStream = null; //clear the stream reader
                // Open the semester creation form with loaded data
                SemesterCreationForm newSemester = new SemesterCreationForm(loadedSemester);
                Program.Appctx.RegisterForm(newSemester);
                this.Close();
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the About form
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();

        }
    }
}
