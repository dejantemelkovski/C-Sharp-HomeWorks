using System;
using System.Collections.Generic;

namespace Homework05.Classes
{
    public class ATM
    {
        public void Run()
        {
            Console.WriteLine("Welcome to the ATM app");
            Console.WriteLine("Please enter your card number:");
            string cardNumber = Console.ReadLine();

            Console.WriteLine("Enter Pin:");
            int pin;
            bool isPinParsed = int.TryParse(Console.ReadLine(), out pin);

            Customer customer = FindCustomer(cardNumber, pin);

            if (customer != null)
            {
                Console.WriteLine($"Welcome {customer.FirstName} {customer.LastName}!");
                Console.WriteLine("What would you like to do:");
                Console.WriteLine("1.Check Balance");
                Console.WriteLine("2.Cash Withdrawal");
                Console.WriteLine("3.Cash Deposit");
                Console.WriteLine("4.Create New Account");
                Console.WriteLine("5.Exit");

                int choice;
                bool isChoiceParsed = int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Your current balance is {customer.Balance}$");
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to withdraw:");
                        double amount;
                        bool isAmountParsed = double.TryParse(Console.ReadLine(), out amount);

                        if (isAmountParsed)
                        {
                            Account account = new Account();
                            if (account.Withdraw(amount, customer.Balance))
                            {
                                customer.Balance = account.Deposit(-amount, customer.Balance);
                                Console.WriteLine($"You withdrew {amount}$. You have {customer.Balance}$ left on your account.");
                            }
                            else
                            {
                                Console.WriteLine("Withdrawal failed. Not enough funds.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter amount to deposit:");
                        double depositAmount;
                        bool isDepositAmountParsed = double.TryParse(Console.ReadLine(), out depositAmount);

                        if (isDepositAmountParsed)
                        {
                            Account account = new Account();
                            customer.Balance = account.Deposit(depositAmount, customer.Balance);
                            Console.WriteLine($"You deposited {depositAmount}$. Your new balance is {customer.Balance}$.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter your first name:");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter your last name:");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Enter your initial balance:");
                        double balance;
                        bool isBalanceParsed = double.TryParse(Console.ReadLine(), out balance);
                        if (isBalanceParsed)
                        {
                            Customer newCustomer = new Customer { CardNumber = GenerateCardNumber(), Pin = GeneratePin(), FirstName = firstName, LastName = lastName, Balance = balance };
                            Console.WriteLine($"Your new card number is {newCustomer.CardNumber}. Remember to keep it safe and do not share it with anyone.");
                            Console.WriteLine($"Your new pin number is {newCustomer.Pin}. Remember to keep it safe and do not share it with anyone.");
                            Console.WriteLine($"Your initial balance is {newCustomer.Balance}$.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using the ATM app.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid card number or pin.");
            }
        }

        private int GeneratePin()
        {
            Random random = new Random();
            int pin = random.Next(1000, 9999);
            return pin;
        }

        private string GenerateCardNumber()
        {
            Random random = new Random();
            string cardNumber = "";
            for (int i = 0; i < 16; i++)
            {
                int digit = random.Next(0, 9);
                cardNumber += digit;
                if ((i + 1) % 4 == 0 && i != 15)
                {
                    cardNumber += "-";
                }
            }
            return cardNumber;
        }


        private Customer FindCustomer(string cardNumber, int pin)
        {         
            List<Customer> customers = new List<Customer>
{
    new Customer { CardNumber = "1111-1111-1111-1111", Pin = 1111, FirstName = "Dejan", LastName = "Temelkovski", Balance = 1000 },
    new Customer { CardNumber = "2222-2222-2222-2222", Pin = 2222, FirstName = "Angel", LastName = "Mitrov", Balance = 2000 },
    new Customer { CardNumber = "3333-3333-3333-3333", Pin = 3333, FirstName = "Danilo", LastName = "Borozan", Balance = 3000 },
    new Customer { CardNumber = "4444-4444-4444-4444", Pin = 4444, FirstName = "Ljupche", LastName = "Joldashev", Balance = 4000 },
    new Customer { CardNumber = "5555-5555-5555-5555", Pin = 5555, FirstName = "Mitko", LastName = "Majorot", Balance = 5000 }
};

            foreach (Customer customer in customers)
            {
                if (customer.CardNumber == cardNumber && customer.Pin == pin)
                {
                    return customer;
                }
            }

            return null;
        }
    }
}

