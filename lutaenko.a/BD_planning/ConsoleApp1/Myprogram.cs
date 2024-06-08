using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AppDbContext db = new AppDbContext())
            {
                // Добавление записей в таблицу Сотрудники
                Employee employee1 = new Employee
                {
                    FirstName = "Иван",
                    LastName = "Иванов",
                    Age = 30,
                    Passport = "1234567890",
                    Height = 175,
                    DepartmentId = 1 // Предположим, что у сотрудника есть связь с отделом
                };

                db.Employees.Add(employee1);
                db.SaveChanges();

                employee1 = db.Employees.SingleOrDefault(e => e.EmployeeId == 1);
                if (employee1 != null)
                {
                    employee1.FirstName = "Петр";
                    db.SaveChanges();
                }

                // Удаление сотрудника с определенным идентификатором
                employee1 = db.Employees.SingleOrDefault(e => e.EmployeeId == 2);
                if (employee1 != null)
                {
                    db.Employees.Remove(employee1);
                    db.SaveChanges();
                }

                // Выборка всех имен сотрудников
                var allEmployeeNames = db.Employees.Select(e => e.FirstName);
                foreach (var name in allEmployeeNames)
                {
                    Console.WriteLine(name);
                }

                // Выборка всех сотрудников
                var allEmployees = db.Employees;
                foreach (var employee in allEmployees)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.Department.Name}");
                }
            }
        }
    }
}
