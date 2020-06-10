using System;
using System.Collections.Generic;
using System.Text;

namespace Day18_REST
{
    class DataStatus
    {
        public String Status;
        public List<Student> Data;

        public DataStatus(string status,List<Student> list)
        {
            this.Status = status;
            this.Data = list;
        }
    }
}
