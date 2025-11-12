using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal INTEREST_RATE = 0.005m; // Monthly interest rate

            decimal startingBalance; // To hold the starting balance
            int months;              // To hold the number of months
            int count = 1;
            
            if(decimal.TryParse(startingBalTextBox.Text, out startingBalance) )
            {
               if(int.TryParse(monthsTextBox.Text, out months) && months > 0)
               {
                    while (count <= months)
                    {
                        startingBalance *= (1 + INTEREST_RATE);

                        // Display the details in the ListBox.
                        detailListBox.Items.Add("第" + count + "個月的結餘:" + startingBalance.ToString("C"));
                        // Increment the counter.
                        count++;
                    }

                    // Display the ending balance.
                    endingBalanceLabel.Text = startingBalance.ToString("C");
                }
                else
               {
                   // Display an error message.
                   MessageBox.Show("Please enter a valid numeric value for months.",
                                   "Input Error");
                }
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Please enter valid numeric values for starting balance and months.",
                                "Input Error");
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes, the endingBalanceLabel control,
            // and the ListBox.
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // Reset the focus.
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
