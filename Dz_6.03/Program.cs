using System;

public class Transport
{
    public static void Main(string[] args)
    {
        Scooter scooter = new Scooter("Xiaomi Mijia M365", 2021, 5);
        TransportRental<Scooter> scooterRental = new TransportRental<Scooter>("Иванов Иван Иванович", scooter, 30);

        Console.WriteLine(scooterRental.GetRentalInfo());
        Console.WriteLine($"Полная стоимость аренды: {scooterRental.CalculateTotalCost()} руб.");

        Car car = new Car("А123BC777", "Lada", "Vesta", "Белый", 15);
        TransportRental<Car> carRental = new TransportRental<Car>("Петров Петр Петрович", car, 60);

        Console.WriteLine(carRental.GetRentalInfo());
        Console.WriteLine($"Полная стоимость аренды: {carRental.CalculateTotalCost()} руб.");
    }
}