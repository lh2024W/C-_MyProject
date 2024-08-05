using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class Good
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public string CountryManufacturer { get; set; }
        public string Fabricator { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public DateTime DateOfReceiving { get; set; }
        public DateTime DateOfIssue { get; set; }


        public Good() { }

        public Good(string category, string name, string countryManufacturer, string fabricator,
            int count, double price, DateTime dateTime, DateTime date)
        {
            this.Category = category;
            this.Name = name;
            this.CountryManufacturer = countryManufacturer;
            this.Fabricator = fabricator;
            this.Count = count;
            this.Price = price;
            this.DateOfReceiving = dateTime;
            this.DateOfIssue = date;
        }

        public override string ToString()
        {
            return "Категория: " + Category + ' ' + "Наименование: " + Name + ' ' + "Страна производитель: " +
                CountryManufacturer + "Производитель: " + Fabricator + "Количество: " + Count + ' ' + "Цена: " +
                Price + "Итого: " + Count * Price;
        }

        public void PrintGood(Good good)
        {
            Console.WriteLine("Товар: ");
            Console.WriteLine("Категория: " + Category);
            Console.WriteLine("Наименование: " + Name);
            Console.WriteLine("Страна производитель: " + CountryManufacturer);
            Console.WriteLine("Производитель: " + Fabricator);
            Console.WriteLine("Количество: " + Count);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Итого: " + Count * Price);
        }


    }
}
