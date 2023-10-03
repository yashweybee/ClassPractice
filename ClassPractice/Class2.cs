using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class Class2
    {
        public static void Main(string[] args)
        {
            Person2 c1 = new Customer2();
            PersonI c2 = new Customer2();
            c2.eating();
            c1.getName();


            ns.Car car1 = new ns.Car();
            Console.WriteLine(car1.color);

            Console.ReadLine();
        }
    }
    public interface PersonI
    {
        void eating();
        //void running();
    }
    public abstract class Person2
    {
        public abstract void getName();
        public abstract void getAge();
    }
    public class Customer2 : Person2, PersonI
    {
        public override void getName()
        {
            Console.WriteLine("Customer name");
        }
        public override void getAge()
        {
            Console.WriteLine(678);
        }

        public void eating()
        {
            Console.WriteLine("Customer Eating....");
        }

    }
}

namespace ns
{
    public class Car
    {
        public int wheels = 4;
        public string color = "black";
    }
}