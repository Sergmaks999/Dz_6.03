using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Accounting
{
    private const double IncomeTaxRate = 0.13;

    public double CalculateIncomeTax(ISalary employee, int days)
    {
        return employee.CalculateSalary() * IncomeTaxRate;
    }
}
