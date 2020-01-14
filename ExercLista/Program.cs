using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercLista
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            double salary, percentage;

            List<Employee> employees = new List<Employee>();
            Employee employee;

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine("Employee #" + i);
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(employee = new Employee
                {
                    Id = id,
                    Name = name,
                    Salary = salary
                });

                Console.WriteLine();
            }

            Console.Write("Enter the employee that will have salary increase: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentage: ");
            percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            employee = employees.Find(x => x.Id == id);
            //Employee emp = list.Find(x => x.Id == searchId);

            if (employee != null)             
                employee.increaseSalary(percentage);
            else
                Console.WriteLine("This id does not exists");

            Console.WriteLine();
            Console.WriteLine("Updated List of employees");

            foreach (Employee obj in employees)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
