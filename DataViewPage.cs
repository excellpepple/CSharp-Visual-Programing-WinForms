using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExcellPeppleProject6
{
    public partial class DataViewPage : Form
    {
        StartUpPage parent;
        private int startIndex = 0;
        private int currentIndex = 0;
        private int endIndex = 0;
        public DataViewPage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Makes Previous button go to previous movie entry
         */
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentIndex--;
            UpdatePage();
        }

        /**
         * Makes Next button go to next movie entry
         */
        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            UpdatePage();
        }

        /**
         * Updates the page with the current movie entry information
         */
        private void UpdatePage()
        {
            // keeps track of page number
            lblPageNumber.Text = $"{currentIndex + 1} of {endIndex}";
            // gets current movie entry
            StartUpPage.Movies CurrentMovie = parent.MoviesDb.ElementAt(currentIndex);
            // updates preview image
            var fs = File.OpenRead(CurrentMovie.ImageName);
            picPreview.Image = Image.FromStream(fs);
            // updates all labels with current movie information
            lblTitle.Text = CurrentMovie.Title;
            lblDate.Text = CurrentMovie.ReleaseDate.ToString();
            lblRuntime.Text = $"{CurrentMovie.Runtime} minutes";
            lblRatings.Text = $"{CurrentMovie.Ratings}/4";
            lblGenre.Text = string.Join(", ", CurrentMovie.Genres);
            lblFormat.Text = CurrentMovie.FileFormat.ToString();
            // enables/disables buttons based on current index
            if (currentIndex == 0)
                btnPrevious.Enabled = false;
            else
                btnPrevious.Enabled = true;

            if (currentIndex == endIndex - 1)
            {
                btnNext.Enabled = false;
                MessageBox.Show("You have reached the end of the database");
            }
            else
                btnNext.Enabled = true;
        }

        private void DataViewPage_Load(object sender, EventArgs e)
        {
            parent = (StartUpPage)this.Owner; // gets reference to parent form
            startIndex = 1;
            endIndex = parent.MoviesDb.Count;
            currentIndex = 0;
            UpdatePage();
        }
    }
}
