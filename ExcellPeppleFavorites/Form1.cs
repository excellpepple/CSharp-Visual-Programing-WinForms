using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ExcellPeppleFavorites
{

    public partial class Form1 : Form
    {
        private string[,] page = { // I use this to save myself some keystrokes :)
            { "Warrant", "warrant.jpg"}, {" Skid", "skid.jpg"}, {"Poison", "poison.jpg"},
            {"Motley", "motley.jpg"}, {"Jovi", "jovi.jpg"}, {"GNR", "gnr.jpg"}
        };
        private string rootDir = Path.GetFullPath( //finds the root folder for this project 
            Path.Combine(Application.StartupPath, @"..\..\..\")
        );
        private int currentPage = 0; // my idea of pagination: it tracks what options to display
        public Form1()
        {
            InitializeComponent();
            UpdatePage();

        }
        private void UpdatePage() {
            /*
             * Updates the page by changing the source of the picture boxes and disables or enables the buttons
             **/
            Option1_Img.Image = Image.FromFile(Path.Combine(rootDir, page[currentPage, 1]));
            Option2_Img.Image = Image.FromFile(Path.Combine(rootDir, page[currentPage + 1, 1]));
            Option3_Img.Image = Image.FromFile(Path.Combine(rootDir, page[currentPage + 2, 1]));
            SelectionLbl.Text = "Not Selected";
            if (currentPage == 1)
            {
                NextBtn.Enabled = false;
                BackBtn.Enabled = true;
            }
            if (currentPage == 0)
            {
                NextBtn.Enabled = true;
                BackBtn.Enabled = false;
            }
        }

        private void Option1_Img_Click(object sender, EventArgs e)
        {
            SelectionLbl.Text = ""+page[currentPage, 0];
        }

        private void Option3_Img_Click(object sender, EventArgs e)
        {
            SelectionLbl.Text = "" + page[currentPage +2, 0];
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            currentPage++;
            UpdatePage();

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            currentPage--;
            UpdatePage();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Option2_Img_Click(object sender, EventArgs e)
        {
            SelectionLbl.Text = "" + page[currentPage + 1, 0];
        }

        
    }
}
