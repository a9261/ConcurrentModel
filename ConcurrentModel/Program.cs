using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcurrentModel.DesignPattern.TemplatePattern;

namespace ConcurrentModel
{
    class Program
    {
        static void Main(string[] args)
        {

            CookVegetable spinach = new Spinach();
            spinach.StartCookingVegetable();

           CookVegetable cabbage = new ChineseCabbage();
            cabbage.StartCookingVegetable();

           Console.Read();


        }
    }
     
}
