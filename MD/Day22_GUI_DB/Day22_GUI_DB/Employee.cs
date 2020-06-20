using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_GUI_DB
{
    class Employee
    {
        private int Id;
        private string Name;
        private string Surname;
        private int DId;
        private int JobId;
        private double Salary;
        private double Min;
        private double Max;

        public Employee(int id, string name, string surname, int dId, int jobId, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.DId = dId;
            this.JobId = jobId; ;
            this.Salary = salary;
        }

        public int GetID()
        {
            return Id;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetSurname()
        {
            return Surname;
        }
        public int GetDepartment()
        {
            return DId;
        }
        public int GetJob()
        {
            return JobId;
        }
        public double GetSalary()
        {
            return Salary ;
        }

        public void SetMin(double min)
        {
            this.Min = min;
        }
        public void SetMax(double max)
        {
            this.Max = max;
        }

    }
}
