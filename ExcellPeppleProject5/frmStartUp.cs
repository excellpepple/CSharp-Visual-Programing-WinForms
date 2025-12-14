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
    public struct StoreItem
    {
        /**
         * Represents an item in the store with a name, price, and picture.
         */
        public string Name;
        public double Price;
        public Image Picture;

        /**
         *  Creates a new StoreItem with the given name, price, and picture.
         * @param name The name of the item.
         * @param price The price of the item.
         * @param picture The picture of the item.
         */
        public StoreItem(string name, double price, Image picture)
        {
            Name = name;
            Price = price;
            Picture = picture;
        }

        /**
         * Creates a copy of another StoreItem.
         * @param other The StoreItem to copy.
         */
        public StoreItem(StoreItem other) {
            Name = other.Name;
            Price = other.Price;
            Picture = other.Picture;
        }

        /**
         * Converts the StoreItem to a string representation.
         * @return The name of the item.
         */
        public override string ToString()
        {
            return Name;
        }
    }

    public partial class frmStartUp : Form
    {
        public List<StoreItem> ShoppingCart = new List<StoreItem>(); // List to hold items in the shopping cart
        // Calculation variables for pricing
        private double Subtotal;
        private double Tax;
        private double Shipping;
        private double Total;
        private const double TAX_RATE = 0.7;
        
        public frmStartUp()
        {
            InitializeComponent();
        }

        private void frmStartUp_Load(object sender, EventArgs e)
        {
            ResetPage(true); // Initialize the page on load
        }

        /**
         * Adds a new item to the shopping cart and updates the page.
         * @param newItem The StoreItem to add to the cart.
         */
        public void AddItemToCart(StoreItem newItem){
            ShoppingCart.Add(new StoreItem(newItem)); // add item to cart
            UpdatePage(); // update the page to reflect changes
        }

        /**
         * Removes an item from the shopping cart at the specified index and updates the page.
         * @param Index The index of the item to remove.
         */
        public void RemoveItemFromCart(int Index) {
            ShoppingCart.RemoveAt(Index);
            UpdatePage();
        }

        /**
         * Updates the page to reflect the current state of the shopping cart and prices.
         */
        public void UpdatePage() {
            ResetPage(); // clear current visual data
            // repopulate the shopping cart list box
            foreach (StoreItem item in ShoppingCart) {
                lbxShoppingCart.Items.Add(item);
            }
            CalculateTotal(); // recalculate totals
            ShowCalculations(); // display the calculations results
            lblItemCount.Text = "" + ShoppingCart.Count; // update item count
        }

        /**
         * Resets the page's visual data and calculations.
         */
        private void ResetPage(bool fullReset = false) {
            //reset calculation variables
            Subtotal = 0;
            Tax = 0;
            Shipping = 0;
            Total = 0;
            lbxShoppingCart.SelectedItem = null;
            //clear all the visual data
            lbxShoppingCart.Items.Clear();
            lblSubTotal.Text = "$0";
            lblShipping.Text = "$0";
            lblTax.Text = "$0";
            lblTotal.Text = "$0";
            lblItemCount.Text = "0";
            // if full reset, uncheck shipping checkbox
            if (fullReset) { checkShouldShip.Checked = false; }
        }

        /**
         * Shows the calculated pricing values on the page.
         */
        private void ShowCalculations() {
            lblSubTotal.Text = "$" + Subtotal;
            lblShipping.Text = (checkShouldShip.Checked)?"$" + Shipping :"$0"; // if the shipping checkbox is checked, show shipping cost
            lblTax.Text = "$" + Tax;
            lblTotal.Text = "$" + Total;
        }

        /**
         * Calculates the subtotal, tax, shipping, and total for the shopping cart.
         */
        private void CalculateTotal() {
            // calculate subtotal
            foreach (StoreItem item in ShoppingCart) {
                Subtotal += item.Price;
            }
            // calculate shipping based on item count
            int ItemCount = ShoppingCart.Count;
            if (ItemCount <= 3)
                Shipping = 9;
            else if (ItemCount <= 6) 
                Shipping = 6;
            else 
                Shipping = 0;
            // calculate tax and total
            Tax = Subtotal * TAX_RATE;
            double TotalWithoutShipping = (Subtotal == 0)? 0 :Subtotal + TAX_RATE;
            Total = (checkShouldShip.Checked) ? TotalWithoutShipping + Shipping : TotalWithoutShipping;
        }

        /**
         * handles the click event for the About menu item, displaying the About page.
         */
        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutPage about = new AboutPage();
            about.Owner = this;
            about.ShowDialog();
        }

        /**
         * Handles the click event for the Music Products menu item, displaying the Music page.
         */
        private void mnuProductsMusic_Click(object sender, EventArgs e)
        {
            MusicPage music = new MusicPage();
            music.Owner = this;
            music.ShowDialog();
        }

        /**
         * handles the click event for the Movies Products menu item, displaying the Movies page.
         */
        private void mnuProductsMovies_Click(object sender, EventArgs e)
        {
            MoviesPage movie = new MoviesPage();
            movie.Owner = this;
            movie.ShowDialog();
        }

        /**
         * handles the click event for the Games Products menu item, displaying the Games page.
         */
        private void mnuProductsGames_Click(object sender, EventArgs e)
        {
            GamesPage games = new GamesPage();
            games.Owner = this;
            games.ShowDialog();
        }

        /**
         * Sets the preview image of the selected item in the shopping cart when the selection changes.
         */
        private void lbxShoppingCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check if an item is selected
            if (lbxShoppingCart.SelectedIndex == -1)
            {
                // no item selected, clear the picture box
                picSelectedItem.Image = null;
                return;
            }
            // set the picture box to the selected item's image
            picSelectedItem.Image = ((StoreItem)lbxShoppingCart.SelectedItem).Picture;
        }


        /**
         * Removes the selected item from the shopping cart when the Remove Selected button is clicked.
         */
        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            RemoveSelectedItem();
        }

        /**
         * Removes the selected item from the shopping cart.
         */
        public void RemoveSelectedItem()
        {
            // get the selected index
            int index = lbxShoppingCart.SelectedIndex;
            if (index != -1) // check if an item is selected
            {
                // remove the selected item from the cart
                RemoveItemFromCart(index);
                return;
            }
            // no item selected, show message
            MessageBox.Show("You have selected nothing");
        }

        /**
         * Handles the CheckedChanged event for the shipping checkbox, updating the page.
         */
        private void checkShouldShip_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePage();
        }

        /**
         * handles the click event for the Exit menu item, closing the application.
         */
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * handles the click event for the Clear All menu item, clearing the shopping cart and resetting the page.
         */
        private void mnuFileClearAll_Click(object sender, EventArgs e)
        {
            ShoppingCart.Clear(); // clear the shopping cart
            ResetPage(); // reset the page
        }

        /**
         * Handles the click event for the Remove Selected menu item, removing the selected item from the shopping cart.
         */
        private void mnuFileRemove_Click(object sender, EventArgs e)
        {
            RemoveSelectedItem();
        }
    }
}
