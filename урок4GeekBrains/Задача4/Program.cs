using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача4
{
    class Massiv
    {
        int[,] arr;
        int a;
        int b;

        public int Max
        {
            get
            {
                int max = int.MinValue;
                for (int i = 0; i < a; i++)
                    for (int j = 0; j < b; j++)
                        if (arr[i, j] > max) { max = arr[i, j]; }
                return max;
            }
        }

        public int Min
        {
            get
            {
                int min = int.MaxValue;
                for (int i = 0; i < a; i++)
                    for (int j = 0; j < b; j++)
                        if (arr[i, j] < min) { min = arr[i, j]; }
                return min;
            }
        }

        public Massiv(int a, int b)
        {
            this.a = a;
            this.b = b;
            arr = new int[a, b];
            var rand = new Random();
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    arr[i, j] = rand.Next(-100, 100);
        }

        public Massiv()
        {
            arr = ReadFile(out a, out b);
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    sum += arr[i, j];
            return sum;
        }

        public int Sum(int x, int y)
        {
            int sum = 0;
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    if (x < a && y < b)
                    {
                        if (arr[i, j] > arr[x, y])
                            sum += arr[i, j];
                    }
                    else Console.WriteLine("Элемент с индексами "+x+", "+y+" в массиве не существует");

            return sum;
        }

        public void MaxIndex(int max, out int maxIndex)
        {
            maxIndex = 0;
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    if (arr[i,j] == max)
                    {
                        maxIndex = (i+1) * (j+1);
                        i = a;
                        break;
                    }

        }

        public static int[,] ReadFile(out int a, out int b)
        {
            a = 0;
            b = 0;
            int[,] arr;
            StreamReader str = new StreamReader("data.txt");
            string filedata = str.ReadToEnd();

            string[] rows = filedata.Split(',');
            a = rows.Length;
            b = rows[0].Split(' ').Length;
            arr = new int[a, b];

            int i = 0;
            foreach (string item in rows)
            {
                int j = 0;
                foreach(string num in item.Split(' '))
                {
                    arr[i, j] = Convert.ToInt32(num);
                    j++;
                }
                i++;
            }
            str.Close();

            return arr;
        }

        public void WriteFile()
        {
            using (StreamWriter str = new StreamWriter("dataoutput.txt"))
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        str.Write(arr[i, j]);
                    }
                    str.WriteLine(",");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Massiv massiv1 = new Massiv(2, 3);
            Massiv massiv2 = new Massiv();

            Console.WriteLine(massiv2.Min);
            Console.WriteLine(massiv2.Max);
            Console.WriteLine(massiv2.Sum());
            Console.WriteLine(massiv2.Sum(1, 2));
            int maxindex;
            massiv2.MaxIndex(massiv2.Max, out maxindex);
            Console.WriteLine(maxindex);
            massiv1.WriteFile();

        }
    }
}
