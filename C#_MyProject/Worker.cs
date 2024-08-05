using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class Worker
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public DateTime DateOfDismissal { get; set; }
        public string Post { get; set; }
        public double Salary { get; set; }

        public Worker() { }

        public Worker(string name, string secondName, string lastName, DateTime birthday,
            DateTime dateOfRegistration, DateTime dateOfDismissal, string post, double salary)
        {
            Name = name;
            SecondName = secondName;
            LastName = lastName;
            Birthday = birthday;
            DateOfRegistration = dateOfRegistration;
            DateOfDismissal = dateOfDismissal;
            Post = post;
            Salary = salary;
        }

        public override string ToString()
        {
            return "Имя: " + Name + ' ' + "Отчество: " + SecondName + ' ' + "Фамилия: " + LastName + ' ' +
                "Дата рождения: " + Birthday + ' ' + "Дата оформления на работу: " + DateOfRegistration + ' ' +
                "Дата увольнения с работы: " + DateOfDismissal + ' ' + "Должность: " + Post + ' ' +
                "Заработная плата: " + Salary + ' ' + "грн.";
        }

        public void PrintWorker()
        {
            Console.WriteLine("Сотрудник СТО: ");
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Отчество: " + SecondName);
            Console.WriteLine("Фамилия: " + LastName);
            Console.WriteLine("Дата рождения: " + Birthday);
            Console.WriteLine("Дата оформления на работу: " + DateOfRegistration);
            Console.WriteLine("Дата увольнения с работы: " + DateOfDismissal);
            Console.WriteLine("Должность: " + Post);
            Console.WriteLine("Заработная плата: " + Salary + "грн.");
        }

        public int CompareTo(object obj)
        {
            if (obj is Worker)
            {
                return LastName.CompareTo((obj as Worker).LastName);
            }
            throw new NotImplementedException();
        }
    }
}
