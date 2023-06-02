using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_Project
{
    class Order
    {
        public DateTime date;
        public Card card;
        public List<Product> products;
        public double Total_Price;

        public Order(DateTime date, Card card, List<Product> products, double Total_Price)
        {
            this.date = date;
            this.card = card;
            this.products = products;
            this.Total_Price = Total_Price;
        }
    }
}
