using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class AccessModifires 
    {
        public static void Main(string[] args)
        {

            //TestPerson2 t2 = new TestPerson2();
            //Console.WriteLine(t2.age);
            //TestPerson3 p3 = new TestPerson3();


            //TestPerson4 p4 = new TestPerson4();

            //p3.greeting();
            //Console.WriteLine(p4.age + p4.name);

            //AccessModifires t1 = new AccessModifires();
            //t1.asalary = t1.salary;

            //t1.work();
            //Console.WriteLine(t1.salary);
            //t1.getSalary();
            //Console.WriteLine(t1.asalary);


            DemoEncap demo1 = new DemoEncap();

            Console.WriteLine(demo1.Name);
            demo1.Name = "Yash";
            Console.ReadLine();
        }
    }

    class TestPerson
    {
        public int age = 80;
        protected int salary = 70000;
        private int codeNum = 656;
        public void work()
        {
            Console.WriteLine("Working...");
        }

        public void getSalary()
        {
            Console.WriteLine("Sal: " + salary);
        }
    }
    class TestPerson2 : TestPerson
    {
        protected int asalary;
        public TestPerson2()
        {
            TestPerson2 tp1 = new TestPerson2();
            asalary = tp1.salary;
        }
    }

    class TestPerson3
    {
        internal string name = "yash";
        internal void greeting()
        {
            Console.WriteLine("Hello" + name);
        }
    }
    class TestPerson4 
    {
        protected internal int age =90;
        internal string name = "abcd";
        //public TestPerson4()
        //{
        //    Console.WriteLine(name);
        //}
    }

    class DemoEncap
    {
        private int myAge;
        private string myName;


        public string Name
        {
            get { return myName; }

            set { myName = value; }
        }
    }
}
