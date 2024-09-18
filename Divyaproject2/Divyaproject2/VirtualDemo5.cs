using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5th_Sem_Bhumika
{
    class vehicle
    {
        public double distance = 0.0;
        public double hour = 0.0;
        public double fuel = 0.0;

        public vehicle(double d, double h, double f)
        {
            distance = d;
            hour = h;
            fuel = f;


        }
        public virtual void Average()
        {
            double average = 0.0;
            average = distance / fuel;
            Console.WriteLine("vehicle average is {0:00}", average);
        }
        public virtual void Speed()
        {
            double speed = 0.0;
            speed = distance / hour;
            Console.WriteLine("vehicle speed is{0:00}", speed);

        }
    }
    class Car : vehicle
    {
        bool isFourWheel;
        public Car(double d, double h, double f, bool ifw) : base(d, h, f)
        {
            isFourWheel = ifw;
        }
        public override void Average()
        {
            double average = 0.0;
            average = distance / fuel;
            Console.WriteLine("Car Average is{0:0.00}", average);

        }
        public override void Speed()
        {
            double speed = 0.0;
            speed = distance / hour;
            Console.WriteLine("car speed is {0:0.00}", speed);

        }
    }
    internal class VirtualMethodDemo
    {
        /*static void Main(string[] args)
        {
           // Vehicle v= new Vehicle(450,5,15);
             //v.Average ();
            //v.Speed();
            Car c = new Car(450, 5, 15, true);
            c.Average();
            c.Speed();
            Console.ReadKey();

        }*/

    }


}