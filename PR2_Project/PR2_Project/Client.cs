using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_Project
{
    class Client
    {
        public string First_Name;
        public string Last_Name;
        public int Age;
        public string Phone_Number;

        public Client()
        {
            First_Name = " ";
            Last_Name = " ";
            Age = 1;
            Phone_Number = " ";
        }

        public Client(string First_Name, string Last_Name, int Age, string Phone_Number)
        {
            this.First_Name = First_Name;
            this.Last_Name = Last_Name;
            this.Age = Age;
            this.Phone_Number = Phone_Number;
        }
    }
}
