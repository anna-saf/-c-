using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Задача2
{
    class WorkToMassiv
    {
        double[] arr;
        const int size = 10;
        const int step = 3;
        public double Sum
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
        }

        public int MaxCount
        {
            get
            {
                return (from item in arr where item == arr.Max() select item).Count();
            }
        }

        public WorkToMassiv(double[] arr) { this.arr = arr; }

        public WorkToMassiv(int a)
        {
            arr = new double[size];
            for (int i = 0; i < size; i++)
                arr[i] = a + step * i;
        }

        public WorkToMassiv()
        {
            arr = ReadFile();
        }

        public void Inverse()
        {
            for (int i = 0; i < size; i++)
            {
                arr[i] = arr[i] * (-1);
            }
        }

        public void Multy(int a)
        {
            for (int i = 0; i < size; i++)
            {
                arr[i] = arr[i] * a;
            }
        }

        public static double[] ReadFile()
        {
            List<double> list = new List<double>();
            StreamReader str = new StreamReader("data.txt");

            while (!str.EndOfStream) 
            {
                list.Add(double.Parse(str.ReadLine()));
            }

            str.Close();

            return list.ToArray();
        }

        public void WriteFile()
        {
            using (StreamWriter str = new StreamWriter("dataoutput.txt"))
            {
                foreach (double item in arr)
                {
                    str.WriteLine(item.ToString()+" ");
                }
            }
        }

        public override string ToString()
        {
            string str = "";
            foreach (int item in arr)
                str = str + item.ToString() + " ";
            return str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[] { 1, 2, 3, 3 };
            WorkToMassiv mass1 = new WorkToMassiv(arr);
            WorkToMassiv mass2 = new WorkToMassiv(-5);

            Console.WriteLine(mass1.MaxCount);
            Console.WriteLine(mass1.Sum);
            mass2.Multy(2);
            Console.WriteLine(mass2.ToString());
            mass2.Inverse();
            Console.WriteLine(mass2.ToString());

            WorkToMassiv mass3 = new WorkToMassiv();
            mass3.WriteFile();
        }
    }
}
