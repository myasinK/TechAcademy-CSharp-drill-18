using System;

namespace Inheritance
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;
        public abstract void SayName();
    }

    public class Employee : Person
    {
        public int Id = 0;
        public override void SayName()
        {
            Console.WriteLine("Employee Name: " + FirstName + " " + LastName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
        }
    }
}
