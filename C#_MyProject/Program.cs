using System;
using System.Reflection;

namespace C__MyProject
{
    public class Program
    {
        public delegate void DelegateChoice();
        static void Main(string[] args)
        {
            DelegateChoice choice = CreateCar;
            choice += CreateOrder;

            int a;
            Console.WriteLine("Enter choice:");
            a = Convert.ToInt32 (Console.ReadLine());

            ((DelegateChoice)choice.GetInvocationList()[a])();

            



            DataBaseCars dbCars = new DataBaseCars();
            DataBaseOrders dbOrders = new DataBaseOrders();
            DataBaseEmployees dbEmployees = new DataBaseEmployees();
            DataBaseStock dbStock = new DataBaseStock();

            List<Car> cars = new List<Car>();
            List<Order> orders = new List<Order>();
            SortedDictionary<int, Details> goods = new SortedDictionary<int, Details>();

            Car car = new Car("Ford", "2154FD", 1999, "21589KO");
            cars.Add(car);

            car = new Car("Audi", "210VB", 2005, "368894AH");
            cars.Add(car);

            //dbCars.SaveAllData(cars);
            //dbCars.LoadAllData();
            //Console.WriteLine(dbCars.FindCarInFile("21589KO"));

            //dbCars.SortCars();

            //string licensePlate;
            //Console.WriteLine("Enter license plate!");
            //licensePlate = Console.ReadLine();
            //Car c = dbCars.FindCarInFile(licensePlate);
            //Order order = new Order("Мотор стучит", c);
            

            //orders.Add(order);
            //order.PrintOrder();

            //dbOrders.SaveAllData(orders);// не проходит сериализация
            //dbOrders.LoadAllData();
            //dbOrders.FindOrderInFile("Мотор стучит");
            //dbOrders.SortOrders();

            // IGoodsAbstractFactory n = new NippartsFactory();
            // Bearings b = n.GetBearings();
            //b.PrintBearings();
            // goods.Add(1, b);

            // IGoodsAbstractFactory s = new SWAGFactory();
            // Bearings bearings = s.GetBearings();
            //bearings.PrintBearings();
            // goods.Add(2, bearings);

            //IGoodsAbstractFactory f = new FebestFactory();
            //ShockAbsorbers s1 = f.GetShockAbsorbers();
            //s1.PrintShockAbsorbers();
            //goods.Add(3, s1);

            /*foreach (var item in goods)
            {
                Console.WriteLine(item);
            }*/
            //dbStock.SaveAllData(goods);//не добавляется
            //dbStock.LoadAllData();





            //List <Worker> employees = new List<Worker>();
            //Worker worker = new Worker("Виктор", "Иванович", "Глущенко", new DateTime(1990,10,06),
            //new DateTime(2023,01,21), new DateTime(2024,10,10), "Автослесарь", 8950.50);

            // worker.ToString();
            //employees.Add(worker);
            ///dbEmployees.SaveAllData(employees);
            //dbEmployees.LoadAllData();
            //dbEmployees.FindWorkerInFile("Глущенко");
            //dbEmployees.SortEmployees();


        }
        public static void CreateCar()
        {
            string brand; string model; int year; string licensePlate;
            DataBaseCars dbCars = new DataBaseCars();
            List<Car> cars = new List<Car>();

            Console.WriteLine("Введите марку автомобиля: ");
            brand = Convert.ToString (Console.ReadLine());
            Console.WriteLine("Введите марку автомобиля: ");
            model = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите марку автомобиля: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите марку автомобиля: ");
            licensePlate = Convert.ToString(Console.ReadLine());

            Car car = new Car(brand, model, year, licensePlate);
            cars.Add (car);
            dbCars.SaveAllData(cars);
        }

        public static void CreateOrder()
        {
            string description;
            string licensePlate;
            DataBaseCars dbCars = new DataBaseCars();
            DataBaseOrders dbOrders = new DataBaseOrders();
            List<Order> orders = new List<Order>();

            Console.WriteLine("Введите номерной знак автомобиля для поиска: ");
            licensePlate = Console.ReadLine();
            Car c = dbCars.FindCarInFile(licensePlate);
            if (c != null)
            {
                Console.WriteLine("Введите описание работ: ");
                description = Console.ReadLine();
                Order order = new Order(description, c);

                orders.Add(order);
                dbOrders.SaveAllData(orders);
            }
            else
            {
                CreateCar();
            }
        }
    }
}
