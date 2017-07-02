using System;

namespace ConcurrentModel.DesignPattern.TemplatePattern
{
    public class ChineseCabbage : CookVegetable
    {
        public override void PutVegetable()
        {
            Console.WriteLine("放入大白菜");
        }
    }
}