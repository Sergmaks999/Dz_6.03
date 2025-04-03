using System;

public class Salary
{
    public static void Main(string[] args)
    {
        Manager manager = new Manager("Иванов Иван Иванович", 22);
        DepartmentHead head = new DepartmentHead("Петров Петр Петрович", 20);
        Accounting accounting = new Accounting();

        Console.WriteLine("Информация о менеджере:");
        manager.Print();
        double managerTax = accounting.CalculateIncomeTax(manager, manager.WorkingDays);
        Console.WriteLine($"Подоходный налог: {managerTax}");

        Console.WriteLine("\nИнформация о главе отдела:");
        head.Print();
        double headTax = accounting.CalculateIncomeTax(head, head.WorkingDays);
        Console.WriteLine($"Подоходный налог: {headTax}");
    }
}