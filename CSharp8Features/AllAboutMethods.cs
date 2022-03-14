using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Features
{
    internal class AllAboutMethods
    {
        //Optional Parameter
        public void GetData(int id, string name, double salary=0.0, string Country = "India", string State = null)
        {
            Console.WriteLine($"Id :{id}\nName :{name}\nSalary :{salary}\nState :{State}\nCountry :{Country}");
        }

        static void Main(string[] args)
        {
            AllAboutMethods obj = new AllAboutMethods();
            //obj.GetData("Pradeep", 5000.6, 5); //error
            //Named Parameters / Argument
            obj.GetData(name: "Pradeep", salary: 5000.6, id: 5, State:"TN");

            obj.GetData(1, "Kayal", 6000.6);
        }
    }
}
