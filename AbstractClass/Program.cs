using System;

namespace Inheritance
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;
        public abstract void SayName();
    }

    public class Employee : Person, IQuittable
    {
        public int Id = 0;
        public override void SayName()
        {
            Console.WriteLine("Employee Name: " + FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine("Employee " + Id + " quit");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employee();
            employee.Quit();
        }
    }
}
