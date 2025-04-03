using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DepartmentHead : ISalary, IConsoleOutput
{
    public string EmployeeName { get; set; }
    public int WorkingDays { get; set; }
    private const double DailyRate = 2500;

    public DepartmentHead(string employeeName, int workingDays)
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
        Console.WriteLine($"Должность: Глава отдела");
        Console.WriteLine($"ФИО сотрудника: {EmployeeName}");
        Console.WriteLine($"Количество рабочих дней: {WorkingDays}");
        Console.WriteLine($"Зарплата: {CalculateSalary()}");
    }
}