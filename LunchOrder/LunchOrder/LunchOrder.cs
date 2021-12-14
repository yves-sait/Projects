

/*
* CPRG 200 Lab Assignment 1
* Author: 
* Date: December 2022
* C# Application that accepts lunch order from user.
* Calculates the order subtotal and total with tax 5% added.
* 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class LunchOrder : Form
    {



        // Define constants

        // Declare main menu const price
        const decimal HAMBURGER_PRICE = 6.95m;
        const decimal PIZZA_PRICE = 5.95m;
        const decimal SALAD_PRICE = 4.95m;

        // Declare add-on const price
        const decimal ADD_ON_HAMBURGER = 0.75m;
        const decimal ADD_ON_PIZZA = 0.50m;
        const decimal ADD_ON_SALAD = 0.25m;

        // Declare tax-rate
        const decimal TAX_RATE = .05m;



        //Hamburger Add On variables ** Default data on the form
        const string HAM_ADD_ON_1 = "Lettuce, tomato and onions";
        const string HAM_ADD_ON_2 = "Ketchup. mustard and mayo";
        const string HAM_ADD_ON_3 = "French Fries";

        // Pizza Add on variables.
        const string PIZZA_ADD_ON_1 = "Pepperoni";
        const string PIZZA_ADD_ON_2 = "Sausage";
        const string PIZZA_ADD_ON_3 = "Olives";

        // Salad Add on variables.
        const string SALAD_ADD_ON_1 = "Croutons";
        const string SALAD_ADD_ON_2 = "Bacon Bits";
        const string SALAD_ADD_ON_3 = "Bread Sticks";




        public LunchOrder()
        {

            InitializeComponent();

            // Call Method to update main menu radio buttons on form launch.Update the text accordingly.
            SetMainMenu();

            // Call Method to update add-on checkboxes on form launch. Replace the to hamburger addon text accordingly as default values.
            SetHamAddOn();

        }

        /*
         * 
         * START - FrontEnd Form Code
         * Prices labels  and add-on selection will be dynamically populated.
         * 
         */

        // Set Main Menu radio button Text on form launch  ** default selected is Hamburger
        private void SetMainMenu()
        {
            rdbHam.Text = rdbHam.Text + " - " + HAMBURGER_PRICE.ToString("C");   // Concat the placeholder text + Hamburger price.
            rdbPizza.Text = rdbPizza.Text + " - " + PIZZA_PRICE.ToString("C"); // Concat the placeholder text + Pizza price.
            rdbSalad.Text = rdbSalad.Text + " - " + SALAD_PRICE.ToString("C"); // Concat the placeholder text + Salad price.

        }

        // Display AddOn checkboxes text on form launch. ** default is Hamburger Addons
        private void SetHamAddOn()
        {
            grpbAddOn.Text = $"Add-on items ({ADD_ON_HAMBURGER:C}/each)"; // set the groupbox text with Hamburger add on price.
            chkbAdd1.Text = HAM_ADD_ON_1; // set the text of the  first checkbox for Hamburger addon
            chkbAdd2.Text = HAM_ADD_ON_2; // set the text of the  second checkbox for Hamburger addon
            chkbAdd3.Text = HAM_ADD_ON_3; // set the text of the  third checkbox for Hamburger addon
            picMenu.Image = Image.FromFile(@"..\..\..\images\ham.jpg"); // set Hamburger image 
        }

        // Set AddOn Options for Pizza
        private void SetPizzaAddOn()
        {
            grpbAddOn.Text = $"Add-on items ({ADD_ON_PIZZA:C}/each)"; // set the groupbox text with Pizza add on price.
            chkbAdd1.Text = PIZZA_ADD_ON_1; ; // set the text of the  first checkbox for Pizza addon
            chkbAdd2.Text = PIZZA_ADD_ON_2;   // set the text of the  second checkbox for Pizza addon
            chkbAdd3.Text = PIZZA_ADD_ON_3;   // set the text of the  third checkbox for Pizza addon
            picMenu.Image = Image.FromFile(@"..\..\..\images\pizza.png"); // set Pizza image 
        }

        // Set AddOn Options for Salad
        private void SetSaladAddOn()
        {
            grpbAddOn.Text = $"Add-on items ({ADD_ON_SALAD:C}/each)"; // set the groupbox text with Salad add on price.
            chkbAdd1.Text = SALAD_ADD_ON_1; // set the text of the  first checkbox for Salad addon
            chkbAdd2.Text = SALAD_ADD_ON_2; // set the text of the  second checkbox for Salad addon
            chkbAdd3.Text = SALAD_ADD_ON_3; // set the text of the  third checkbox for Salad addon
            picMenu.Image = Image.FromFile(@"..\..\..\images\salad.jpg"); // set Salad image 
        }


        //Uncheck any selected add-on. Revert to its default(None Selected)
        private void ClearAddOnCheck()
        {
            chkbAdd1.Checked = false;
            chkbAdd2.Checked = false;
            chkbAdd3.Checked = false;
        }


        //Method to listen any changes on the event Check on the 3 radiobutton on the main menu

        private void rdbMainMenu_CheckedChanged(object sender, EventArgs e) // All 3 radio buttons are mapped to this checkchanged event handler
        {
            RadioButton rdbMainMenu = sender as RadioButton; // assign the sender object to variable of type RadioButton.

            ClearAddOnCheck(); // Changes in checked radionbutton will clear all check on Add-on checkboxes.

            if (rdbMainMenu.Checked) // Only process checked == true. Since checkedchanged can be checked = true and checked = false. Ignore checked = false.
            {

                if (rdbMainMenu.Name == "rdbHam") // if the sender is the Hamburger radiobutton
                {
                    SetHamAddOn(); // set and display the Hamburger addon checkboxes

                }
                else if (rdbMainMenu.Name == "rdbPizza") // if the sender is the Pizza radiobutton
                {
                    SetPizzaAddOn(); // set and display the Pizza addon checkboxes

                }
                else if (rdbMainMenu.Name == "rdbSalad") // if the sender is the Salad radiobutton
                {
                    SetSaladAddOn();  // set and display the Salad addon checkboxes

                }
            }


        }


        /*
         * 
         * END - FrontEnd Form Code
         * 
         * START - Calculation Code
         * 
         */

        // method to count number of addon
        private int GetAddOnCount()
        {
            int addOnCount = 0; // declare and initialize the count variable

            if (chkbAdd1.Checked) // if checkbox1 is checked
            {
                addOnCount++; // Add 1 to the current count
            }

            if (chkbAdd2.Checked)  // if checkbox2 is checked
            {
                addOnCount++; // Add 1 to the current count
            }

            if (chkbAdd3.Checked) // if checkbox3 is checked
            {
                addOnCount++; // Add 1 to the current count
            }

            return addOnCount; //return the total count to the calling code
        }

      
        /// <summary>
        /// Calculate the order fee.Will out params the order total and order tax
        /// </summary>
        /// <param name="OrderSubTotal"></param>
        /// <param name="OrderTotal"></param>
        /// <param name="OrderTax"></param>
        private void GetOrderFee(decimal OrderSubTotal, out decimal OrderTotal, out decimal OrderTax)
        {

            OrderTax = TAX_RATE * OrderSubTotal; // Calculate the order tax
            OrderTotal = OrderTax + OrderSubTotal; // calculate the total fee.


        }

        // Confirm the selected choices of lunch order
        // BtnOrder has been set as Accept button
        private void BtnOrder_Click(object sender, EventArgs e)
        {
            // declare and initialize the order total variables.
            decimal OrderTotal = 0m;
            decimal OrderTax = 0m;
            decimal OrderSubTotal = 0m;

     

            if (rdbHam.Checked) // if Hamburger menu is selected
            {

                // Call the method that check the number of addon on the selected main menu
                //Calculate the order subtotal with the main menu price and the addon total price.
                OrderSubTotal = HAMBURGER_PRICE + (ADD_ON_HAMBURGER * GetAddOnCount());

                // Call the method that calculate the order fee values.Pass the computed Order subtotal and 2 out params.
                GetOrderFee(OrderSubTotal, out OrderTotal, out OrderTax); 

            } else if (rdbPizza.Checked) // if Pizza menu is selected
            {
                // Call the method that check the number of addon on the selected main menu
                //Calculate the order subtotal with the main menu price and the addon total price.
                OrderSubTotal = PIZZA_PRICE + (ADD_ON_PIZZA * GetAddOnCount());

                // Call the method that calculate the order fee values.Pass the computed Order subtotal and 2 out params.
                GetOrderFee(OrderSubTotal, out OrderTotal, out OrderTax);

            } else if (rdbSalad.Checked) // if Salad menu is selected
            {
                // Call the method that check the number of addon on the selected main menu
                //Calculate the order subtotal with the main menu price and the addon total price.
                OrderSubTotal = SALAD_PRICE + (ADD_ON_SALAD * GetAddOnCount());

                // Call the method that calculate the order fee values.Pass the computed Order subtotal and 2 out params.
                GetOrderFee(OrderSubTotal, out OrderTotal, out OrderTax);
            }


            // display the result to the respective textboxes
            txtSubTotal.Text = OrderSubTotal.ToString("C");
            txtTax.Text = OrderTax.ToString("C");
            txtOrderTotal.Text = OrderTotal.ToString("C");


            // disable the mainmenu and addon choices
            // this is to avoid selection  after the order total values are already computed
            // User will need to click on reset to select new order
            rdbHam.Enabled = false;
            rdbPizza.Enabled = false;
            rdbSalad.Enabled = false;
            chkbAdd1.Enabled = false;
            chkbAdd2.Enabled = false;
            chkbAdd3.Enabled = false;

        }

        /*
         * 
         * END - Calculation Code
         * 
         */


        //Method to clear the populated values on the order total group
        private void ClearOrderTotalValues()
        {
            txtOrderTotal.Clear();
            txtTax.Clear();
            txtSubTotal.Clear();
        }


        // Clear results. Back to initial values.
        // BtnReset has been set as cancelled button
        private void BtnReset_Click(object sender, EventArgs e)
        {
            rdbHam.Checked = true; //set Hamburger as default selected Main Menu
            ClearAddOnCheck(); // Clear all add-on checkboxes.

            //Clear all calculation results
            ClearOrderTotalValues();

            // re-enable back the choices for new order
            rdbHam.Enabled = true;
            rdbPizza.Enabled = true;
            rdbSalad.Enabled = true;
            chkbAdd1.Enabled = true;
            chkbAdd2.Enabled = true;
            chkbAdd3.Enabled = true;
        }


        // Close the application
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





    }
}
