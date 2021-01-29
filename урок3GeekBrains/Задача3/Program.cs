using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача3
{
    class Drobi
    {
        private int chislitel;
        private int znamenatel;
        private string znak;

        public int Chislitel
        {
            get
            {
                return chislitel;
            }
            set
            {
                chislitel = value;
            }
        }

        public int Znamenatel
        {
            get
            {
                return znamenatel;
            }
            set
            {
                znamenatel = value;
            }
        }

        public double Drob
        {
            get
            {
                return Convert.ToInt32(znak+"1")* Convert.ToDouble(chislitel) / Convert.ToDouble(znamenatel);
            }
        }

        public Drobi() { }
        public Drobi(int a, int b)
        {
            
            if (b == 0)
                throw new ArgumentException("Знаменатель не может быть равен 0");
            if ((b > 0 && a >= 0)|| (b < 0 && a <= 0))
                znak = "+";
            else znak = "-";
            chislitel = Math.Abs(a);
            znamenatel = Math.Abs(b);
        }

        //Нахождение делителей числа
        public List<int> DelitelOfNum(int num)
        {
            List<int> deliteli = new List<int>();
            while (num != 1)
            {
                for (int i = 2; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        num = num / i;
                        deliteli.Add(i);
                        break;
                    }
                }
            }
            return deliteli;
        }

        public override string ToString()
        {
            if (chislitel == 0)
                return "0";
            else
            {
                List<int> delOfZnamenatel = DelitelOfNum(znamenatel);
                foreach(var del in delOfZnamenatel)
                {
                    if(chislitel%del == 0)
                    {
                        chislitel = chislitel / del;
                        znamenatel = znamenatel / del;
                    }
                }
                int fullpart = chislitel / znamenatel;
                if (fullpart == 0)
                    return (znak + (chislitel - znamenatel * fullpart).ToString() + "/" + znamenatel.ToString());
                else if (chislitel - znamenatel * fullpart == 0)
                    return (znak + fullpart.ToString());
                else return (znak+ fullpart.ToString()+" "+(chislitel - znamenatel*fullpart).ToString()+"/"+znamenatel.ToString());
            }
            
        }

        //Исключение общих делителей из двух чисел
        //public (int num1, int num2) Reduction(int num1, int num2)
        //{
        //    List<int> deliteli1 = DelitelOfNum(num1);
        //    List<int> deliteli2 = DelitelOfNum(num2);
        //    foreach (var del1 in deliteli1)
        //    {
        //        foreach (var del2 in deliteli2)
        //        {
        //            if (del1 == del2 && del1!=num1 &&del2!=num2)
        //            {
        //                num1 = num1 / del1;
        //                num2 = num2 / del1;
        //            }
        //        }
        //    }

        //    return (num1, num2);
        //}

        //public int NOD(int znam1, int znam2)
        //{
        //    int NOD = 1;
        //    List<int> deliteli1 = DelitelOfNum(znam1);
        //    List<int> deliteli2 = DelitelOfNum(znam2);
        //    foreach (var del1 in deliteli1)
        //    {
        //        foreach (var del2 in deliteli2)
        //        {
        //            if (del1 == del2 && del1>NOD)
        //            {
        //                NOD = del1;
        //            }
        //        }
        //    }
        //    return NOD;
        //}

        //public int NOK(int znam1, int znam2)
        //{
        //    var ZnamList = Reduction(znam1, znam2);
        //    return ZnamList.num1 * ZnamList.num2;
        //}

        public string Plus(Drobi d)
        {
            Drobi result = new Drobi();
            List<int> deliteli1 = DelitelOfNum(znamenatel);
            List<int> deliteli2 = DelitelOfNum(d.znamenatel);
            result.znamenatel = d.znamenatel;
            int chislitel2 = d.chislitel;
            int chislitel1 = chislitel;
            foreach (int del in deliteli1) {
                result.znamenatel = result.znamenatel*del;
                chislitel2 = chislitel2 * del;
            }
            foreach (int del in deliteli2)
            {
                chislitel1 = chislitel1 * del;
            }
            result.chislitel = chislitel1 *(Convert.ToInt32(znak + "1")) + chislitel2 * (Convert.ToInt32(d.znak + "1"));
            if (result.chislitel>=0)
                result.znak = "+";
            else result.znak = "-";
            result.chislitel = Math.Abs(result.chislitel);

            result.ToString();

            return result.ToString(); 
        }

        public string Minus(Drobi d)
        {
            Drobi result = new Drobi();
            List<int> deliteli1 = DelitelOfNum(znamenatel);
            List<int> deliteli2 = DelitelOfNum(d.znamenatel);
            result.znamenatel = d.znamenatel;
            int chislitel2 = d.chislitel;
            int chislitel1 = chislitel;
            foreach (int del in deliteli1)
            {
                result.znamenatel = result.znamenatel * del;
                chislitel2 = chislitel2 * del;
            }
            foreach (int del in deliteli2)
            {
                chislitel1 = chislitel1 * del;
            }
            result.chislitel = chislitel1 * (Convert.ToInt32(znak + "1")) - chislitel2 * (Convert.ToInt32(d.znak + "1"));
            if (result.chislitel >= 0)
                result.znak = "+";
            else result.znak = "-";
            result.chislitel = Math.Abs(result.chislitel);

            return result.ToString();
        }

        public string Multy(Drobi d)
        {
            Drobi result = new Drobi();
            result.chislitel = chislitel * d.chislitel;
            result.znamenatel = znamenatel * d.znamenatel;
            if ((znak.Equals("+") && d.znak.Equals("+")) || (znak.Equals("-") && d.znak.Equals("-")))
                result.znak = "+";
            else result.znak = "-";
            return result.ToString();
        }

        public string Division(Drobi d)
        {
            Drobi result = new Drobi();
            result.chislitel = chislitel * d.znamenatel;
            result.znamenatel = znamenatel * d.chislitel;
            if ((znak.Equals("+") && d.znak.Equals("+")) || (znak.Equals("-") && d.znak.Equals("-")))
                result.znak = "+";
            else result.znak = "-";
            return result.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числитель первого числа");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первого числа");
            int b = Convert.ToInt32(Console.ReadLine());
            Drobi drob1 = new Drobi(a, b);

            Console.WriteLine("Введите числитель второго числа");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель второго числа");
            b = Convert.ToInt32(Console.ReadLine());
            Drobi drob2 = new Drobi(a, b);

            Console.WriteLine("Plus: "+drob1.Plus(drob2));
            Console.WriteLine("Minus: " + drob1.Minus(drob2));
            Console.WriteLine("Multy: " + drob1.Multy(drob2));
            Console.WriteLine("Division: " + drob1.Division(drob2));

            Console.WriteLine(drob1.Drob);
        }
    }
}
