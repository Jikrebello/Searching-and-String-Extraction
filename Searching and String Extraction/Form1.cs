using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Searching_and_String_Extraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* 1. This problem involves inputting a name in the format firstname space lastname, such as
         * Wayne Gretzky, and redisplaying it in the format lastname space firstname, such as Gretzky Wayne*/
        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = Interaction.InputBox("Enter your full name", "", "");
            int whiteSpace = fullName.IndexOf(' ');
            string firstName;
            string lastName;

            if (whiteSpace == -1)
                MessageBox.Show(fullName + " is not divided by a ' '.");
            else
            {
                firstName = fullName.Substring(0, whiteSpace);
                lastName = fullName.Substring(whiteSpace + 1);
                MessageBox.Show("First name: " + firstName + Environment.NewLine + "Last name: " + lastName + Environment.NewLine +
                                "Last name: " + lastName + Environment.NewLine + "First name: " + firstName);
            }

        }

        /* 2. Modify the above program so that if your given:
         * Any phone number in the form: 905-767-7858
         * The program Displays: Area Code: 905
         * Phone Number: 767-7858*/
        private void button2_Click(object sender, EventArgs e)
        {
            string fullNumber = Interaction.InputBox("Enter your full name", "", "");
            int seperator = fullNumber.IndexOf('-');
            string areaCode;
            string phonenumber;

            if (seperator == -1)
                MessageBox.Show(fullNumber + " is not divided by a '-'.");
            else
            {
                areaCode = fullNumber.Substring(0, seperator);
                phonenumber = fullNumber.Substring(seperator + 1);
                MessageBox.Show("Area code: " + areaCode + Environment.NewLine + "Phone Number: " + phonenumber);
            }
        }

        /* 3. Modify the first program again so that if you input decimal numbers like 17.245 , 125.34, and 17.1 it will output:
         * a) The number of decimal places in the number
         * b) The integer part
         * c) The fractional part (decimal)*/
        private void button3_Click(object sender, EventArgs e)
        {
            string fullDecimal = Interaction.InputBox("Enter your full name", "", "");
            int seperator = fullDecimal.IndexOf('.');
            string wholeNumber;
            string fraction;

            if (seperator == -1)
                MessageBox.Show(fullDecimal + " is not divided by a '.'.");
            else
            {
                wholeNumber = fullDecimal.Substring(0, seperator);
                fraction = fullDecimal.Substring(seperator + 1);
                seperator = fraction.Length;
                MessageBox.Show("Whole number: " + wholeNumber + Environment.NewLine + "Fraction: " + fraction + Environment.NewLine + "Number of decimal places: " + seperator);
            }
        }
    }
}
