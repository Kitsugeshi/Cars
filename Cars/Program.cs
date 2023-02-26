using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car[] cars = new Car[0];
            while (true)
            {
                Console.WriteLine("Добавить автомобиль - 1\nНайти машину по определённому критерию - 2\nВывод информации о имеющихся автомобилях - 3");
                int operation = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (operation)
                {
                    case 1:
                        cars = car.AddCar(cars);
                        Console.WriteLine();
                        break;
                    case 2:
                        car.SearchCar(cars);
                        Console.WriteLine();
                        break;
                    case 3:
                        if (cars.Length == 0)
                        {
                            Console.WriteLine(car.GetInfo());
                        }
                        else foreach (var item in cars)
                            {
                                Console.WriteLine(item.GetInfo());
                            }
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
            }
        }
    }
}