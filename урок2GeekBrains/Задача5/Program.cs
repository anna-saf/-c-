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
        static void IndexMasConclusion(double indexmas, double height, double mas)
        {
            if(indexmas>=20.1 && indexmas < 25)
            {
                Console.WriteLine("Ваш вес в норме");
            } else if (indexmas < 20.1)
            {
                Console.WriteLine("У вас недостаток веса. Для нормализации вам необходимо потолстеть на {0:F1}" ,height*height*20.1-mas);
            } else Console.WriteLine("У вас переизбыток веса. Для нормализации вам необходимо похудеть на {0:F1}", mas- height * height* 24.9);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой рост (м2)");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите свой вес (кг)");
            double mas = Convert.ToDouble(Console.ReadLine());
            double IndexMas = mas / (height*height);
            IndexMasConclusion(IndexMas, height, mas);
        }
    }
}
