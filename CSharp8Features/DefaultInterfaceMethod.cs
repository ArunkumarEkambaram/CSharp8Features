using System;
using static System.Console;

namespace CSharp8Features
{
    public interface IStudent
    {
        void GetStudentDetails();
        void PrintStudentDetails();

        //Default Interface Method in C# 8.0
        public double CalculateTotal(double Mark1, double Mark2, double Mark3)
        {
            return Mark1 + Mark2 + Mark3;
        }
    }

    public class ParentClass
    {
        public  void Print() { Console.WriteLine("Parent"); }
    }
    internal class Student : IStudent
    {
        public void GetStudentDetails()
        {
            WriteLine("Get Students");
        }

        public void PrintStudentDetails()
        {
            WriteLine("Print Students");
        }

        static void Main(string[] args)
        {
            IStudent student = new Student(); //Parent Implementation or Parent Reference or Interface reference
            student.GetStudentDetails();
            student.PrintStudentDetails();
            //Must use interface reference to call Default Method of Interface
            WriteLine($"Total Marks : {student.CalculateTotal(98, 99, 95)}");
            //student.Print();
        }
    }
}
