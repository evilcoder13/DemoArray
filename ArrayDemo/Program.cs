using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentNames = new string[5];
            studentNames[0] = "Thang";
            studentNames[1] = "Thanh";
            studentNames[2] = "Trang";
            studentNames[3] = "Ha";
            studentNames[4] = "Huyen";
            foreach (string s in studentNames)
                Console.WriteLine(s);
            Console.ReadLine();

            string[] students = { "Thang", "Thanh", "Trang", "Ha", "Huyen" };
            for (int i = 0; i < students.Length; i++)
                Console.WriteLine(i+":"+students[i]);
            Console.ReadLine();

            string[,] studentInfos = new string[5, 2];
            studentInfos[0, 0] = "Thang";
            studentInfos[0, 1] = "10A";
            studentInfos[1, 0] = "Thanh";
            studentInfos[1, 1] = "10B";
            studentInfos[2, 0] = "Hoang";
            studentInfos[2, 1] = "10C";
            studentInfos[3, 0] = "Trang";
            studentInfos[3, 1] = "10A";
            studentInfos[4, 0] = "Huyen";
            studentInfos[4, 1] = "10C";
            for (int i = 0; i < 5; i++)
                DisplayStudentInfo(studentInfos[i, 0], studentInfos[i, 1]);
            DisplayStudentInfo("test");
            Console.WriteLine(ExtendedMath1.Class1.Add(5, 10));
            Console.ReadLine();

        }

        static void DisplayStudentInfo(string name, string classname="Waiting")
        {
            Console.WriteLine("Ten: " + name + " - Lop: " + classname);
        }
    }
}
