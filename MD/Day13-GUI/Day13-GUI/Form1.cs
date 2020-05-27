using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day13_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool valid = true;

            if (textBoxName.Text.Length < 1 && textBoxSurname.Text.Length < 1)
            {
                valid = false;
            }

            int course = 0;

            try
            {
                course = Convert.ToInt32(textBoxCourse.Text);
            }
            catch
            {
                valid = false;
            }
            
            if (course!=1 && course!=2 && course!=3)
            {
                valid = false;
            }

            if (valid)
            {
                labelOutput.Text = "Name: "+ textBoxName.Text+
                    "\nSurname: "+ textBoxSurname.Text+"\nCourse: "+ textBoxCourse.Text;
            }
            else
            {
                labelOutput.Text = "Wrong input!";
            }



        }

        

    }
}
