using Microsoft.EntityFrameworkCore;
using System;

namespace ConsoleApp1
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        private int age = 0;
        public string Passport { get; set; }
        public decimal Height { get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Возраст должен быть больше 0");
                }
                age = value;
            }
        }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }

    public class Salary
    {
        public int SalaryId { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }

    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
    }

    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\KIS\\lutaenko.a\\BD_planning\\ConsoleApp1\\bin\\Debug\\net8.0\\app.db");
        }
    }
}
