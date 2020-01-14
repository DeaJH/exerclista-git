using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace ExercLista
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);  
        }

        public void increaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100;
        }
    }
}
