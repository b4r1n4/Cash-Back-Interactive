using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Back_Interactive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Declarations
            const int TWENTY = 20, TEN = 10, FIVE = 5;
            int dollars, amount20, amount10, amount5, amount1, remainder20, remainder10;

            //Data Validation
            if (!int.TryParse(userInput.Text, out dollars))
            {
                tryAgain.Text = "";
                userInput.Text = "";
                output.Text = "";
                errorMessage.Text = "Please enter a valid numeric value...";
            }
            else
            {
                //Calculations
                tryAgain.Text = "";
                errorMessage.Text = "";
                amount20 = dollars / TWENTY;
                remainder20 = dollars % TWENTY;
                amount10 = remainder20 / TEN;
                remainder10 = remainder20 % TEN;
                amount5 = remainder10 / FIVE;
                amount1 = remainder10 % FIVE;

                //Result and final output
                output.Text = $"{dollars:C} is {amount20} twenties, {amount10} tens,\r\n{amount5} fives, and {amount1} ones.";
                tryAgain.Text = "Try Again?";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userInput.Text = "";
            errorMessage.Text = "";
            output.Text = "";
            tryAgain.Text = "";

        }
        private void userInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitButton_Click(this, new EventArgs());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tryAgain_Click(object sender, EventArgs e)
        {

        }

        private void errorMessage_Click(object sender, EventArgs e)
        {

        }

        private void output_Click(object sender, EventArgs e)
        {

        }

        private void userInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void greeting_Click(object sender, EventArgs e)
        {

        }
    }
}
