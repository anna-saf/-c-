using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> questions = new List<string>();
            StreamReader text = new StreamReader("data.txt");
            while (!text.EndOfStream)
            {
                questions.Add((text.ReadLine()));
            }

            Random rand = new Random();
            int rightAnswer = 0;
            int num=0;
            List<int> useRandomNum = new List<int>();
            for (int i = 0; i < 11; i++)
            {
                bool unicRandom = false;
                while (!unicRandom)
                {
                    unicRandom = true;
                    num = rand.Next(0, questions.Count);
                    foreach (int number in useRandomNum)
                    {
                        if (num == number)
                        {
                            unicRandom = false;
                            break;
                        }
                    }
                    if (unicRandom)
                        useRandomNum.Add(num);
                }
                Console.WriteLine(questions[num].Split('-')[0].Trim()+ " (1 - Да, любой другой символ - Нет)");
                string answer = Console.ReadLine();
                if (answer.Equals("1"))
                {
                    if (questions[num].Split('-')[1].Trim().ToLower().Equals("да"))
                        rightAnswer++;
                }
                else if (questions[num].Split('-')[1].Trim().ToLower().Equals("нет"))
                    rightAnswer++;
            }
            Console.WriteLine("Количество правильных ответов: " + rightAnswer);
            Console.ReadKey();
        }
    }
}
