using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Scooter : ITransport
{
    public string Model { get; set; }
    public int Year { get; set; }

    public static string TransportType => "Самокат";
    public double RentPricePerMinute { get; set; }

    public Scooter(string model, int year, double rentPricePerMinute)
    {
        Model = model;
        Year = year;
        RentPricePerMinute = rentPricePerMinute;
    }
}