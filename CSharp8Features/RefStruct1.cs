using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Features
{
    ref struct RefStruct1
    {
        public bool IsValid;
    }


    public class Test1
    {

        static void Main(string[] args)
        {
            RefStruct1 obj1 = new RefStruct1();
            obj1.IsValid = true;
            Console.WriteLine(obj1.IsValid);

            //Stackalloc - used to create block of memory on the stack, usaully array are reference type stored on managed heap
            Span<int> numbers = stackalloc int[10];
            ReadOnlySpan<int> numbers2 = stackalloc int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            foreach (var k in numbers)
            {
                Console.WriteLine(k);
            }
        }
    }

}
