using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_Project
{
    class Product
    {
        public string Name;
        public DateTime Production_Date;
        public DateTime Expriation_Date;
        private int _Avilable_Quantity;
        public int Avilable_Quantity
        {
            set
            {
                if (value > 0)
                    _Avilable_Quantity = value;
                else
                    _Avilable_Quantity = 0;
            }
            get
            {
                return _Avilable_Quantity;
            }
        }
        public double Price;
        List<Suppliers> Supplier = new List<Suppliers>();
        public Product(string Name, DateTime Production_Date, DateTime Expriation_Date, int Avilable_Quantity, double Price)
        {
            this.Name = Name;
            this.Production_Date = Production_Date;
            this.Expriation_Date = Expriation_Date;
            this.Avilable_Quantity = Avilable_Quantity;
            this.Price = Price;
        }

    }
}
