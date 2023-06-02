using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_Project
{
    class Employee:Client
    {
        public string user_name;
        public string Password;

        public Employee(Client client, string user_name, string Password)
            :base(client.First_Name, client.Last_Name, client.Age, client.Phone_Number)
        {
            this.user_name = user_name;
            this.Password = Password;
        }
    }
}
