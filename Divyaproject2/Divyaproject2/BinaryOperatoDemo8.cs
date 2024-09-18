using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _5th_Sem_Bhumika
{
    class BExample
    {
        public int number;

        public BExample()
        {
        }
        public BExample(int a)
        {
            number = a;

        }
        public static BExample operator +(BExample a, BExample b)
        {
            BExample c = new BExample();
            c.number = a.number + b.number;
            return c;
        }
        public void PrintNumber()
        {
            Console.WriteLine(number);
        }
    }
    internal class operatorOverloadingDemo
    {
        /*static void Main(string[] args)

        {
            BExample be1 = new BExample(56);
            BExample be2 = new BExample(20);
            BExample be3 = new BExample();
            be3 = be1 + be2;
            Console.WriteLine("Result after using Binary (+) operator");
            be3.PrintNumber();
            Console.ReadKey();

        }*/
    }
}