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
        ListView oldList = new ListView();
    
        private void btnClick_Click(object sender, EventArgs e)
        {
            bool print = true;
            

            if(textBox.Text.Length<1)
            {
                print = false;
            }

            foreach(ListViewItem i in list.Items)
            {
                if(i.Text==textBox.Text)
                {
                    print = false;
                    RedText.Text = "This item is already in the list!";
                }
            }

            if(print&&!selected)
            {
                CopyList();
                list.Items.Add(textBox.Text);
                RedText.Text = "";
                textBox.Text = "";

            }
            else if(print&&selected)
            {
                CopyList();
                list.SelectedItems[0].Text = textBox.Text;
                RedText.Text = "";
                textBox.Text = "";
                selected = false;
            }
            
        }

        private void list_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Text = list.SelectedItems[0].Text;
            selected = true;
        }

        private void list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CopyList();
            list.Items.Remove(list.SelectedItems[0]);
            selected = false;
        }
        //Replaces listview with last copy - UNDO
        private void btnUndo_Click(object sender, EventArgs e)
        {
            
            list.Items.Clear();
            foreach (ListViewItem item in oldList.Items)
            {
                list.Items.Add((ListViewItem)item.Clone());
            }
            RedText.Text = "";
        }

        //Copy list for 1x undo purpose
        public void CopyList()
        {
            oldList.Items.Clear();
            foreach(ListViewItem item in list.Items)
            {
                oldList.Items.Add((ListViewItem)item.Clone());
            }

        }
        //Delete multiple
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list.SelectedItems)
            {
                item.Remove();
            }
        }
    }
}
