using System;

namespace Divyaproject2
{
   
    class Employee
    {
        
        private string name;
        private string email;
        private decimal salary;

        public Employee(string name, string email, decimal salary)
        {
            this.name = name;
            this.email = email;
            this.salary = salary;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Salary: " + salary);
        }
    }

    class Program
    {
        /*static void Main(string[] args)
        {
            Employee employee1 = new Employee("Divya Rai", "deevyarai4@gmail.com", 20000);

            
            employee1.DisplayEmployeeDetails();

            Console.ReadLine();
        }*/
    }
}
