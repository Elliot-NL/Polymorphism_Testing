using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_File___Polymorphism2
{
    class Program
    {
        //Two Types of Polymorphism - Static & Dynamic
        //Functions in Static Polymorphism are defined at Compile time
        //Functions in Dynamic Polymorphism are defined at Run time
        //Static Polymorphism 
        class PrintData
        {
            public void print(int i)
            {
                Console.WriteLine("The integer value is: " + i);
            }
            public void print(float a)
            {
                Console.WriteLine("The float value is:" + a);
            }
            public void print(string a)
            {
                Console.WriteLine("The string value is:" + a);
            }
        }
        //Dynamic Polymorphism
        class Shape
        {
            protected int width, height;
            public Shape(int w = 0, int h = 0)
            {
                width = w;
                height = h;
            }
            public virtual int area()
            {
                Console.WriteLine("This is the base class");
                return 0;
            }

        }
        class Rectangle : Shape
        {

            public Rectangle(int w = 0, int h = 0) : base(w, h)
            {

            }
            public override int area()
            {
                Console.WriteLine("The area of the rectangle is :");
                return (width * height);
            }
            class Triangle : Rectangle
            {
                public Triangle(int w = 0, int h = 0) : base(w, h)
                {

                }
                public override int area()
                {
                    Console.WriteLine("The Area of the Triangle is :");
                    return (width * height / 2);
                }
            }
            class Caller
            {
                public void CallArea(Shape sh)
                {
                    int a;
                    a = sh.area();
                    Console.WriteLine("Area: {0}", a);
                }
            }

            class Tester
            {
                
                static void Main(string[] args)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    PrintData pd = new PrintData();
                    //Static Polymorphism calls
                    /*
                    pd.print(8);
                    pd.print(5.5f);
                    pd.print("Test");
                    Console.ReadLine();
                    */
                    //Dynamic Polymorphism calls
                    Caller cl = new Caller();
                    Rectangle rt = new Rectangle(5, 6);
                    Triangle tr = new Triangle(5, 4);
                    cl.CallArea(rt);
                    cl.CallArea(tr);
                    Console.ReadLine();

                }
            }
        }
    }
}
