using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class Check // счет за работу
    {
        public Requisites requisites { get; set; }
        public int NumberOfDocument { get; set; }
        public DateTime DateTime { get; set; }
        public OrderComponent Order { get; set; }
        public Good Good { get; set; }
        public Worker Worker { get; set; }

        public Check(Requisites requisites, int numberOfDocument, DateTime dateTime, OrderComponent order, Good good, Worker worker)
        {
            numberOfDocument = 0;
            numberOfDocument++;

            this.requisites = requisites;
            this.NumberOfDocument = numberOfDocument;
            this.DateTime = DateTime.Now;
            this.Order = order;
            this.Good = good;
            this.Worker = worker;
        }

        public void PrintCheck()
        {
            Console.WriteLine();
        }
    }
}
