using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayofObject
{
    class Program
    {
        static int i;

        static void Main(string[] args)
        {
            students[] s = new students[5];
            //for (int i = 0; i < s.Lengts; i++)
            //    s[i] = new students[5];
            Console.WriteLine(s.Length);
            for (i = 0; i < s.Length; i++)
                s[i].getvals();

            for (i = 0; i < s.Length; i++)
                s[i].display();
        }
    }
    class students
    {
        private int rno, marks;
        private string sname;
        public void getvals()
        {
            Console.WriteLine("enter roll no of student...");
            rno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name of student...");
            sname = Console.ReadLine();
            Console.WriteLine("enter marks of student...");
            marks = int.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("roll no = " + rno + "stu name = " + sname + "marks = " + marks);
        }
    }
    }

