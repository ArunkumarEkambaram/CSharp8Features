using System;

namespace CSharp8Features
{
    public struct AddNumbers
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public readonly double Total => Number1 + Number2;

        //public readonly override string ToString()
        //{
        //    return $"Total :{Total}";
        //}

        //Since the Total is used in readonly method, we should explicitly provide readonly for the Total Property
        public readonly string PrintData()
        {
            return $"Total :{Total}";
        }

        static void Main(string[] args)
        {
            AddNumbers obj = new AddNumbers();
            obj.Number1 = 10;
            obj.Number2 = 20;
            //obj.Total = 200;            
            Console.WriteLine(obj.PrintData());
        }
    }
}
