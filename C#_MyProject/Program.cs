namespace C__MyProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataBaseCars dbCars = new DataBaseCars();
            DataBaseOrders dbOrders = new DataBaseOrders();
            DataBaseEmployees dbEmployees = new DataBaseEmployees();

            List<Car> cars = new List<Car>();
            List<Order> orders = new List<Order>();

            Car car = new Car("Ford", "2154FD", 1999, "21589KO");
            cars.Add(car);

            car = new Car("Audi", "210VB", 2005, "368894AH");
            cars.Add(car);

            dbCars.SaveAllData(cars);
            //dbCars.LoadAllData();
            Console.WriteLine(dbCars.FindCarInFile("21589KO"));

            //dbCars.SortCars();


            //Order order = new Order("Мотор стучит");
            //orders.Add(order);
            //order.PrintOrder();

            //dbOrders.SaveAllData(orders);
            //dbOrders.LoadAllData();
            //dbOrders.FindOrderInFile("Мотор стучит");
            //dbOrders.SortOrders();


            //List <Worker> employees = new List<Worker>();
            //Worker worker = new Worker("Виктор", "Иванович", "Глущенко", new DateTime(1990,10,06),
            //new DateTime(2023,01,21), new DateTime(2024,10,10), "Автослесарь", 8950.50);

            // worker.ToString();
            //employees.Add(worker);
            ///dbEmployees.SaveAllData(employees);
            //dbEmployees.LoadAllData();
            //dbEmployees.FindWorkerInFile("Глущенко");
            //dbEmployees.SortEmployees();

            /*
            Good goods = new Goods();
            Good good = new Good("Автохимия", "Стеклоочеститель", 5, 235.56);
        
            //good.PrintGood(good);

            Good good1 = new Good("Автомасла", "Масло", 15, 790.00);

            good.PrintGood(good1); 
            */
        }
    }
}
