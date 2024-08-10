using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Xml.Linq;

namespace C__MyProject
{
    public class Program
    {
        public delegate void DelegateChoice();
        public delegate void DelegateChoice1();
        public delegate void DelegateChoice2();
        static void Main(string[] args)
        {
            //1. не проходит сериализация ордеров
            //2. не проходит сериализация товаров
            //3. не работает выход из меню - встроенного делегата (Добавить товар)
            //4. меню добавление товара запуталась(((
            //5. как сделать поиск товара по имени в SortedDictionary?

            //Доделать:
            //1. Доделать меню
            //2. Использовать паттерн Компоновщик для создания чека
            //3. Использовать паттерн Состояние для оплаты чека
            //4. Использовать паттерн Итератор для Склада (приход/расход)


            DelegateChoice choice = CreateCar;
            choice += PrintCars;
            choice += FindCarByLisencePlate;
            choice += SortCarsByBrand;
            choice += CreateOrder;
            choice += FindOrderByLisencePlate;
            choice += SortOrdersByDate;
            choice += CreateGood;
            choice += PrintGoods;
            choice += FindGoodByName;
            choice += FindGoodByNameManufacturer;
            choice += FindGoodByCategory;
            choice += FindGoodByDate;
            choice += PrintCheck;
            choice += PayCheck;
            choice += Exit;

            string[] menuItems = new string[] { "\t\t\tСоздать автомобиль", "\t\t\tПосмотреть все автомобили в базе данных",
                 "\t\t\tНайти автомобиль по номерному знаку в базе данных", "\t\t\tОтсортировать автомобили в базе данных по марке авто",
                 "\t\t\tСоздать заказ", "\t\t\tНайти заказ по номерному знаку автомобиля", 
                 "\t\t\tОтсортировать заказы по дате поступления", "\t\t\tДобавить товар", "\t\t\tПоказать все товары в базе данных", "\t\t\tНайти товар по названию",
                 "\t\t\tНайти товар по названию производителя", "\t\t\tНайти товар по категории","\t\t\tНайти товар по дате получения",
                 "\t\t\tРаспечатать чек", "\t\t\tОплатить чек", "\t\t\tВыход" };

            Console.Title = "БАЗА ДАННЫХ СТО";
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
                            case 16:
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

        public static void PrintCars()
        {
            DataBaseCars dbCars = new DataBaseCars();
            dbCars.LoadAllData();
        }

        public static void FindCarByLisencePlate()
        {             
            DataBaseCars dbCars = new DataBaseCars();
            Console.WriteLine("Введите номерной знак автомобиля для поиска: ");
            string licensePlate = Console.ReadLine();
            Console.WriteLine(dbCars.FindCarInFile(licensePlate));
        }

        public static void SortCarsByBrand()
        {
            DataBaseCars dbCars = new DataBaseCars();
            dbCars.SortCars();
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

        public static void FindOrderByLisencePlate()
        {
            DataBaseOrders dbOrders = new DataBaseOrders();
            Console.WriteLine("Введите номерной знак автомобиля для поиска: ");
            string licensePlate = Console.ReadLine();
            dbOrders.FindOrderInFile(licensePlate);
        }

        public static void SortOrdersByDate()
        {
            DataBaseOrders dbOrders = new DataBaseOrders();
            dbOrders.SortOrders();
        }


        public static void CreateGood()
        {
            DelegateChoice1 choice = Nipparts;
            choice += SWAG;
            choice += Febest;
            choice += SKF;
            choice += Exit;

            string[] menuItems = new string[] { "\t\t\tNipparts", "\t\t\tSWAG", "\t\t\tFebest", "\t\t\tSKF", "\t\t\tВыход" };
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
                            case 4:
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
        }

        public static void Nipparts()
        {
            DelegateChoice2 choice = Bearings;
            choice += ShockAbsorbers;
            choice += ExhaustSystem;
            choice += Filters;
            choice += AirСonditioningСompressors;
            choice += Starters;
            choice += Springs;
            choice += Exit;

            string[] menuItems = new string[] { "\t\t\tПодшипники", "\t\t\tАмортизаторы", "\t\t\tВыхлопная система",
                "\t\t\tФильтры", "\t\t\tКомпрессоры кондиционера", "\t\t\tСтартеры", "\t\t\tРессоры","\t\t\tВыход" };
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
                            case 8:
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
        }

        public static void SWAG()
        {
            DelegateChoice2 choice = Bearings;
            choice += ShockAbsorbers;
            choice += ExhaustSystem;
            choice += Filters;
            choice += AirСonditioningСompressors;
            choice += Starters;
            choice += Springs;
            choice += Exit;

            string[] menuItems = new string[] { "\t\t\tПодшипники", "\t\t\tАмортизаторы", "\t\t\tВыхлопная система",
                "\t\t\tФильтры", "\t\t\tКомпрессоры кондиционера", "\t\t\tСтартеры", "\t\t\tРессоры","\t\t\tВыход" };
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
                            case 8:
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
        }

        public static void Febest() 
        {
            DelegateChoice2 choice = Bearings;
            choice += ShockAbsorbers;
            choice += ExhaustSystem;
            choice += Filters;
            choice += AirСonditioningСompressors;
            choice += Starters;
            choice += Springs;
            choice += Exit;

            string[] menuItems = new string[] { "\t\t\tПодшипники", "\t\t\tАмортизаторы", "\t\t\tВыхлопная система",
                "\t\t\tФильтры", "\t\t\tКомпрессоры кондиционера", "\t\t\tСтартеры", "\t\t\tРессоры","\t\t\tВыход" };
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
                            case 8:
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
        }

        public static void SKF()
        {
            DelegateChoice2 choice = Bearings;
            choice += ShockAbsorbers;
            choice += ExhaustSystem;
            choice += Filters;
            choice += AirСonditioningСompressors;
            choice += Starters;
            choice += Springs;
            choice += Exit;

            string[] menuItems = new string[] { "\t\t\tПодшипники", "\t\t\tАмортизаторы", "\t\t\tВыхлопная система",
                "\t\t\tФильтры", "\t\t\tКомпрессоры кондиционера", "\t\t\tСтартеры", "\t\t\tРессоры","\t\t\tВыход" };
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
                            case 8:
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
        }

        public static void Bearings()
        {
            IGoodsAbstractFactory n = new NippartsFactory();//????

            Console.WriteLine("Наименование: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Размещение: ");
            string Accommodation = Console.ReadLine();
            Console.WriteLine("Ширина1 (мм): ");
            string Width1 = Console.ReadLine();
            Console.WriteLine("Ширина2 (мм): ");
            string Width2 = Console.ReadLine();
            Console.WriteLine("Наружный диаметр1 (мм): ");
            string OutsideDiameter1 = Console.ReadLine();
            Console.WriteLine("Наружный диаметр2 (мм): ");
            string OutsideDiameter2 = Console.ReadLine();
            Console.WriteLine("Внутрений диаметр1 (мм): ");
            string InnerDiameter1 = Console.ReadLine();
            Console.WriteLine("Внутрений диаметр2 (мм): ");
            string InnerDiameter2 = Console.ReadLine();
            Bearings b = n.GetBearings(Name, Accommodation, Width1, Width2, OutsideDiameter1, OutsideDiameter2,
                InnerDiameter1, InnerDiameter2);//????
            b.PrintBearings();
            //"Подшипники", "Задний мост", "14,61 мм", "14,73 мм", "39,88 мм", "50,29 мм", "17,46 мм", "29 мм"
            //goods.Add(1, b);
            //dbStock.SaveAllData(goods);//не добавляется
            //dbStock.LoadAllData();
        }

        public static void ShockAbsorbers()
        {
            IGoodsAbstractFactory n = new NippartsFactory();//???

            Console.WriteLine("Наименование: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Размещение: ");
            string Accommodation = Console.ReadLine();
            Console.WriteLine("Сторона: ");
            string Side = Console.ReadLine();
            Console.WriteLine("Вид наполнителя: ");
            string TypeOfFiller = Console.ReadLine();
            Console.WriteLine("Количество на ось: ");
            int QuantityPerAxle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Гарантия: ");
            string Guarantee = Console.ReadLine();
            Console.WriteLine("Гарантия в комплекте: ");
            string WarrantyIncluded = Console.ReadLine();

            ShockAbsorbers s = n.GetShockAbsorbers(Name, Accommodation, Side, TypeOfFiller, QuantityPerAxle, Guarantee,
                WarrantyIncluded);//????
            s.PrintShockAbsorbers();
            //"Подшипники", "Задний мост", "14,61 мм", "14,73 мм", "39,88 мм", "50,29 мм", "17,46 мм", "29 мм"
            //goods.Add(1, b);
            //dbStock.SaveAllData(goods);//не добавляется
            //dbStock.LoadAllData();
        }
        public static void ExhaustSystem()
        {
            IGoodsAbstractFactory n = new NippartsFactory();//???

            Console.WriteLine("Наименование: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Размещение: ");
            string Accommodation = Console.ReadLine();
            Console.WriteLine("Материал: ");
            string Material = Console.ReadLine();
            Console.WriteLine("Толщина метала (мм): ");
            string MetalThickness = Console.ReadLine();

            ExhaustSystem e = n.GetExhaustSystem(Name, Accommodation, Material, MetalThickness);//????
            e.PrintExhaustSystem();
            //"Подшипники", "Задний мост", "14,61 мм", "14,73 мм", "39,88 мм", "50,29 мм", "17,46 мм", "29 мм"
            //goods.Add(1, b);
            //dbStock.SaveAllData(goods);//не добавляется
            //dbStock.LoadAllData();
        }

        public static void Filters()
        {
            IGoodsAbstractFactory n = new NippartsFactory();//???

            Console.WriteLine("Наименование: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Тип фильтра: ");
            string FilterType = Console.ReadLine();
            Console.WriteLine("Выполнение фильтра: ");
            string ExecutingFilter = Console.ReadLine();
            Console.WriteLine("Высота (мм): ");
            string Height = Console.ReadLine();
            Console.WriteLine("Наружный диаметр1 (мм): ");
            string OutsideDiameter1 = Console.ReadLine();
            Console.WriteLine("Наружный диаметр2 (мм): ");
            string OutsideDiameter2 = Console.ReadLine();
            Console.WriteLine("Диаметр уплотненной прокладки (мм): ");
            string SealedGasketDiameter = Console.ReadLine();
            Console.WriteLine("Внутреняя резьба (мм): ");
            string InternalThread = Console.ReadLine();
            Console.WriteLine("Гарантия: ");
            string Guarantee = Console.ReadLine();

            Filters f = n.GetFilters(Name, FilterType, ExecutingFilter, Height, OutsideDiameter1,
            OutsideDiameter2, SealedGasketDiameter, InternalThread, Guarantee);//????
            f.PrintFilters();
            //"Подшипники", "Задний мост", "14,61 мм", "14,73 мм", "39,88 мм", "50,29 мм", "17,46 мм", "29 мм"
            //goods.Add(1, b);
            //dbStock.SaveAllData(goods);//не добавляется
            //dbStock.LoadAllData();
        }

        public static void AirСonditioningСompressors()
        {
            IGoodsAbstractFactory n = new NippartsFactory();//???

            Console.WriteLine("Наименование: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Длина (мм): ");
            string Length = Console.ReadLine();
            Console.WriteLine("Высота (мм): ");
            string Height = Console.ReadLine();
            Console.WriteLine("Количество ребер: ");
            int NumberOfRibs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Шкива (мм): ");
            string Pulley = Console.ReadLine();
            Console.WriteLine("Вес (г): ");
            string Weight = Console.ReadLine();
            Console.WriteLine("Количество масла (мл): ");
            string AmountOfOil = Console.ReadLine();
            Console.WriteLine("Хладагент: ");
            string Coolant = Console.ReadLine();
            Console.WriteLine("Впускной (мм): ");
            string Inlet = Console.ReadLine();
            Console.WriteLine("Выпускной (мм): ");
            string Outlet = Console.ReadLine();
            Console.WriteLine("Компресорное масло: ");
            string CompressorOil = Console.ReadLine();

            AirСonditioningСompressors f = n.GetAirСonditioningСompressors(Name, Length, Height, NumberOfRibs, 
                Pulley, Weight, AmountOfOil, Coolant, Inlet, Outlet, CompressorOil);//????
            f.PrintAirСonditioningСompressors();
            //"Подшипники", "Задний мост", "14,61 мм", "14,73 мм", "39,88 мм", "50,29 мм", "17,46 мм", "29 мм"
            //goods.Add(1, b);
            //dbStock.SaveAllData(goods);//не добавляется
            //dbStock.LoadAllData();
        }

        public static void Starters()
        {
            IGoodsAbstractFactory n = new NippartsFactory();//???

            Console.WriteLine("Наименование: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Марка автомобиля: ");
            string CarBrand = Console.ReadLine();
            Console.WriteLine("Модель автомобиля: ");
            string CarModel = Console.ReadLine();
            Console.WriteLine("Год выпуска автомобиля: ");
            string YearCar = Console.ReadLine();
            Console.WriteLine("Количество зубцов: ");
            int NumberOfTeeth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напряжение (В): ");
            string Voltage = Console.ReadLine();
            Console.WriteLine("Габариты (мм): ");
            string Dimensions = Console.ReadLine();

            Starters s = n.GetStarters(Name, CarBrand, CarModel, YearCar, NumberOfTeeth, Voltage, Dimensions);//????
            s.PrintStarters();
            //"Подшипники", "Задний мост", "14,61 мм", "14,73 мм", "39,88 мм", "50,29 мм", "17,46 мм", "29 мм"
            //goods.Add(1, b);
            //dbStock.SaveAllData(goods);//не добавляется
            //dbStock.LoadAllData();
        }

        public static void Springs()
        {
            IGoodsAbstractFactory n = new NippartsFactory();//???

            Console.WriteLine("Наименование: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Размещение: ");
            string Accommodation = Console.ReadLine();
            Console.WriteLine("Марка автомобиля: ");
            string CarBrand = Console.ReadLine();
            Console.WriteLine("Модель автомобиля: ");
            string CarModel = Console.ReadLine();
            Console.WriteLine("Длина (мм): ");
            string Length = Console.ReadLine();
            Console.WriteLine("Ширина (мм): ");
            string Width = Console.ReadLine();
            Console.WriteLine("Толщина по центру (мм): ");
            string ThicknessInTheCenter = Console.ReadLine();

            Springs s = n.GetSprings(Name, Accommodation, CarBrand, CarModel, Length, Width, ThicknessInTheCenter);//????
            s.PrintSprings();
            //"Подшипники", "Задний мост", "14,61 мм", "14,73 мм", "39,88 мм", "50,29 мм", "17,46 мм", "29 мм"
            //goods.Add(1, b);
            //dbStock.SaveAllData(goods);//не добавляется
            //dbStock.LoadAllData();
        }

        public static void PrintGoods()
        {
            DataBaseStock dbStock = new DataBaseStock();
            dbStock.LoadAllData();
        }

        public static void FindGoodByName()
        {

        }

        public static void FindGoodByNameManufacturer()
        {

        }

        public static void FindGoodByCategory()
        {

        }

        public static void FindGoodByDate()
        {

        }

        public static void PrintCheck()
        {

        }

        public static void PayCheck()
        {

        }

        public static void Exit()
        {
            System.Environment.Exit(0);
        }
        
        
    }
}
