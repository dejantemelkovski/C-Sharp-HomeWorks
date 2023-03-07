            Console.Write("Enter your birthday (yyyy-mm-dd): ");
            string input = Console.ReadLine();
            int age = AgeCalculator(input);
            if (age != -1)
            {
                Console.WriteLine("Your age is: " + age);
            }
            Console.ReadLine();
        

         int AgeCalculator(string birthdayString)
        {
            DateTime birthday;
            if (!DateTime.TryParse(birthdayString, out birthday))
            {
                Console.WriteLine("Invalid date format.");
                return -1;
            }

            DateTime today = DateTime.Today;
            int age = today.Year - birthday.Year;
            if (birthday > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    
