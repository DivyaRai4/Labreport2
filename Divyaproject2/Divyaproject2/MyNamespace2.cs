using System;
namespace Divyaproject2
{

    public class Person
    {
       
        public string Name;
        public int Age;

        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

       
        public void DisplayInfo()
        {
           System.Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
