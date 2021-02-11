#region Автор
//Анна Сафонова
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
//Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
//В данной задаче под парой подразумевается два подряд идущих элемента массива. 
//Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.

namespace урок4GeekBrains
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -10000, -9, -6,- 8, -7, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 9, 9000,8 };
            int count = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                if ((arr[i + 1] % 3 == 0 || arr[i] % 3 == 0) && arr[i + 1]!=0 && arr[i] != 0)
                    count++;

            }

            Console.WriteLine("Кол-во пар: "+count);
        }
    }
}
