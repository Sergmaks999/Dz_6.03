using System;
using System.Collections.Generic;
using System.Linq;

public class CarInfo
{
    public static void Main(string[] args)
    {
        List<Car> carList = new List<Car>()
        {
            new Car { VIN = "VIN123", Brand = "Toyota", Model = "Camry", Year = 2018, Color = "Silver" },
            new Car { VIN = "VIN456", Brand = "Honda", Model = "Civic", Year = 2020, Color = "Blue" },
            new Car { VIN = "VIN789", Brand = "Ford", Model = "Focus", Year = 2015, Color = "Red" },
            new Car { VIN = "VIN012", Brand = "BMW", Model = "X5", Year = 2022, Color = "Black" },
            new Car { VIN = "VIN345", Brand = "Mercedes", Model = "C-Class", Year = 2021, Color = "White" }
        };

        Console.WriteLine("Введите данные новой машины:");
        Console.Write("VIN: ");
        string vin = Console.ReadLine();
        Console.Write("Марка: ");
        string brand = Console.ReadLine();
        Console.Write("Модель: ");
        string model = Console.ReadLine();
        Console.Write("Год выпуска: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Цвет: ");
        string color = Console.ReadLine();

        Car newCar = new Car { VIN = vin, Brand = brand, Model = model, Year = year, Color = color };
        carList.Add(newCar);

        carList = carList.OrderBy(car => car.Year).ToList();

        Console.WriteLine("\nСписок машин (отсортированный по году выпуска):");
        foreach (var car in carList)
        {
            Console.WriteLine(car.Info);
        }

        Console.Write("\nВведите VIN-номер машины для удаления: ");
        string vinToDelete = Console.ReadLine();

        Car carToRemove = carList.FirstOrDefault(car => car.VIN == vinToDelete);

        if (carToRemove.VIN != null)
        {
             carList.Remove(carToRemove);
             Console.WriteLine($"Машина с VIN-номером {vinToDelete} удалена.");

            Console.WriteLine("\nСписок машин после удаления:");
            foreach (var car in carList)
            {
                Console.WriteLine(car.Info);
            }

        }
        else
        {
          Console.WriteLine("Автомобиль не найден.");
        }


    }
}