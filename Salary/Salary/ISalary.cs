using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ISalary
{
    string EmployeeName { get; set; }
    int WorkingDays { get; set; }
    double CalculateSalary();
}

public interface IConsoleOutput
{
    void Print();
}