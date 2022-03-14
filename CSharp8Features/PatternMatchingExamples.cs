using System;
using System.Collections;
using static System.Console;

namespace CSharp8Features
{
    public class Vehicle
    {
        public void GetType(string type)
        {
            Console.WriteLine($"This is {type}");
        }
    }

    class Ship : Vehicle
    {
        public void Sail()
        {
            Console.WriteLine("Ship sail in sea");
        }
    }

    class Airplane : Vehicle
    {
        public void Fly()
        {
            Console.WriteLine("Airplane fly");
        }
    }

    internal class PatternMatchingExamples
    {
        public enum Gender
        {
            Male,
            Female,
            Transgender,
            Others
        }

        //Switch Pattern Marching
        public string GetDataSwitch(Gender gender)
        {
            return gender switch
            {
                Gender.Male => "You have selected Male",
                Gender.Female => "You have selected Female",
                _ => throw new ArgumentOutOfRangeException(nameof(gender), "Invalid enum value")
            };
        }

        //C# 4.0
        public string GetDataSwitch1(Gender gender)
        {
            switch (gender)
            {
                case Gender.Male:
                    return "You have selected Male";
                case Gender.Female:
                    return "You have selected Female";
                default:
                    throw new ArgumentException();
            }
        }

        //Type Pattern Matching - C# 7.0
        public void TypePatternVehicle(Vehicle vehicle)//Ship s=new Ship();  SwitchExample(s)
        {
            switch (vehicle)
            {
                case Ship ship:
                    ship.Sail();
                    ship.GetType("Ship");
                    break;
                case Airplane airplane:
                    airplane.Fly();
                    airplane.GetType("Airplane");
                    break;
                case null:
                    throw new ArgumentNullException(nameof(vehicle)); //passing null in switch case expression
                default:
                    Console.WriteLine("Invalid object");
                    break;
            }
        }

        //C# 6.0
        public void SwitchExample(Vehicle vehicle) 
        {
            switch (vehicle)
            {
                case Ship:
                    Ship ship = (Ship)vehicle;
                    ship.GetType("Ship");
                    ship.Sail();
                    break;
            }
        }

        public void Example(int n1)
        {
            switch (n1)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
            }
        }


        static void Main(string[] args)
        {
            PatternMatchingExamples obj = new(); //Simplified new expression
            //Switch Pattern Matching
            WriteLine(obj.GetDataSwitch(Gender.Male));

            //Type Pattern
            Vehicle vehicle = new Ship();
            obj.TypePatternVehicle(vehicle);

            //Is Pattern
            ArrayList list = new ArrayList { 1, 2, 3, 4, true, 1000.65 };
            foreach (object item in list)
            {
                if (item is int n)
                {
                    WriteLine(n);
                }
            }
        }
    }
}
