using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace урок3GeekBrains
{
    struct ComplexStruct
    {
        public double im;
        public double re;

        public ComplexStruct Plus(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public ComplexStruct Minus (ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public ComplexStruct Multi(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class ComplexClass {

        private double im;
        private double re;
        public double Im
        {
            get
            {
                return im;
            }
            set
            {
                im = value;
            }
        }
        public double Re
        {
            get
            {
                return re;
            }
            set
            {
                re = value;
            }
        }


        public ComplexClass()
        {
        }

        public ComplexClass(double im, double re )
        {
            this.im = im;
            this.re = re;
        }

        public ComplexClass Plus(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public ComplexClass Multi(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        public override string ToString()
        {
            return re + "+" + im + "i";
        }

    } 
    class Program
    {
        static void Main(string[] args)
        {
            ComplexClass complexClass1 = new ComplexClass();
            complexClass1.Im = 1;
            complexClass1.Re = 1;

            ComplexClass complexClass2 = new ComplexClass();
            complexClass2.Im = 2;
            complexClass2.Re = 2;

            ComplexStruct complexStruct1;
            complexStruct1.re = 1;
            complexStruct1.im = 1;

            ComplexStruct complexStruct2;
            complexStruct2.re = 2;
            complexStruct2.im = 2;

            //ComplexStruct resultstruct = complexStruct1.Plus(complexStruct2);
            //Console.WriteLine(resultstruct.ToString());
            //resultstruct = complexStruct1.Multi(complexStruct2);
            //Console.WriteLine(resultstruct.ToString());
            //resultstruct = complexStruct1.Minus(complexStruct2);
            //Console.WriteLine(resultstruct.ToString());
            bool EndProcess = false;
            do
            {
                Console.WriteLine("Выберите операцию над числами" + Environment.NewLine + "1) Сложение" + Environment.NewLine + "2) Умножение");
                int num;
                ComplexClass resultClass = new ComplexClass();
                bool GoodChoice;

                do
                {
                    GoodChoice = int.TryParse(Console.ReadLine(), out num);
                    if (GoodChoice)
                    {
                        switch (num)
                        {
                            case 1:
                                resultClass = complexClass1.Plus(complexClass2);
                                Console.WriteLine(resultClass.ToString());
                                break;
                            case 2:
                                resultClass = complexClass1.Multi(complexClass2);
                                Console.WriteLine(resultClass.ToString());
                                break;
                            default:
                                Console.WriteLine("Введены неверные данные. Пожалуйста, выберите операцию путем ввода цифр 1 или 2");
                                GoodChoice = false;
                                break;
                        }
                    }
                    else Console.WriteLine("Введены неверные данные. Пожалуйста, выберите операцию путем ввода цифр 1 или 2");
                } while (!GoodChoice);

                Console.WriteLine("Желаете продолжить" + Environment.NewLine + "1 - Да" + Environment.NewLine + "Любой другой символ - Нет");
                string Choice = Console.ReadLine();
                EndProcess = Choice.Equals("1") ? false : true;
            } while (!EndProcess);
        }
    }
}
