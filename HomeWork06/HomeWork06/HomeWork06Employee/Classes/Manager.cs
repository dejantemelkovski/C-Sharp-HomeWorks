using HomeWork06Employee.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork06Employee.Classes
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager(string firstName, string lastName, Role role, double salary)
            : base(firstName, lastName, role, salary)
        {
            Bonus = 0;
        }

        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}, ${Salary:N2} (Bonus: ${Bonus:N2})");
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }

}
