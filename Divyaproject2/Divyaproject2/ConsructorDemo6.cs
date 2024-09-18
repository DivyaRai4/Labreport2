using System;

namespace PKMC2078Unit3
{
    public class ConstructorDemo
    {
        int a, b;
        public ConstructorDemo()
        {
            a = 200;
            b = 300;
            Console.WriteLine("This is Default Constructor");
        }

        //parameterized constructor
        public ConstructorDemo(int x, int y)
        {
            a = x;
            b = y;
        }

        public ConstructorDemo(ConstructorDemo cd)
        {
            a = cd.a;
            b = cd.b;
        }

        static ConstructorDemo()
        {
            Console.WriteLine("This is static constructor");
        }

        ~ConstructorDemo()
        {
            Console.WriteLine("I am destroyed");
            Console.ReadKey();
        }

        public void Deconstruct(out int p, out int q)
        {
            p = a;
            q = b;
        }
        /*  static void Main(string[] args)
          {
              //default
              ConstructorDemo demo = new ConstructorDemo();
              Console.WriteLine(demo.a);
              Console.WriteLine(demo.b);

              //parameterized
              ConstructorDemo cdemo  = new ConstructorDemo(450,120);
              Console.WriteLine(cdemo.a);
              Console.WriteLine(cdemo.b);
              //copy 
              ConstructorDemo cpdemo = new ConstructorDemo(cdemo);
              (int m, int n) = cpdemo;
              Console.WriteLine(m);
              Console.WriteLine(n);

              Console.WriteLine("This is demo for constructor");
              Console.ReadKey();
          }*/

    }

}
