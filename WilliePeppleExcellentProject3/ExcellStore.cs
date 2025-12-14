using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WilliePeppleExcellentProject3
{
    public partial class ExcellStore : Form
    {
        // constant values for calculating total costs
        private const float BURGER_PRICE = 3.27f;
        private const float COKE_PRICES = 1.57f;
        private const float FRIES_PRICES = 0.94f;
        private const float TAX_RATE = 0.07f;

        // variables for tracking count of items, tax, tips, and totals
        private int burgerCount = 0;
        private int cokeCount = 0;
        private int friesCount = 0;
        private float subTotal = 0;
        private float Tax = 0;
        private float total = 0;
        private float tip = 0;


        public ExcellStore()
        {
            InitializeComponent();
            lblTipMessage.Visible = false; //make sure the page is basic with no tip message
        }

        private void btnAddTip_Click(object sender, EventArgs e)
        {
            // get the tip aount in string value
            string tipAmount = TxtBoxTip.Text;
            
            try
            {
                // try to convert the tip to a number and update the page
                tip = int.Parse(tipAmount);
                UpdatePage();
            }
            catch (Exception exp)
            {
                // if there is an error then display the warning.
                MessageBox.Show("The tip must be a whole number");
                Console.WriteLine(exp.Message);
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // reset the values of the form
            friesCount = 0;
            burgerCount = 0;
            cokeCount = 0;
            tip = 0;
            TxtBoxTip.Text = "";
            //update the page again
            UpdatePage();
        }

        private void picFries_Click(object sender, EventArgs e)
        {
            // increase the count of fries before updating the page
            friesCount++;
            UpdatePage();
        }

        private void picBurger_Click(object sender, EventArgs e)
        {
            // increase the count of burger count and update the page
            burgerCount++;
            UpdatePage();
        }

        private void picCoke_Click(object sender, EventArgs e)
        {
            // increase the count of coke orders and update the page
            cokeCount++;
            UpdatePage();
        }
        
        private void UpdatePage() {
            // check if the tip is more than 0 
            if (tip > 0)
            {
                // display the current amount of tip paid
                lblTipMessage.Text = String.Format("Total includes a {0:c}", tip);
                lblTipMessage.Visible = true;
            }
            else
            {
                // do nothing
                lblTipMessage.Visible = false;
            }

            // calculate the cost of subtotal, tax and total based on orders made
            subTotal = (BURGER_PRICE * burgerCount) + (COKE_PRICES * cokeCount) + (FRIES_PRICES * friesCount);
            Tax = subTotal * TAX_RATE;
            total = subTotal + Tax;

            // update the UI so users can see the value of their inputs for order count
            lblBurgerCount.Text = burgerCount.ToString();
            lblCokeCount.Text = cokeCount.ToString();
            lblFriesCount.Text = friesCount.ToString();
            // format the string to 2 decimal places
            lblSubTotal.Text = subTotal.ToString("c");
            lblTax.Text = Tax.ToString("c");
            lblTotal.Text = total.ToString("c");
        }
    }
}
