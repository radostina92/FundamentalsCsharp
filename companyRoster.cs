using System;
using System.Collections.Generic;
using System.Linq;

namespace companyRoster
{
    class companyRoster
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> years = new List<Employee>();


            string name = "";
            double salary = 0;
            string department = "";

            for (int i = 0; i < n; i++)
            {
                string[] arg = Console.ReadLine()
                       .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                name = arg[0];
                salary = double.Parse(arg[1]);
                department = arg[2];
                Employee currentAge = new Employee(name, salary, department);
                years.Add(currentAge);
            }





        }
    }
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }

        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}
