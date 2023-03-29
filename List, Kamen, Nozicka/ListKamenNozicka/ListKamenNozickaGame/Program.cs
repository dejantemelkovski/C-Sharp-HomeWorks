using System;
using ListKamenNozickaGame.Enums;

         int userWins = 0;
         int computerWins = 0;

        
            Console.WriteLine("Welcome to Rock-Paper-Scissors!");

            bool exitRequested = false;
            while (!exitRequested)
            {
                Console.WriteLine();
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Stats");
                Console.WriteLine("3. Exit");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
                {
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                }

                switch (choice)
                {
                    case 1:
                        Play();
                        break;
                    case 2:
                        Stats();
                        break;
                    case 3:
                        exitRequested = true;
                        break;
                }
            }
        

         void Play()
        {
            Console.WriteLine("Let's play Rock-Paper-Scissors!");
            Console.WriteLine("Please choose (1) Rock, (2) Paper, or (3) Scissors:");

            int userChoice;
            while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 3)
            {
                Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
            }
            Random rng = new Random();
            MyEnum computerChoice = (MyEnum)rng.Next(1, 4);

            Console.WriteLine($"You chose {Enum.GetName(typeof(MyEnum), userChoice)}");
            Console.WriteLine($"The computer chose {Enum.GetName(typeof(MyEnum), computerChoice)}");

            int result = (userChoice - (int)computerChoice + 3) % 3;
            switch (result)
            {
                case 0:
                    Console.WriteLine("It's a tie!");
                    break;
                case 1:
                    Console.WriteLine("You win!");
                    userWins++;
                    break;
                case 2:
                    Console.WriteLine("The computer wins!");
                    computerWins++;
                    break;
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }

         void Stats()
        {
            Console.WriteLine($"You have won {userWins} times.");
            Console.WriteLine($"The computer has won {computerWins} times.");

            if (userWins + computerWins > 0)
            {
                float winPercentage = (float)userWins / (userWins + computerWins) * 100;
                float lossPercentage = 100 - winPercentage;

                Console.WriteLine($"You win {winPercentage}% of the time.");
                Console.WriteLine($"You lose {lossPercentage}% of the time.");
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }    

