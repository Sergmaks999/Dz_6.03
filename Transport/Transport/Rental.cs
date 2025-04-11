using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TransportRental<T> where T : ITransport
{
    public string ClientFIO { get; set; }
    public T Transport { get; set; }
    public int RentalTimeMinutes { get; set; }

    public TransportRental(string clientFIO, T transport, int rentalTimeMinutes)
    {
        ClientFIO = clientFIO;
        Transport = transport;
        RentalTimeMinutes = rentalTimeMinutes;
    }

    public string GetRentalInfo()
    {
        string transportInfo = "";

        if (Transport is Scooter scooter)
        {
            transportInfo = $"Тип: {Scooter.TransportType}, Модель: {scooter.Model}, Год выпуска: {scooter.Year}, Цена за минуту: {scooter.RentPricePerMinute}";
        }
        else if (Transport is Car car)
        {
            transportInfo = $"Тип: {Car.TransportType}, Гос.номер: {car.LicensePlate}, Марка: {car.Brand}, Модель: {car.Model}, Цвет: {car.Color}, Цена за минуту: {car.RentPricePerMinute}";
        }
        else
        {
            transportInfo = "Неизвестный тип транспорта";
        }

        return $"ФИО клиента: {ClientFIO}, {transportInfo}, Время аренды: {RentalTimeMinutes} мин.";
    }

    public double CalculateTotalCost()
    {
        return RentalTimeMinutes * Transport.RentPricePerMinute;
    }
}