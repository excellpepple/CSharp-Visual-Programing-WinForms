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
    public partial class GamesPage : Form
    {
        private List<StoreItem> GamesDB = new List<StoreItem>(); // Database of games available in the store
        public frmStartUp home; // Reference to the main form
        public GamesPage()
        {
            InitializeComponent();
        }


        /**
         * handler for the Add Item button click event.
         * Adds the selected item from the list box to the shopping cart in the main form.
         */
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the list box
            if (lbxGamesList.SelectedIndex==-1)
            {
                // if item is not selected, show a message box and return
                MessageBox.Show("Please select an item to add to your cart.");
                return;
            }
            // Get the selected item from the list box
            StoreItem selectedItem = (StoreItem)lbxGamesList.SelectedItem;
            home.AddItemToCart(selectedItem); // Add the selected item to the shopping cart in the main form
        }

        /**
         * Closes the Form when the Exit button is clicked.
         */
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /**
         * Loads the Games database and populates the list box when the form loads.
         */
        private void GamesPage_Load_1(object sender, EventArgs e)
        {
            home = (frmStartUp)this.Owner; // Get reference to the main form

            // Populate the Games database with StoreItem objects
            GamesDB.Add(new StoreItem("Sega", 10.99, Properties.Resources.sega));
            GamesDB.Add(new StoreItem("SNES", 12.99, Properties.Resources.snes));
            GamesDB.Add(new StoreItem("NES", 14.99, Properties.Resources.nes));
            GamesDB.Add(new StoreItem("Atari", 19.99, Properties.Resources.atari));

            // Populate the list box with items from the Games database
            foreach (StoreItem item in GamesDB)
            {
                lbxGamesList.Items.Add(item);
            }
        }
    }
}
