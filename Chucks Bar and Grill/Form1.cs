using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Chucks_Bar_and_Grill
{
    public partial class Form1 : Form
    {
        //constants
        const double BEER = 2.00;
        const double POP = 2.00;
        const double COFFEE = 2.00;
        const double TEA = 2.00;
        const double WINGS = 10.00;
        const double HAMBURGERS = 10.00;
        const double SANDWICH = 10.00;
        const double PASTA = 10.00;
        const double FRIES = 4.00;
        const double SALAD = 4.00;
        const double POTATO = 4.00;
        const double VEGGIES = 4.00;
        const double CHEESECAKE = 6.00;
        const double APPLECRISP = 6.00;
        const double ICECREAM = 6.00;
        const double BROWNIE = 6.00;
        const double Tax = 0.13;

        double beer = 0;
        double pop = 0;
        double coffee = 0;
        double tea = 0;
        double wings = 0;
        double hamburgers = 0;
        double sandwich = 0;
        double pasta = 0;
        double fries = 0;
        double salad = 0;
        double potato = 0;
        double veggies = 0;
        double cheesecake = 0;
        double applecrisp = 0;
        double icecream = 0;
        double brownie = 0;
        double tax;
        double total;
        double sub;
        double sub2;
        double sub3;
        double sub4;
        double totalamount;

        int correctEmployeeNumber = 6;

        //subtotalOutput.Text = sub.ToString("C");
        //tax.Text = tax.ToString("C");
        //totalOutput.Text = total.ToString("C");
            
        //        subtotalOutput3.Text = sub.ToString("C");
        //        subtotalOutput3.Text = sub.ToString("C");
        
        //totalamount = (subtotalOutput) + (subtotalOutput2) + (subtotalOutput3) + (subtotalOutput4) + (tax);

        public Form1()
        {
            InitializeComponent();
        }

        private void drinksButton_Click(object sender, EventArgs e)
        {
            //get Inputs
            try
            { 
                beer = Convert.ToDouble(beerInput.Text);
                pop = Convert.ToDouble(popTextBox.Text);
                coffee = Convert.ToDouble(coffeeTextBox.Text);
                tea = Convert.ToDouble(teaTextBox.Text);
                sub = (BEER * beer) + (POP * pop) + (COFFEE * coffee) + (TEA * tea);
                tax = Tax * sub;
                total = (tax + sub);

                //Output Subtotal

                subtotalOutput.Text = sub.ToString("C");
            }
            catch
            { }
        }

        private void mainsButton_Click(object sender, EventArgs e)
        {
            //get Inputs
            //try
            {

                wings = Convert.ToDouble(wingsTextBox.Text);
                hamburgers = Convert.ToDouble(hamburgersTextBox.Text);
                sandwich = Convert.ToDouble(sandwichTextBox.Text);
                pasta = Convert.ToDouble(pastaTextBox.Text);
                sub2 = (WINGS * wings) + (HAMBURGERS * hamburgers) + (SANDWICH * sandwich) + (PASTA * pasta);
                tax = Tax * sub2;
                total = (tax + sub2);

                subtotalOutput2.Text = sub2.ToString("C");
            }
            //catch
            { }
        }
        private void sidesButton_Click(object sender, EventArgs e)
        {
            //get Inputs
            try
            {

                fries = Convert.ToDouble(friesTextBox.Text);
                salad = Convert.ToDouble(saladTextBox.Text);
                potato = Convert.ToDouble(potatoTextBox.Text);
                veggies = Convert.ToDouble(veggiesTextBox.Text);
                sub3 = (FRIES * fries) + (SALAD * salad) + (POTATO * potato) + (VEGGIES * veggies);
                tax = Tax * sub3;
                total = (tax + sub3);

                subtotalOutput3.Text = sub3.ToString("C");
            }
            catch
            { }
        }

        private void desertButton_Click(object sender, EventArgs e)
        {
            //get Inputs
            try
            {
                cheesecake = Convert.ToDouble(cheesecakeTextBox.Text);
                applecrisp = Convert.ToDouble(applecrispTextBox.Text);
                icecream = Convert.ToDouble(icecreamTextBox.Text);
                brownie = Convert.ToDouble(brownieTextBox.Text);
                sub4 = (CHEESECAKE * cheesecake) + (APPLECRISP * applecrisp) + (ICECREAM * icecream) + (BROWNIE * brownie);
                tax = Tax * sub4;
                total = (tax + sub4);

                subtotalOutput4.Text = sub4.ToString("C");
            }
            catch
            {

            }
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(employeeTextbox.Text) == correctEmployeeNumber)
            {
                popTextBox.Enabled = true;
                popTextBox.Visible = true;
                coffeeTextBox.Enabled = true;
                coffeeTextBox.Visible = true;
                teaTextBox.Enabled = true;
                teaTextBox.Visible = true;
                beerlabel.Visible = true;
                beerInput.Enabled = true;
                beerInput.Visible = true;
                wingsTextBox.Enabled = true;
                wingsTextBox.Visible = true;
                hamburgersTextBox.Enabled = true;
                hamburgersTextBox.Visible = true;
                sandwichTextBox.Enabled = true;
                sandwichTextBox.Visible = true;
                pastaTextBox.Enabled = true;
                pastaTextBox.Visible = true;
                friesTextBox.Enabled = true;
                friesTextBox.Visible = true;
                saladTextBox.Enabled = true;
                saladTextBox.Visible = true;
                potatoTextBox.Enabled = true;
                potatoTextBox.Visible = true;
                veggiesTextBox.Enabled = true;
                veggiesTextBox.Visible = true;
                cheesecakeTextBox.Enabled = true;
                cheesecakeTextBox.Visible = true;
                icecreamTextBox.Enabled = true;
                icecreamTextBox.Visible = true;
                applecrispTextBox.Enabled = true;
                applecrispTextBox.Visible = true;
                brownieTextBox.Enabled = true;
                brownieTextBox.Visible = true;
                drinkLabel.Visible = true;
                popLabel.Visible = true;
                coffeeLabel.Visible = true;
                teaLabel.Visible = true;
                wingsLabel.Visible = true;
                HamburgerLabel.Visible = true;
                sandwichLabel.Visible = true;
                pastaLabel.Visible = true;
                friesLabel.Visible = true;
                saladLabel.Visible = true;
                potatoLabel.Visible = true;
                veggiesLabel.Visible = true;
                cheesecakeLabel.Visible = true;
                icecreamLabel.Visible = true;
                applecrispLabel.Visible = true;
                brownieLabel.Visible = true;
                drinksButton.Visible = true;
                drinksButton.Enabled = true;
                mainsButton.Visible = true;
                mainsButton.Enabled = true;
                sidesButton.Visible = true;
                sidesButton.Enabled = true;
                desertButton.Visible = true;
                desertButton.Enabled = true;
                subtotalLabel.Visible = true;
                subtotalOutput.Visible = true;
                label4.Visible = true;
                subtotalOutput2.Visible = true;
                label5.Visible = true;
                subtotalOutput3.Visible = true;
                label7.Visible = true;
                subtotalOutput4.Visible = true;
                totalAmount.Visible = true;
                totalAmount.Enabled = true;



            }
        }

        private void totalAmount_Click(object sender, EventArgs e)
        {
            totalAmountLabel.Text = ""+(sub) + (sub2) + (sub3) + (sub4);
        }
    }
}
