using HomeWork06Employee.Classes;
using HomeWork06Employee.Enums;
using System.Data;

namespace HomeWork06Employee
{
    public class Bonus
    {
        class Program
        {
            static void Main()
            {
                Employee employee = new Employee("Dejan", "Temelkovski", Role.Other, 40000.00);
                employee.PrintInfo();
                Console.WriteLine("==========================");

                SalesPerson salesPerson = new SalesPerson("Jane", "Doe", 3000.00);
                salesPerson.AddSuccessRevenue(1500.00);
                double salaryWithBonus = salesPerson.GetSalary();
                salesPerson.PrintInfo();
                Console.WriteLine($"Salary with bonus: {salaryWithBonus:C}");
                Console.WriteLine("==========================");


                Manager manager = new Manager("John", "Doe", Role.Manager, 60000.00);
                manager.AddBonus(5000.00);
                salaryWithBonus = manager.GetSalary();
                manager.PrintInfo();


            }
        }
    }
}