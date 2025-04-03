using System;
using System.Collections.Generic;
using System.Linq;

public class EmployeeInfo
{
    public static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>()
        {
            new Employee { LastName = "Иванов", FirstName = "Иван", MiddleName = "Иванович", Position = "Менеджер", YearEmployed = 2015 },
            new Employee { LastName = "Петров", FirstName = "Петр", MiddleName = "Петрович", Position = "Разработчик", YearEmployed = 2018 },
            new Employee { LastName = "Сидоров", FirstName = "Сидор", MiddleName = "Сидорович", Position = "Аналитик", YearEmployed = 2020 },
            new Employee { LastName = "Смирнов", FirstName = "Алексей", MiddleName = "Игоревич", Position = "Тестировщик", YearEmployed = 2017 },
            new Employee { LastName = "Кузнецов", FirstName = "Дмитрий", MiddleName = "Сергеевич", Position = "Дизайнер", YearEmployed = 2019 }
        };

        Console.WriteLine("Введите данные нового сотрудника:");
        Console.Write("Фамилия: ");
        string lastName = Console.ReadLine();
        Console.Write("Имя: ");
        string firstName = Console.ReadLine();
        Console.Write("Отчество: ");
        string middleName = Console.ReadLine();
        Console.Write("Должность: ");
        string position = Console.ReadLine();
        Console.Write("Год принятия на работу: ");
        int yearEmployed = int.Parse(Console.ReadLine());

        Employee newEmployee = new Employee { LastName = lastName, FirstName = firstName, MiddleName = middleName, Position = position, YearEmployed = yearEmployed };
        employeeList.Add(newEmployee);

        employeeList = employeeList.OrderBy(e => e.LastName).ToList();

        Console.WriteLine("\nСписок сотрудников (отсортированный по фамилии):");
        foreach (var employee in employeeList)
        {
            Console.WriteLine(employee.Info);
        }

        Console.Write("\nВведите фамилию сотрудника для удаления: ");
        string lastNameToDelete = Console.ReadLine();
        Console.Write("Введите имя сотрудника для удаления: ");
        string firstNameToDelete = Console.ReadLine();
        Console.Write("Введите отчество сотрудника для удаления: ");
        string middleNameToDelete = Console.ReadLine();

        Employee employeeToRemove = employeeList.FirstOrDefault(e =>
            e.LastName == lastNameToDelete &&
            e.FirstName == firstNameToDelete &&
            e.MiddleName == middleNameToDelete);

        if (employeeToRemove.LastName != null)
        {
            employeeList.Remove(employeeToRemove);
            Console.WriteLine($"Сотрудник {lastNameToDelete} {firstNameToDelete} {middleNameToDelete} удален.");

            Console.WriteLine("\nСписок сотрудников после удаления:");
            foreach (var employee in employeeList)
            {
                Console.WriteLine(employee.Info);
            }
        }
        else
        {
            Console.WriteLine("Сотрудник не найден.");
        }
    }
}