using System;
using System.IO;

namespace CSharp8Features
{
    internal class UsingDeclaration
    {
        public UsingDeclaration()
        {
            Console.WriteLine("Default Constructor");
        }
        static void Main(string[] args)
        {          
            //The below object will be disposed at the end of the scope.
            using var file = new StreamWriter(@"D:\Training_Demos\Capgemini\Files\UsingDeclaration.txt");
            file.WriteLine("Using Declaration Example");

            UsingDeclaration obj = new();//New way object

           
            int x = 10;
            Console.WriteLine($"X :{x}");//string Interpolation

            for (int i = 1; i <= 5; i++)
            {
                //Interpolated Verbatium string - use @$ or $@
                using var file1 = new StreamWriter($@"D:\Files\File{i}.txt");
            }
        }
    }
}
