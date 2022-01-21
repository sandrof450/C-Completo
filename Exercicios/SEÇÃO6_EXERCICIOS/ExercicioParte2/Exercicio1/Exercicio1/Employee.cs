﻿using System.Globalization;
namespace Exercicio1
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double porcentFunc)
        {
            Salary = Salary + (Salary * (porcentFunc / 100));
        }

        public override string ToString()
        {
            return Id +
                ", " +
                Name +
                ", " +
                Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}

    


