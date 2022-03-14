using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Features
{
    internal class Example1
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public int Total { get; }

        public int Tot => Num1 + Num2;

        // public readonly void Print() => Console.WriteLine(Total);

        public Example1()
        {
            Id = 1001;
            Name = "Sandeep";
            Total = Num1 + Num2;
            // Tot = 100 + 200;
        }

        public void PrintData() => Console.WriteLine($"Id :{Id}\tName :{Name}");



        public override string ToString()
        {
            //  Total = 100 + 200;
            return $"Id :{Id}\nName :{Name}";
        }

        static void Main(string[] args)
        {
            Example1 obj = new Example1();
            // obj.PrintData();
            Console.WriteLine(obj);         
        }        
    }
}
