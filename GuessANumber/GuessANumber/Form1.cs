using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessANumber
{
    public partial class Form1 : Form
    {


        int randomNumberGenerated;
        
        
        //Using just "=" to assign variable like normal throws error:
        /*
         * "A field initializer cannot reference the non-static field, method, or property Form1.randomNumber."
         * Instead assign to variable using "=>" to make it into a property. 
         * Confirmed fixes error and allows randomNumberGenerated to work as expected.
         * 
         * */

        public Form1()
        {
            InitializeComponent();

            Random randomNumber = new Random();
            randomNumberGenerated = randomNumber.Next(1,6);

            label4.Text = Convert.ToString(randomNumberGenerated);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            radioButton6.Checked = true;
        
            radioButton6.Visible = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


                if (randomNumberGenerated == 1)
                {
                    label2.Text = "You Win!";
                    label1.Text = Convert.ToString(randomNumberGenerated);

                }
                else
                {
                    label2.Text = "Sorry - you lose.";
                    label1.Text = Convert.ToString(randomNumberGenerated);
             

                }
                foreach (Control item in this.Controls)
                {
                    item.Enabled = false;
    
            }
        }//End radio button

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                //int randomNumberGenerated = randomNumber.Next(1, 6);

                if (randomNumberGenerated == 2)
                {
                    label2.Text = "You Win!";
                    label1.Text = Convert.ToString(randomNumberGenerated);

                }
                else
                {
                    label2.Text = "Sorry - you lose.";
                    label1.Text = Convert.ToString(randomNumberGenerated);
                    

                }
                foreach (Control item in this.Controls)
                {
                    item.Enabled = false;
                }
            }
        }//End radio button

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                //int randomNumberGenerated = randomNumber.Next(1, 6);

                if (randomNumberGenerated == 3)
                {
                    label2.Text = "You Win!";
                    label1.Text = Convert.ToString(randomNumberGenerated);

                }
                else
                {
                    label2.Text = "Sorry - you lose.";
                    label1.Text = Convert.ToString(randomNumberGenerated);
                   

                }
                foreach (Control item in this.Controls)
                {
                    item.Enabled = false;
                }
            }
        }//End radio button

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                //int randomNumberGenerated = randomNumber.Next(1, 6);

                if (randomNumberGenerated == 4)
                {
                    label2.Text = "You Win!";
                    label1.Text = Convert.ToString(randomNumberGenerated);

                }
                else
                {
                    label2.Text = "Sorry - you lose.";
                    label1.Text = Convert.ToString(randomNumberGenerated);
                  

                }
                foreach (Control item in this.Controls)
                {
                    item.Enabled = false;
                }
            }

        }//End radio button

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                //int randomNumberGenerated = randomNumber.Next(1, 6);
                if (randomNumberGenerated == 5)
                {
                    label2.Text = "You Win!";
                    label1.Text = Convert.ToString(randomNumberGenerated);

                }
                else
                {
                    label2.Text = "Sorry - you lose.";
                    label1.Text = Convert.ToString(randomNumberGenerated);



                   

                }
                foreach (Control item in this.Controls)
                {
                    item.Enabled = false;
                }

            }

        }//End radio button

        private void label2_Click(object sender, EventArgs e)
        {
   
        }
        private void label2_MouseHover(object sender, EventArgs e)

        {

            if (randomNumberGenerated == 1)
            {

                label3.Text = "It's not 3";
            }
            else
            {
                int fake_number = Convert.ToInt32(label4.Text);
                int subtraction = fake_number - 1;
                label3.Text = "It's not " + Convert.ToString(subtraction);
            } 

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
