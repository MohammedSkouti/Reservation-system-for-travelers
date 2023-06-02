using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Client> clients = new List<Client>();
        List<Product> products = new List<Product>();
        List<Order> Orders = new List<Order>();

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = "Silver";
            bool IsChecked1 = radioButton1.Checked;
            bool IsChecked2 = radioButton2.Checked;
            if (IsChecked1)
                value = "Silver";
            if (IsChecked2)
                value = "Gold";

            last_name.Text = "UnKnown";
            age.Text = "12";
            phone_number.Text = "UnKnown";
            textBox5.Text = "UnKnown";
            textBox6.Text = "UnKnown";
            textBox7.Text = "50";
            Client card = new Card(new Client(first_name.Text, last_name.Text, Convert.ToInt32(age.Text), phone_number.Text), textBox5.Text, textBox6.Text, Convert.ToDouble(textBox7.Text), value);
            clients.Add(card);


            Clients_List.Items.Clear();
            foreach (Client C in clients)
            {
                Card c = (Card)C;
                if(C is Client)
                    Clients_List.Items.Add(C.First_Name + " " + c.Card_Number);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*int year1 = Convert.ToInt32(this.year1.Text);
            int month1 = Convert.ToInt32(this.month1.Text);
            int day1 = Convert.ToInt32(this.day1.Text);
            //DateTime dateTime1 = new DateTime(year1, month1, day1);

            int year2 = Convert.ToInt32(this.year2.Text);
            int month2 = Convert.ToInt32(this.day2.Text);
            int day2 = Convert.ToInt32(this.month2.Text);
            //DateTime dateTime2 = new DateTime(year2, month2, day2);

            int amount = Convert.ToInt32(avilable_quantity.Text);
            double price = Convert.ToDouble(product_price.Text);*/

            int year1 = 2013; int year2 = 2016;
            int month1 = 10; int month2 = 10;
            int day1 = 10; int day2 = 10;
            int amount = 1000;
            double price = 550;
            DateTime dateTime1 = new DateTime(year1, month1, day1);
            DateTime dateTime2 = new DateTime(year2, month2, day2);

            Product product = new Product(product_name.Text, dateTime1, dateTime2, amount, price);
            products.Add(product);


            Product_List.Items.Clear();
            foreach (Product P in products)
            {
                    Product_List.Items.Add(P.Name);
            }

        }

        private void Add_Employee_Click(object sender, EventArgs e)
        {
            int Age = Convert.ToInt32(age.Text);
            Client employee = new Employee(new Client(first_name.Text, last_name.Text, Age, phone_number.Text), UserName.Text, passowrd.Text);
            clients.Add(employee);
            Employees_List.Items.Clear();
            foreach (Client E in clients)
            {
                if (E is Employee)
                    Employees_List.Items.Add(E.First_Name + " " + E.Last_Name);
            }
        }

        private void Add_Supplier_Click(object sender, EventArgs e)
        {
            int Age = Convert.ToInt32(age.Text);
            Client supplier = new Suppliers(new Client(first_name.Text, last_name.Text, Age, phone_number.Text), contact_name.Text, email.Text);
            clients.Add(supplier);
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Product_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Product_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            textBox17.Text = products[Product_List.SelectedIndex].Price.ToString();
            textBox18.Text = products[Product_List.SelectedIndex].Avilable_Quantity.ToString();
        }
        List<Product> order = new List<Product>();
        private void button4_Click(object sender, EventArgs e)
        {
            Product p = products[Product_List.SelectedIndex];
            p.Avilable_Quantity -= Convert.ToInt32(wanted_quantity.Text);
            order.Add(p);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Card cards = new Card();
            bool check = false;
            foreach(Client C in clients)
            {
                Card c = (Card)C;
                if (C is Card && c.Card_Number == Convert.ToInt32(Card_Number.Text))
                {
                    check = true;
                    cards = c;
                    break;
                }
            }
            if(!check)
            {
                label15.Text = "NOT VILD";
                return;
            }

            double total = 0;
            foreach (Product p in order)
            {
                total += p.Price;
            }

            int year = Convert.ToInt32(order_year.Text);
            int month = Convert.ToInt32(order_month.Text);
            int day = Convert.ToInt32(order_day.Text);

            Order orders = new Order(new DateTime(year, month, day), cards, order,total);
            Orders.Add(orders);
            Order_List.Items.Clear();
            foreach(Order p in Orders)
            {
                Order_List.Items.Add(p.card.Card_Number + " " + p.Total_Price);
            }

            order.Clear();
        }

        private void Order_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
