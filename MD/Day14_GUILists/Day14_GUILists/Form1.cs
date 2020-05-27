using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day14_GUILists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool selected = false;
        private void btnClick_Click(object sender, EventArgs e)
        {
            bool print = true;

            if(textBox.Text.Length<1)
            {
                print = false;
            }

            if(print&&!selected)
            {
                list.Items.Add(textBox.Text);
            }
            else if(selected)
            {
                list.SelectedItems[0].Text = textBox.Text;
            }

        }

        private void list_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text = list.SelectedItems[0].Text;
            selected = true;
        }

        private void list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            list.Items.Remove(list.SelectedItems[0]);
        }
    }
}
