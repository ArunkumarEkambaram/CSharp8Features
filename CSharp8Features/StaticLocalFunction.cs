using System;
using System.Collections.Generic;

namespace CSharp8Features
{
    internal class StaticLocalFunction
    {
        //Local Function = C# 7.0
        public int LocalFunction1(int a, int b)
        {
            if (check(a, b))
                return a / b;
            else
                return b / a;

            bool check(int x, int y)
            {
                return x > y;
            }
        }

        //Local Function = C# 8.0
        public int LocalFunction2(int a, int b)
        {
            if (check(a, b))
                return a / b;
            else
                return b / a;

            static bool check(int x, int y) //Adding static to Local Function
            {
                return x > y;
            }
        }

        static void Main(string[] args)
        {
            StaticLocalFunction obj = new StaticLocalFunction();
            Console.WriteLine(obj.LocalFunction1(10, 20));
            Console.WriteLine(obj.LocalFunction2(10, 20));

            //Null Coalescing Assignment C# 8.0 - Example
            //old way
            StaticLocalFunction obj2 = null;
            StaticLocalFunction obj3 = null;

            if (obj2 == null)
            {
                obj2 = new StaticLocalFunction();
            }

            //c# 8.0 Null Coalescing assignment
            obj2 ??= new StaticLocalFunction();
             
            //OR
            if (obj2 == null)
            {
                obj2 = new StaticLocalFunction();
            }

            //?? - Used by reference type 
            obj2 = obj3 ?? null;

            string city = null;
            string values;
            
            //C# 1.0
            if (city != null)
            {
                values = city;
            }
            else
            {
                values = string.Empty;
            }

            //ternary operator - C# 2.0
            values = city != null ? city : string.Empty;
    
            //null coalesing - C# 4.0
            values= city ?? string.Empty;
        }
    }
}
