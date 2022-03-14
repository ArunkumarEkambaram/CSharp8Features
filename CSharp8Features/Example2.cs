using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Features
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static double PerDaySalary { get; set; }
        public static int NoOfDaysWorked { get; set; }

        public void AcceptDetails()
        {
            Id = 101;
            Name = "Pravin";
            PerDaySalary = 6000;
            NoOfDaysWorked = 25;
        }

        public void PrintDetails()
        {
            //Local Function
            static double CalculateSalary()
            {
                return PerDaySalary * NoOfDaysWorked;
            }
            double Total = CalculateSalary();
            Console.WriteLine($"Id :{Id}\nName :{Name}\nTotal Salary :{Total}");
        }

    }
}
