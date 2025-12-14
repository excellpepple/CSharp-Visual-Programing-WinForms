using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExcellPeppleProject6
{
    public partial class DataEditPage : Form
    {
        private string imagePath;
        StartUpPage parent;
        private string source = "";
        public DataEditPage()
        {
            InitializeComponent();
        }

        private void DataEditPage_Load(object sender, EventArgs e)
        {
            parent = (StartUpPage)this.Owner;
            comboFileFormat.Items.AddRange(Enum.GetNames<StartUpPage.FileFormat>()); // Populate combo box with enum names

        }

        /**
         * Saves the new movie to the database and copies the selected image to the Images folder.
         */
        private void btnSave_Click(object sender, EventArgs e)
        {
            var tempTitle = txtTitle.Text;
            var tempYear = txtYear.Text;
            var tempRuntime = txtRuntime.Text;
            // ge ratings
            int tempRatings = 0;
            if (radioOption1.Checked)
                tempRatings = 1;
            else if (radioOption2.Checked)
                tempRatings = 2;
            else if (radioOption3.Checked)
                tempRatings = 3;
            else if (radioOption4.Checked)
                tempRatings = 4;
            // get selected genres
            string tempGenre = "";
            if (checkAction.Checked)
                tempGenre += "Action,";
            if (checkComedy.Checked)
                tempGenre += "Comedy,";
            if (checkDrama.Checked)
                tempGenre += "Drama,";
            if (checkKids.Checked)
                tempGenre += "Kids,";
            if (checkSciFi.Checked)
                tempGenre += "Sci-Fi,";
            if (checkTV.Checked)
                tempGenre += "TV,";
            // Remove trailing comma
            if (tempGenre.EndsWith(","))
                tempGenre.Remove(tempGenre.Length - 1);
            var Genres = StartUpPage.ParseGenres(tempGenre); // Parse genres into a list
            // get file format
            StartUpPage.FileFormat tempFormat = Enum.Parse<StartUpPage.FileFormat>(comboFileFormat.SelectedItem.ToString());

            try
            {
                // Find project folder by walking up until a .csproj is found (robust for dev/debug runs)
                var projectFolder = FindProjectFolder(AppContext.BaseDirectory);
                // Images subfolder in the project
                var imagesDir = Path.Combine(projectFolder, "Output", "Images");
                Directory.CreateDirectory(imagesDir);

                // Preserve extension, use a GUID to avoid collisions. basically guaranteed unique identifier.
                var ext = Path.GetExtension(source);
                var destFileName = $"{Guid.NewGuid()}{ext}";
                var destPath = Path.Combine(imagesDir, destFileName);
                // Copy the file to the Images folder
                File.Copy(source, destPath, overwrite: false);
                imagePath = destPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Failed to copy image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Create new movie object
            var newMovie = StartUpPage.MovieFactory.CreateMovie(
                tempTitle,
                int.Parse(tempYear),
                imagePath,
                int.Parse(tempRuntime),
                tempRatings,
                Genres,
                tempFormat
            );
            // Add to database
            parent.MoviesDb.Add(newMovie);
            parent.SaveDb();
            MessageBox.Show("Added Movie to Data Base");
            clearForm(); // Clear form for next entry
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        /**
         * Clear all form fields
         */
        private void clearForm()
        {
            txtTitle.Text = "";
            txtYear.Text = "";
            txtRuntime.Text = "";
            radioOption1.Checked = false;
            radioOption2.Checked = false;
            radioOption3.Checked = false;
            radioOption4.Checked = false;
            checkAction.Checked = false;
            checkComedy.Checked = false;
            checkDrama.Checked = false;
            checkKids.Checked = false;
            checkSciFi.Checked = false;
            checkTV.Checked = false;
            comboFileFormat.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Walk up from the given start path until a folder containing a .csproj is found.
        // Returns the start path if none found.
        private static string FindProjectFolder(string startPath)
        {
            var dir = new DirectoryInfo(startPath);
            while (dir != null)
            {
                if (dir.GetFiles("*.csproj").Any())
                    return dir.FullName;
                dir = dir.Parent;
            }
            return startPath;
        }

        /**
         * Image selection button click event
         */
        private void btnImageSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select Movie Image";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            source = openFileDialog1.FileName;
            var fs = File.OpenRead(source);
            picPreview.Image = Image.FromStream(fs);
           
        }
    }
}
