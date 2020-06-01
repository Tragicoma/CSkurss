using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day15_IOWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string fp;
        private void btnOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog folderDlg = new OpenFileDialog();
            folderDlg.InitialDirectory = @"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day15_IO";
           
            if (folderDlg.ShowDialog()==DialogResult.OK)
            {
                
                FileBox.Text = folderDlg.FileName;
                fp = folderDlg.FileName;
                TextBox.Clear();
                List<string> list = File.ReadAllLines(fp).ToList();

                foreach (string s in list)
                {
                    TextBox.Text += s + "\n";
                }
            }

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fp, TextBox.Text);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list = TextBox.Text.Split('\n').ToList();
            //  \n's at the end are erased  
            if (list[list.Count - 1].Length <  1 )
            { list.Remove(list[list.Count - 1]); }

            list.Reverse();
            TextBox.Clear();

            foreach (string s in list)
            {
                TextBox.Text += s + "\n";
            }
            
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog folderDlg = new SaveFileDialog();
            folderDlg.InitialDirectory = @"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day15_IO";
            folderDlg.ShowDialog();
            if(folderDlg.FileName!="")
            {
                File.WriteAllText(folderDlg.FileName, TextBox.Text);
            }

        }
    }
}
