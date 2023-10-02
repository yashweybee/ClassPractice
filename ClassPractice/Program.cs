using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            //s1.id = 100;
            //s1.name = "abcd";

            s1.init(1, "Yash");
            s2.init(2, "Ravi");
            s1.display();
            s2.display();
            
            Console.ReadLine();
        }
    }

    public class Student
    {
        public int id;
        public string name;
    public void init(int id , string name)
        {
            this.id = id;
            this.name = name;
        }
    
        public void display()
        {
            Console.WriteLine(this.id + " "+ this.name);
        }
    }
}
