using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Car
    {
        public string brand;
        public string model;
        public string color;
        public string number;

        public Car(string brand = "Undefined", string model = "Undefined", string color = "Undefined", string number = "Undefined")
        {
            this.brand = brand;
            this.color = color;
            this.model = model;
            this.number = number;
        }

        public string GetInfo()
        {
            string s = $"Марка: {brand}\nМодель: {model}\nЦвет: {color}\nНомер: {number}\n\n";
            return s;
        }

        public void SearchCar(Car[] mas)
        {
            bool isthere = true;
            Console.WriteLine("Напишите, с каким параметром хотите найти автомобиль: ");
            string s = Console.ReadLine();
            if (mas.Length == 0)
            {
                Console.WriteLine("Undefined");
            }
            foreach (var item in mas)
            {
                if (item.brand == s || item.color == s || item.model == s|| item.number == s)
                {
                    Console.WriteLine(item.GetInfo());
                    isthere = false;
                }
            }
            if (isthere) Console.WriteLine("Автомобилей с данным параметром нет в наличии.");
            
        }
        public Car[] AddCar(Car[] mas)
        {
            Car[] res = new Car[mas.Length + 1];
            for (int i = 0; i < mas.Length; i++)
            {
                res[i] = mas[i];
            }
            Console.WriteLine("Введите марку автомобиля: ");
            string inBrand = Console.ReadLine();
            Console.WriteLine("Введите модель автомобиля: ");
            string inModel = Console.ReadLine();
            Console.WriteLine("Введите цвет автомобиля: ");
            string inColor = Console.ReadLine();
            Console.WriteLine("Введите номер автомобиля: ");
            string inNumber = Console.ReadLine();
            res[mas.Length] = new Car(inBrand, inModel, inColor, inNumber);
            return res;
        }
    }
}
