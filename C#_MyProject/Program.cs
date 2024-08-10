using System;
using System.Reflection;

namespace C__MyProject
{
    public class Program
    {
        public delegate void DelegateChoice();
        static void Main(string[] args)
        {
            //1. не проходит сериализация ордеров
            //2. не проходит сериализация товаров

            //Доделать:
            //1. Доделать меню
            //2. Использовать паттерн Компоновщик для создания чека
            //3. Использовать паттерн Состояние для оплаты чека
            //4. Использовать паттерн Итератор для Склада (приход/расход)
        

            /* DelegateChoice choice = CreateCar;
             choice += CreateOrder;

             string[] menuItems = new string[] { "\t\t\tСоздать автомобиль", "\t\t\tСоздать заказ", "\t\t\tВыход" };

             /*string[] menuItems = new string[] { "\t\t\tСоздать автомобиль", "\t\t\tПосмотреть все автомобили в базе данных",
                 "\t\t\tНайти автомобиль по номерному знаку в базе данных", "\t\t\tОтсортировать автомобили по марке авто",
                 "\t\t\tСоздать заказ", "\t\t\tНайти заказ по номерному знаку автомобиля", "\t\t\tОтсортировать заказы по дате поступления",
                 "\t\t\tДобавить товар", "\t\t\tПоказать все товары в базе данных", "\t\t\tНайти товар по названию",
                 "\t\t\tНайти товар по названию производителя", "\t\t\tНайти товар по категории","\t\t\tНайти товар по дате получения",
                 "\t\t\tРаспечатать чек",
                 "\t\t\tВыход" };*/

            /*Console.Title = "БАЗА ДАННЫХ СТО";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\tДобрый день!");
            Console.WriteLine("Выберите, пожалуйста, с помощью стрелок на клавиатуре нужный пункт меню:");
            Console.WriteLine();

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            while (true)
            {
                DrawMenu(menuItems, row, col, index);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < menuItems.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        switch (index)
                        {
                            case 2:
                                Console.WriteLine("Выбран выход из программы!");
                                return;
                            default:
                                Console.WriteLine($"Выбран пункт: {menuItems[index]}");
                                ((DelegateChoice)choice.GetInvocationList()[index])();
                                break;
                        }
                        break;
                }
            }
        */

            /* DataBaseCars dbCars = new DataBaseCars();
             DataBaseOrders dbOrders = new DataBaseOrders();
             DataBaseEmployees dbEmployees = new DataBaseEmployees();
             DataBaseStock dbStock = new DataBaseStock();

             List<Car> cars = new List<Car>();
             List<OrderComponent> orders = new List<OrderComponent>();
             SortedDictionary<int, Details> goods = new SortedDictionary<int, Details>();

             Car car = new Car("Ford", "2154FD", 1999, "21589KO");
             cars.Add(car);

             car = new Car("Audi", "210VB", 2005, "368894AH");
             cars.Add(car);
            */
            //dbCars.SaveAllData(cars);
            //dbCars.LoadAllData();
            //Console.WriteLine(dbCars.FindCarInFile("21589KO"));

            //dbCars.SortCars();

            // string licensePlate;
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

            //IGoodsAbstractFactory n = new NippartsFactory();
            //Bearings b = n.GetBearings("Подшипники", "Задний мост", "14,61 мм", "14,73 мм", "39,88 мм", "50,29 мм", "17,46 мм", "29 мм");
            //b.PrintBearings();

            //goods.Add(1, b);
            //dbStock.SaveAllData(goods);//не добавляется
            //dbStock.LoadAllData();


            // IGoodsAbstractFactory s = new SWAGFactory();
            // Bearings bearings = s.GetBearings("Подшипники", "Задний мост", "14,61 мм", "14,73 мм", "39,88 мм", "50,29 мм", "17,46 мм", "29 мм");
            //bearings.PrintBearings();
            //Random random = new Random();
            //goods.Add(random.Next(0, 10000000), bearings);
            // goods.Add(2, bearings);
            //dbStock.SaveAllData(goods);//не добавляется
            //dbStock.LoadAllData();

            //IGoodsAbstractFactory f = new FebestFactory();
            //ShockAbsorbers s1 = f.GetShockAbsorbers("Амортизатор", "Задний", "Двухсторонний", "Газооливковый", 1, "1 год или 25000 км", "2 года или 70000км");
            //s1.PrintShockAbsorbers();
            //Random random = new Random();
            //goods.Add(random.Next(0, 10000000), s1);
            //goods.Add(3, s1);
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

        private static void DrawMenu(string[] items, int row, int col, int index)
        {
            Console.SetCursorPosition(col, row);
            for (int i = 0; i < items.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(items[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        public static void CreateCar()
        {
            string brand; string model; int year; string licensePlate;
            DataBaseCars dbCars = new DataBaseCars();
            List<Car> cars = new List<Car>();

            Console.WriteLine("Введите марку автомобиля: ");
            brand = Convert.ToString (Console.ReadLine());
            Console.WriteLine("Введите модель автомобиля: ");
            model = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите год выпуска: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номерной знак: ");
            licensePlate = Convert.ToString(Console.ReadLine());

            Car car = new Car(brand, model, year, licensePlate);
            cars.Add (car);
            dbCars.SaveAllData(cars);
            Console.Clear();
            Console.WriteLine("Автомобиль добавлен в базу данных!");
        }

        public static void CreateOrder()
        {
            string description;
            string licensePlate;
            string brand; string model; int year;
            
            List<Car> cars = new List<Car>();
            DataBaseCars dbCars = new DataBaseCars();
            DataBaseOrders dbOrders = new DataBaseOrders();
            List<OrderComponent> orders = new List<OrderComponent>();

            Console.WriteLine("Введите номерной знак автомобиля для поиска: ");
            licensePlate = Console.ReadLine();
            Car c = dbCars.FindCarInFile(licensePlate);
            if (c != null)
            {
                Console.WriteLine("Автомобиль найден: ");
                Console.WriteLine(c.ToString());
                Console.WriteLine("Введите описание работ: ");
                description = Console.ReadLine();
                OrderLeaf order = new OrderLeaf(description, c);

                orders.Add(order);
                dbOrders.SaveAllData(orders);
                Console.Clear();
                Console.WriteLine("Заказ создан!");
            }
            else
            {
                Console.WriteLine("Автомобиль не найден! ");
                Console.WriteLine("Нужно внести автомобиль в бызу данных!");
                
                Console.WriteLine("Введите марку автомобиля: ");
                brand = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите модель автомобиля: ");
                model = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите год выпуска: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите номерной знак: ");
                licensePlate = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите описание работ: ");
                description = Console.ReadLine();

                OrderComposite order = new OrderComposite(description, brand, model, year, licensePlate);
                orders.Add(order);
                dbOrders.SaveAllData(orders);

                Car car = new Car(brand, model, year, licensePlate);
                cars.Add(car);
                dbCars.SaveAllData(cars);

                Console.Clear();
                Console.WriteLine("Заказ создан!");
            }
        }
    }
}
