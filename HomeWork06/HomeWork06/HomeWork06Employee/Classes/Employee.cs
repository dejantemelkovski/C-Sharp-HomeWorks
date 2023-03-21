using HomeWork06Employee.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HomeWork06Employee.Classes
{
    public class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Role Role { get; }
        protected double Salary { get; }

        public Employee(string firstName, string lastName, Role role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}, ${Salary:N2}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }

}
