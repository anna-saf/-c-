#region Автор
//Анна Сафонова
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача5
{
    class Program
    {
        static void Print(string mes)
        {
            var width = Console.WindowWidth;
            var height = Console.WindowHeight;
            int offsetx = (width - mes.Length) / 2;
            int offsety = (height - 1) / 2;
            Console.SetCursorPosition(offsetx, offsety);
            Console.WriteLine(mes);
        }
        static void Main(string[] args)
        {            
            string text = "Анна Сафонова, Москва";
            Print(text);               
                        
            Console.ReadLine();
        }
    }
}
