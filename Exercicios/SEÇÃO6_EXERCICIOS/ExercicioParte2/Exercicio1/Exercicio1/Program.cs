using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many employees will be registered? ");
            int nFunc = int.Parse(Console.ReadLine());

            List<Employee> employee = new List<Employee>();

            for (int i = 0; i < nFunc; i++)
            {
                Console.WriteLine($"Employee #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employee.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the emplyee id will have salary increase: ");
            int idFunc = int.Parse(Console.ReadLine());

            Employee emp = employee.Find(x => x.Id == idFunc);

            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double porcentFunc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(porcentFunc);
            }

            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\nUpdate list of employees: ");

            
            foreach( Employee obj in employee)
            {
                //Console.WriteLine($"{obj.Id}, {obj.Name}, {obj.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine(obj);
            }


        }
    }
}