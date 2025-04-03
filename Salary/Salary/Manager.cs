using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Manager : ISalary, IConsoleOutput
{
    public string EmployeeName { get; set; }
    public int WorkingDays { get; set; }
    private const double DailyRate = 1000;

    public Manager(string employeeName, int workingDays)
    {
        EmployeeName = employeeName;
        WorkingDays = workingDays;
    }

    public double CalculateSalary()
    {
        return WorkingDays * DailyRate;
    }

    public void Print()
    {
        Console.WriteLine($"Должность: Менеджер");
        Console.WriteLine($"ФИО сотрудника: {EmployeeName}");
        Console.WriteLine($"Количество рабочих дней: {WorkingDays}");
        Console.WriteLine($"Зарплата: {CalculateSalary()}");
    }
}