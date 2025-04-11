using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Car : ITransport
{
    public string LicensePlate { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    public static string TransportType => "Автомобиль";
    public double RentPricePerMinute { get; set; }

    public Car(string licensePlate, string brand, string model, string color, double rentPricePerMinute)
    {
        LicensePlate = licensePlate;
        Brand = brand;
        Model = model;
        Color = color;
        RentPricePerMinute = rentPricePerMinute;
    }
}