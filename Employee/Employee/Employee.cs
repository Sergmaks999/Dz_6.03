using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Employee
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string Position { get; set; }
    public int YearEmployed { get; set; }

    public string Info
    {
        get
        {
            return $"ФИО: {LastName} {FirstName} {MiddleName}, Должность: {Position}, Год принятия: {YearEmployed}";
        }
    }

    public int CalculateExperience(int currentYear)
    {
        return currentYear - YearEmployed;
    }
}
