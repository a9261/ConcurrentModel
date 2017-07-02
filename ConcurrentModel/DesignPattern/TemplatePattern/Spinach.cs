using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentModel.DesignPattern.TemplatePattern
{
#warning
    public class Spinach : CookVegetable
    {
        public override void PutVegetable()
        {
            Console.WriteLine("倒入波菜到鍋子");
        }
    }
}
