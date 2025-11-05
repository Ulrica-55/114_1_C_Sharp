using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kms;
            double liters;
            double fuelEconomy;

            if(double.TryParse(milesTextBox.Text, out kms)) 
                
            {
                if (double.TryParse(gallonsTextBox.Text, out liters))
                {
                    // Calculate fuel economy in miles per gallon.
                    fuelEconomy = kms /liters;
                    // Display the fuel economy rounded to two decimal places.
                    mpgLabel.Text = fuelEconomy.ToString("n2") + " miles per gallon";
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for liters.");
                    gallonsTextBox.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for kilometers.");
                milesTextBox.Focus();
                return;
            }
                }

        private void milesPromptLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
