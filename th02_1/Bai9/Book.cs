using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Book
    {
        private string name;
        private int price, amount;
        private double sale, prices;

        public Book()
        {
            name = "";
            price = amount = 0;
            sale = prices = 0;
        }

        public Book(string name, int price, int amount, double sale, double prices)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
            this.sale = sale;
            this.prices = prices;
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
        public double Sale { get => sale; set => sale = value; }
        public double Prices { get => prices; set => prices = value; }
    }
}
