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
        public delegate void DelegateChoice3();
        public delegate void DelegateChoice4();
        public delegate void DelegateChoice5();
        
        static void Main(string[] args)
        {
            //Планы на будущее:
            //1. Использовать паттерн Компоновщик для создания чека
            //2. Использовать паттерн Состояние для оплаты чека
            //3. Использовать паттерн Итератор для Склада (приход/расход)
            //4. Добавить в меню:
                            //Создать сотрудника
                            //Показать сотрудников 

            //List <Worker> employees = new List<Worker>();
            //Worker worker = new Worker("Виктор", "Иванович", "Глущенко", new DateTime(1990,10,06),
            //new DateTime(2023,01,21), new DateTime(2024,10,10), "Автослесарь", 8950.50);

            // worker.ToString();
            //employees.Add(worker);
            ///dbEmployees.SaveAllData(employees);
            //dbEmployees.LoadAllData();
            //dbEmployees.FindWorkerInFile("Глущенко");
            //dbEmployees.SortEmployees();


            DelegateChoice choice = CreateCar;
            choice += PrintCars;
            choice += FindCarByLisencePlate;
            choice += SortCarsByBrand;
            choice += CreateOrder;
            choice += CreateGood;
            choice += Exit;

            string[] menuItems = new string[] { "\t\t\tСоздать автомобиль", "\t\t\tПосмотреть все автомобили в базе данных",
                 "\t\t\tНайти автомобиль по номерному знаку в базе данных", "\t\t\tОтсортировать автомобили в базе данных по марке авто",
                 "\t\t\tСоздать заказ", "\t\t\tДобавить товар", "\t\t\tВыход" };

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
                            case 7:
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
            Console.Clear();
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
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Автомобиль добавлен в базу данных!");
        }

        public static void PrintCars()
        {
            DataBaseCars dbCars = new DataBaseCars();
            dbCars.LoadAllData();
            Console.WriteLine("\n\n\n");
        }

        public static void FindCarByLisencePlate()
        {             
            DataBaseCars dbCars = new DataBaseCars();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("\n\nВведите номерной знак автомобиля для поиска: ");
            string licensePlate = Console.ReadLine();
            Console.WriteLine("Автомобиль: " + dbCars.FindCarInFile(licensePlate));
        }

        public static void SortCarsByBrand()
        {
            Console.Clear();
            DataBaseCars dbCars = new DataBaseCars();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
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

            Console.Clear();
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
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                order.PrintOrder();
                dbOrders.SaveAllData(orders);
                
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
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                order.PrintOrder();
                dbOrders.SaveAllData(orders);

                Car car = new Car(brand, model, year, licensePlate);
                cars.Add(car);
                dbCars.SaveAllData(cars);
                Console.WriteLine("Заказ создан!");
            }
        }

        public static void CreateGood()
        {
            Console.Clear();
            Console.WriteLine("Выберите производителя:");
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
                                ((DelegateChoice1)choice.GetInvocationList()[index])();
                                break;
                        }
                        break;
                }
            }
        }

        public static void Nipparts()
        {
            Console.Clear();
            DelegateChoice2 choice = NippartsBearings;
            choice += NippartsShockAbsorbers;
            choice += NippartsExhaustSystem;
            choice += NippartsFilters;
            choice += NippartsAirСonditioningСompressors;
            choice += NippartsStarters;
            choice += NippartsSprings;
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
                                ((DelegateChoice2)choice.GetInvocationList()[index])();
                                break;
                        }
                        break;
                }
            }
        }

        public static void SWAG()
        {
            Console.Clear();
            DelegateChoice3 choice = SWAGBearings;
            choice += SWAGShockAbsorbers;
            choice += SWAGExhaustSystem;
            choice += SWAGFilters;
            choice += SWAGAirСonditioningСompressors;
            choice += SWAGStarters;
            choice += SWAGSprings;
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
                                ((DelegateChoice3)choice.GetInvocationList()[index])();
                                break;
                        }
                        break;
                }
            }
        }

        public static void Febest() 
        {
            Console.Clear();
            DelegateChoice4 choice = FebestBearings;
            choice += FebestShockAbsorbers;
            choice += FebestExhaustSystem;
            choice += FebestFilters;
            choice += FebestAirСonditioningСompressors;
            choice += FebestStarters;
            choice += FebestSprings;
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
                                ((DelegateChoice4)choice.GetInvocationList()[index])();
                                break;
                        }
                        break;
                }
            }
        }

        public static void SKF()
        {
            Console.Clear();
            DelegateChoice5 choice = SKFBearings;
            choice += SKFShockAbsorbers;
            choice += SKFExhaustSystem;
            choice += SKFFilters;
            choice += SKFAirСonditioningСompressors;
            choice += SKFStarters;
            choice += SKFSprings;
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
                                ((DelegateChoice5)choice.GetInvocationList()[index])();
                                break;
                        }
                        break;
                }
            }
        }

        public static void FebestBearings()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new FebestFactory();

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
                InnerDiameter1, InnerDiameter2);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            b.PrintBearings();
        }

        public static void FebestShockAbsorbers()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new FebestFactory();

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
                WarrantyIncluded);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            s.PrintShockAbsorbers();
        }
        public static void FebestExhaustSystem()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new FebestFactory();

            Console.WriteLine("Наименование: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Материал: ");
            string Material = Console.ReadLine();
            Console.WriteLine("Толщина метала (мм): ");
            string MetalThickness = Console.ReadLine();

            ExhaustSystem e = n.GetExhaustSystem(Name, Material, MetalThickness);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            e.PrintExhaustSystem();
        }

        public static void FebestFilters()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new FebestFactory();

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
            OutsideDiameter2, SealedGasketDiameter, InternalThread, Guarantee);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            f.PrintFilters();
        }

        public static void FebestAirСonditioningСompressors()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new FebestFactory();

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

            AirСonditioningСompressors a = n.GetAirСonditioningСompressors(Name, Length, Height, NumberOfRibs,
                Pulley, Weight, AmountOfOil, Coolant, Inlet, Outlet, CompressorOil);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            a.PrintAirСonditioningСompressors();
        }

        public static void FebestStarters()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new FebestFactory();

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

            Starters s = n.GetStarters(Name, CarBrand, CarModel, YearCar, NumberOfTeeth, Voltage, Dimensions);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            s.PrintStarters();
        }

        public static void FebestSprings()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new FebestFactory();

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

            Springs s = n.GetSprings(Name, Accommodation, CarBrand, CarModel, Length, Width, ThicknessInTheCenter);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            s.PrintSprings();
        }
        public static void SKFBearings()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new SKFFactory();

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
                InnerDiameter1, InnerDiameter2);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            b.PrintBearings();
        }

        public static void SKFShockAbsorbers()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new SKFFactory();

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
                WarrantyIncluded);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            s.PrintShockAbsorbers();
        }
        public static void SKFExhaustSystem()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new SKFFactory();

            Console.WriteLine("Наименование: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Материал: ");
            string Material = Console.ReadLine();
            Console.WriteLine("Толщина метала (мм): ");
            string MetalThickness = Console.ReadLine();

            ExhaustSystem e = n.GetExhaustSystem(Name, Material, MetalThickness);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            e.PrintExhaustSystem();
        }

        public static void SKFFilters()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new SKFFactory();

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
            OutsideDiameter2, SealedGasketDiameter, InternalThread, Guarantee);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            f.PrintFilters();
        }

        public static void SKFAirСonditioningСompressors()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new SKFFactory();

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

            AirСonditioningСompressors a = n.GetAirСonditioningСompressors(Name, Length, Height, NumberOfRibs,
                Pulley, Weight, AmountOfOil, Coolant, Inlet, Outlet, CompressorOil);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            a.PrintAirСonditioningСompressors();
        }

        public static void SKFStarters()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new SKFFactory();

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

            Starters s = n.GetStarters(Name, CarBrand, CarModel, YearCar, NumberOfTeeth, Voltage, Dimensions);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            s.PrintStarters();
        }

        public static void SKFSprings()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new SKFFactory();

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

            Springs s = n.GetSprings(Name, Accommodation, CarBrand, CarModel, Length, Width, ThicknessInTheCenter);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            s.PrintSprings();
        }
        public static void SWAGBearings()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new SWAGFactory();

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
                InnerDiameter1, InnerDiameter2);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            b.PrintBearings();
        }

        public static void SWAGShockAbsorbers()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new SWAGFactory();

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
                WarrantyIncluded);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            s.PrintShockAbsorbers();
        }
        public static void SWAGExhaustSystem()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new SWAGFactory();

            Console.WriteLine("Наименование: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Материал: ");
            string Material = Console.ReadLine();
            Console.WriteLine("Толщина метала (мм): ");
            string MetalThickness = Console.ReadLine();

            ExhaustSystem e = n.GetExhaustSystem(Name, Material, MetalThickness);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            e.PrintExhaustSystem();
        }

        public static void SWAGFilters()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new SWAGFactory();

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
            OutsideDiameter2, SealedGasketDiameter, InternalThread, Guarantee);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            f.PrintFilters();
        }

        public static void SWAGAirСonditioningСompressors()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new SWAGFactory();

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

            AirСonditioningСompressors a = n.GetAirСonditioningСompressors(Name, Length, Height, NumberOfRibs,
                Pulley, Weight, AmountOfOil, Coolant, Inlet, Outlet, CompressorOil);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            a.PrintAirСonditioningСompressors();
        }

        public static void SWAGStarters()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new SWAGFactory();

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

            Starters s = n.GetStarters(Name, CarBrand, CarModel, YearCar, NumberOfTeeth, Voltage, Dimensions);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            s.PrintStarters();
        }

        public static void SWAGSprings()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new SWAGFactory();

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

            Springs s = n.GetSprings(Name, Accommodation, CarBrand, CarModel, Length, Width, ThicknessInTheCenter);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            s.PrintSprings();
        }
        public static void NippartsBearings()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new NippartsFactory();

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
                InnerDiameter1, InnerDiameter2);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            b.PrintBearings();
        }

        public static void NippartsShockAbsorbers()
        {
            Console.Clear ();
            IGoodsAbstractFactory n = new NippartsFactory();

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
                WarrantyIncluded);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            s.PrintShockAbsorbers();
        }
        public static void NippartsExhaustSystem()
        {
            Console.Clear ();
            IGoodsAbstractFactory n = new NippartsFactory();

            Console.WriteLine("Наименование: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Материал: ");
            string Material = Console.ReadLine();
            Console.WriteLine("Толщина метала (мм): ");
            string MetalThickness = Console.ReadLine();

            ExhaustSystem e = n.GetExhaustSystem(Name, Material, MetalThickness);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            e.PrintExhaustSystem();
        }

        public static void NippartsFilters()
        {
            Console.Clear ();
            IGoodsAbstractFactory n = new NippartsFactory();

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
            OutsideDiameter2, SealedGasketDiameter, InternalThread, Guarantee);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            f.PrintFilters();
        }

        public static void NippartsAirСonditioningСompressors()
        {
            Console.Clear ();
            IGoodsAbstractFactory n = new NippartsFactory();

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

            AirСonditioningСompressors a = n.GetAirСonditioningСompressors(Name, Length, Height, NumberOfRibs, 
                Pulley, Weight, AmountOfOil, Coolant, Inlet, Outlet, CompressorOil);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            a.PrintAirСonditioningСompressors();
        }

        public static void NippartsStarters()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new NippartsFactory();

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

            Starters s = n.GetStarters(Name, CarBrand, CarModel, YearCar, NumberOfTeeth, Voltage, Dimensions);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            s.PrintStarters();
        }

        public static void NippartsSprings()
        {
            Console.Clear();
            IGoodsAbstractFactory n = new NippartsFactory();

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

            Springs s = n.GetSprings(Name, Accommodation, CarBrand, CarModel, Length, Width, ThicknessInTheCenter);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Товар добавлен!");
            Console.WriteLine();
            s.PrintSprings();
        }

        public static void PrintGoods()
        {
            DataBaseStock dbStock = new DataBaseStock();
            dbStock.LoadAllData();
        }

        public static void Exit()
        {
            Console.Clear();
            System.Environment.Exit(0);
        }

        
    }
}
