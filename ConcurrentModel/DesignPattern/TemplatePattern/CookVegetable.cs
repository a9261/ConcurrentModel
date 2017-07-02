using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentModel.DesignPattern.TemplatePattern
{
    public abstract class CookVegetable
    {
        public void StartCookingVegetable()
        {
            Console.WriteLine("開始炒菜");
            HeatOil();
            PutVegetable();
            FRY();
        }

        private void HeatOil()
        {
            Console.WriteLine("放入油開火");
        }
        /// <summary>
        /// 放入指定要炒的菜，由子類決定
        /// </summary>
        public abstract void PutVegetable();

        private void FRY()
        {
            Console.WriteLine("炒菜-");
        }
    }
}
