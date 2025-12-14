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
    public partial class MusicPage : Form
    {
        List<StoreItem> MusicDB = new List<StoreItem>(); // Database of music items available in the store

        /**
         * Loads the Music database and sets up the radio buttons with images when the form is initialized.
         */
        public MusicPage()
        {
            InitializeComponent();
            // Populate the Music database with StoreItem objects
            MusicDB.Add(new StoreItem("GNR", 9.99, Properties.Resources.gnr));
            MusicDB.Add(new StoreItem("Jovi", 4.99, Properties.Resources.jovi));
            MusicDB.Add(new StoreItem("Motley", .99, Properties.Resources.motley));
            MusicDB.Add(new StoreItem("Poison", 2.99, Properties.Resources.poison));

            // Set the background images of the radio buttons to the corresponding music item pictures
            radioGNR.BackgroundImage = MusicDB[0].Picture;
            radioJovi.BackgroundImage = MusicDB[1].Picture;
            radioMotley.BackgroundImage = MusicDB[2].Picture;
            radioPoison.BackgroundImage = MusicDB[3].Picture;
        }

        /**
         * Checks which radio button is selected and retrieves the corresponding StoreItem.
         * @param selectedItem The variable to store the selected StoreItem if one is selected.
         * @return true if an item is selected, false otherwise.
         */
        private bool GetSelectedItem(out StoreItem selectedItem)
        {
            // Determine which radio button is selected and set the selectedItem accordingly
            if (radioGNR.Checked)
                selectedItem = MusicDB[0];
            else if (radioJovi.Checked)
                selectedItem = MusicDB[1];
            else if (radioMotley.Checked)
                selectedItem = MusicDB[2];
            else if (radioPoison.Checked)
                selectedItem = MusicDB[3];
            else
            {
                MessageBox.Show("Please select an item to be added");
                selectedItem = default(StoreItem);
                return false;
            }
            return true;
        }

        /**
         * Handler for the Add Item button click event.
         * Adds the selected item from the radio buttons to the shopping cart in the main form.
         */
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Get the selected item from the radio buttons
            StoreItem selectedItem; 
            if (GetSelectedItem(out selectedItem))
            {
                frmStartUp home = (frmStartUp)this.Owner; // Get reference to the main form
                if (home != null)
                {
                    home.AddItemToCart(selectedItem); // add the selected item to the shopping cart in the main form
                }
                else
                {
                    MessageBox.Show("Home form not set."); // Error handling if home is not set
                }
            }
        }

        /**
         * Closes the Form when the Exit button is clicked.
         */
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
    }
}
