using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    internal class Stock//склад
    {
        SortedDictionary<int, Good> goods = new SortedDictionary<int, Good>();

        public void AddGood(Good good)
        {
            int article = 0;
            foreach (var item in goods)
            {
                article++;
                goods.Add(article, good);
            }
        }

        public void PrintGoods()
        {
            foreach (var item in goods)
            {
                Console.WriteLine(item);
            }

        }

        public void FindGoodByName(string name)
        {

        }



        public void AcceptanceOfGoods()// прием товара
        {

        }

        public void DeliveryOfGoods() // выдача товара
        {

        }

        public void SortGoods() // сротировка по заданому критерию и вывод на экран
        {

        }
    }
}
