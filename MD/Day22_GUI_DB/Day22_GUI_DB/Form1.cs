using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day22_GUI_DB
{
    public partial class Form1 : Form
    {
        DBConnection DB;
        List<Employee> list = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
            DB = new DBConnection();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DB.GetEmployees(listView,list);
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {

            tbName.Text = list[listView.SelectedItems[0].Index].GetName();
            tbSurname.Text = list[listView.SelectedItems[0].Index].GetSurname();
            tbDepartmentId.Text = list[listView.SelectedItems[0].Index].GetDepartment().ToString();
            tbJobId.Text = list[listView.SelectedItems[0].Index].GetJob().ToString();
            tbSalary.Text = list[listView.SelectedItems[0].Index].GetSalary().ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string n = tbName.Text;
            string ln = tbSurname.Text;
            string jID = tbJobId.Text;
            string dID = tbDepartmentId.Text;
            string s = tbSalary.Text;
            DB.AddEmployee(n, ln, dID, jID, s,list);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DB.RemoveEmployee(list[listView.SelectedItems[0].Index].GetID());
            DB.GetEmployees(listView,list);
        }
    }
}
