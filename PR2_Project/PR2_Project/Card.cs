using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_Project
{
    class Card:Client
    {
        private static int counter = 0;
        public int Card_Number;
        public string Start_Date;
        public string End_Date;
        public double Amount;
        public string MemberShip;
        public double Cost;

        public Card()
            :base()
        {
        }

        public Card(Client client, string Start_Date, string End_Date, double Amount, string MemberShip)
            :base(client.First_Name, client.Last_Name, client.Age, client.Phone_Number)
        {
            Card_Number = ++counter;
            this.Start_Date = Start_Date;
            this.End_Date = End_Date;
            this.Amount = Amount;
            this.MemberShip = MemberShip;
            if (MemberShip == "Silver")
                Cost = 2500;
            else if (MemberShip == "Gold")
                Cost = 5000;
                
        }
        
    }
}
