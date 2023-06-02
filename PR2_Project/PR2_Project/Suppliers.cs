using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_Project
{
    class Suppliers:Client
    {
        public string Contact_Name;
        public string Email;

        public Suppliers(Client client, string Contact_Name, string Email)
            :base(client.First_Name, client.Last_Name, client.Age, client.Phone_Number)
        {
            this.Contact_Name = Contact_Name;
            this.Email = Email;
        }
    }
}
