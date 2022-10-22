using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchingandsorting = @"E:\NET\SearchAndSort\StudentInfo.txt";
            FileStream file = new FileStream(searchingandsorting, FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(file);
            List<Student> list = new List<Student>();
            while (!read.EndOfStream)
            {
                string k = read.ReadLine();
                char[] c = new char[]
               { ' ', '\t' };
                string[] stu = k.Split(c, StringSplitOptions.None);
                Student S = new Student();
                S.Name = stu[0];
                S.Class = Convert.ToInt32(stu[1]);
                list.Add(S);
            }
            read.Close();
            file.Close();
            file.Dispose();
            file.Dispose();

        start:
            Console.Write(" 1 sort by class\n 2 sort by Name\n 3.search through Name\n 4.search through class\n 5.Display the Info of Students\n");
            Console.WriteLine("Enter the number");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("sort by class");
                    var par = list.OrderBy(q => q.Class).ToList();
                    foreach (Student s in par)
                    {
                        Console.Write($"{s.Name}  is studying in {s.Class}\n");
                    }
                    Console.WriteLine("-----------------------");
                    break;

                case 2:
                    Console.WriteLine("sort by Name");
                    var par1 = list.OrderBy(q => q.Name).ToList();
                    foreach (Student s in par1)
                    {
                        Console.Write($"{s.Name} is studying in {s.Class}\n");
                    }
                    Console.WriteLine("-----------------------");
                    break;
                case 3:
                    Console.WriteLine("search through Name");
                    foreach (Student s in list)
                    {
                        Console.Write($"{s.Name} is studying in {s.Class} \n");
                    }
                    Console.WriteLine("Enter the name you want to search");
                    string pr = Console.ReadLine();
                    var pit = list.Where(q => q.Name == pr).ToList();
                    if (pit != null)
                    {
                        foreach (Student s in pit)
                        {
                            Console.Write($"{s.Name} is studying in {s.Class} \n");
                        }

                    }
                    else
                    {
                        Console.WriteLine("sorry nothing to search......");
                    }
                    Console.WriteLine("-----------------------");
                    break;
                case 4:
                    Console.WriteLine("Search through Class");
                    foreach (Student s in list)
                    {
                        Console.Write($"{s.Name} studying in {s.Class} \n");
                    }
                    Console.WriteLine("Enter Class you want to search");
                    int pr1 = Convert.ToInt32(Console.ReadLine());
                    var pit1 = list.Where(q => q.Class == pr1).ToList();
                    if (pit1 != null)
                    {
                        foreach (Student s in pit1)
                        {
                            Console.Write($"{s.Name} is studying in {s.Class}\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine("No students in Class");
                    }
                    Console.WriteLine("-----------------------");
                    break;
                case 5:
                    Console.WriteLine("Display");
                    foreach (Student s in list)
                    {
                        Console.Write($"{s.Name} studying in {s.Class}  \n");
                    }
                    Console.WriteLine("-----------------------");
                    break;
            }
            Console.WriteLine("Type Enter to Continue");
            string pnt = Console.ReadLine();
            if (pnt == "Enter")
            {
                goto start;
            }
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public int Class { get; set; }
    }

}
    

