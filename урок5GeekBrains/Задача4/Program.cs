using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача4
{
    class Student
    {
        public string name;
        public string surname;
        public int[] marks;
        public int marksSum = 0;

        public Student() { }

        public Student (string name, string surname, int[] marks)
        {
            this.name = name;
            this.surname = surname;
            this.marks = marks;
        }

        public void MarksSum()
        {
            foreach(int mark in marks)
            {
                marksSum = marksSum + mark;
            }            
        }

        public static void Sort(ref List<Student> students)
        {
            Student a = new Student();
            for (int i = 0; i < students.Count; i++) 
            {
                for (int j = 0; j < students.Count - 1; j++) 
                {
                    if (students[j].marksSum > students[j+1].marksSum)
                    {
                        a = students[j];
                        students[j] = students[j+1];
                        students[j+1] = a;
                    }
                }  
            }
        } 
        public override string ToString()
        {
            string markStr = "";
            foreach(int mark in marks)
            {
                markStr = markStr + mark + " ";
            }
            return name + " " + surname + " " + markStr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            StreamReader text = new StreamReader("data.txt");
            int count = Convert.ToInt32(text.ReadLine());
            
            for (int i = 0; i < count; i++)
            {
                string row = text.ReadLine();
                int[] marks = { Convert.ToInt32(row.Split(' ')[2]), Convert.ToInt32(row.ToString().Split(' ')[3]), Convert.ToInt32(row.Split(' ')[4])};
                students.Add(new Student(row.Split(' ')[0], row.Split(' ')[1], marks));
                students[i].MarksSum();
            }

            Student.Sort(ref students);

            int n = 0;
            foreach(Student student in students)
            {
                if (n < 3) 
                {
                    Console.WriteLine(student.ToString());
                    n++;
                    continue;
                }else if (student.marksSum == students[n - 1].marksSum)
                {
                    Console.WriteLine(student.ToString());
                    n++;
                    continue;
                }

            }
            Console.ReadKey();
        }
    }
}
