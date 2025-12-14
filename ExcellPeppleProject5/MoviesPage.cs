using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcellPeppleProject5
{
    public partial class MoviesPage : Form
    {
        private List<StoreItem> MoviesDB = new List<StoreItem>();
        public frmStartUp home;

        public MoviesPage()
        {
            InitializeComponent();

            MoviesDB.Add(new StoreItem("Indiana Jones", 22.99, Properties.Resources.rotla));
            MoviesDB.Add(new StoreItem("The Breakfast Club", 20.99, Properties.Resources.bc));
            MoviesDB.Add(new StoreItem("Back to the Future",29.99, Properties.Resources.bttf));
            MoviesDB.Add(new StoreItem("Cant Buy Me Love", 24.99, Properties.Resources.cbml));

            picRotla.Image = MoviesDB[0].Picture;
            picBC.Image = MoviesDB[1].Picture;
            picBttf.Image = MoviesDB[2].Picture;
            picCbml.Image = MoviesDB[3].Picture;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void picRotla_Click(object sender, EventArgs e)
        {
            home.AddItemToCart(MoviesDB[0]);
        }

        private void picCbml_Click(object sender, EventArgs e)
        {
            home.AddItemToCart(MoviesDB[3]);
        }

        private void picBC_Click(object sender, EventArgs e)
        {
            home.AddItemToCart(MoviesDB[1]);
        }

        private void picBttf_Click(object sender, EventArgs e)
        {
            home.AddItemToCart(MoviesDB[2]);
        }

        private void MoviesPage_Load(object sender, EventArgs e)
        {
            home = (frmStartUp) this.Owner;
        }
    }
}
