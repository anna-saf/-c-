using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача2
{
    //Я не поняла, зачем применять TryParse на сумму, она вроде безошибочно будет double
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double a;
            bool numParse;
            do
            {
                do
                {
                    numParse = double.TryParse(Console.ReadLine(), out a);
                    Proverka(numParse);                    
                } while (!numParse);

                int ColvoDrob;
                if (a.ToString().Contains(","))
                    ColvoDrob = a.ToString().Split(',')[1].Length;
                else ColvoDrob = 0;

                if (((a * Math.Pow(10, ColvoDrob) % 2)  != 0) && (a > 0))
                {
                    sum += a;
                }
            } while (a != 0);

            Console.WriteLine("Sum = " + sum.ToString());
        }

        static void Proverka(bool numParse)
        {
            if (!numParse)
                Console.WriteLine("Неправильно введены данные. Пожалуйста, введите число.");
        }
    }
}
