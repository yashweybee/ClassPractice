using System;

namespace ClassPractice
{
    class Program
    {

        public enum Colors { black = 10, white, red, yellow };
        //public static int[] createArray(int num1 , int num2)
        //{
        //    return new int[]{ num1, num2};
        //}

        //public static string[] createArray(string num1, string num2)
        //{
        //    return new string[] { num1, num2 };
        //}

        public static T[] createArray<T>(T num1, T num2)
        {
            return new T[] { num1, num2 };
        }

        static void Main(string[] args)
        {
            //int[] myArr = createArray(10, 20);
            //string[] myArr2 = createArray("adf", "qwer");
            //Console.WriteLine(myArr2[0]);

            int[] intArr = createArray<int>(88,66);
            string[] strArr = createArray<string>("qwer", "asdf");
            Console.WriteLine(strArr[1].GetType());

            //Student s1 = new Student(1, "Yash");
            //Student s2 = new Student(2, "Miral");
            //Student s3 = new Student(3, "Ravi");


            //Console.WriteLine(s1.getMarks(10 , 20.89f));

            //s1.id = 100;
            //s1.name = "abcd";

            //s1.init(1, "Yash");
            //s2.init(2, "Ravi");

            //s1.display();
            //s2.display();

            //Student.changeSchoolName("SOS");

            //s1.display();
            //s2.display();

            //Console.WriteLine(Customer.getId());


            //Rectangle rec1 = new Rectangle(10, 20);
            //rec1.getArea();

            //int color1 = (int)Colors.black;
            //int color2 = (int)Colors.yellow;
            //Console.WriteLine(color1);

            //Colors myColor = Colors.white;
            //Console.WriteLine(myColor);

            //Address a1 = new Address("abcd socity", "Rajkot", "23749");

            //Teacher t1 = new Teacher(123, "abcs", a1);
            //Student s1 = new Teacher(345, "qwer", a1);
            //s1.work();


            //Person ps1 = new Student(111, "yash");
            //Person pt1 = new Teacher(109, "aghd", a1);
            //ps1.eating();
            //pt1.eating();


            //Console.WriteLine(t1.getName());
            //t1.getName();
            //t1.work();
            //s1.work();

            //t1.myStudent();
            //Console.WriteLine(t1.address.pincode);


            //Console.WriteLine(typeof(string) == "YAsh".GetType());
            //Console.WriteLine("YAsh".GetType());

            //float num = 99.80f;
            //int num2 = (int)num;
            //Console.WriteLine(num2.GetType());

            Console.ReadLine();
        }
    }

    public abstract class Person
    {
        public abstract void eating();
    }

    public class Student : Person
    {
        public int id;
        public string name = "Gandhi";
        public int mathMark = 42;
        public int sciMark = 50;
        public int engMark = 35;
        public static string schoolName = "Dholakiya";
        public static int count = 0;


        public Student() { }
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
            count++;
        }

        public override void eating()
        {
            Console.WriteLine("student eating");
        }


        public void display()
        {
            Console.WriteLine(this.id + " " + this.name + " " + schoolName);
        }

        public static void changeSchoolName(string sName)
        {
            schoolName = sName;
        }

        static Student()
        {
            Console.WriteLine("static cons Student");
        }

        public void getName()
        {
            Console.WriteLine(this.name);
        }

        public virtual void work()
        {
            Console.WriteLine("Studying");
        }


        //public void init(int id , string name)
        //    {
        //        this.id = id;
        //        this.name = name;
        //    }

        public int getMarks(int math, int sci)
        {
            return math + sci;
        }
        public float getMarks(int math, float sci)
        {
            return math + sci;
        }

        public int getMarks(int math, int sci, int eng)
        {
            return math + sci + eng;
        }

    }


    public class Teacher : Student
    {
        public int id;
        public string name;
        public Address address;

        public Teacher() { }
        public Teacher(int id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public override void eating()
        {
            Console.WriteLine("Teacher eating");
        }

        public void myStudent()
        {
            Console.WriteLine("my student : " + base.name);
            Console.WriteLine("my student school : " + schoolName);
        }

        public override void work()
        {
            Console.WriteLine("Teaching...");
            Console.WriteLine("Time passing with colleagues");
        }
    }
    public class Address
    {
        public string addressLine, city, pincode;

        public Address() { }
        public Address(string addressLine, string city, string pincode)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.pincode = pincode;
        }

    }
    static class Customer
    {
        static int id = 999;

        public static int getId()
        {
            return id;
        }
    }

    public struct Rectangle
    {
        public int width;
        public int height;

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public void getArea()
        {
            Console.WriteLine("Area: " + width * height);
        }
    }


}

