using HomeWork04Part2.Classes;

        Dog dog = new Dog();
        Console.Write("Enter dog name: ");
        dog.Name = Console.ReadLine();

        Console.Write("Enter dog race: ");
        dog.Race = Console.ReadLine();

        Console.Write("Enter dog color: ");
        dog.Color = Console.ReadLine();

        Console.WriteLine($"Dog {dog.Name} created.");

        while (true)
        {
            Console.WriteLine("\nWhat do you want to do with the dog?");
            Console.WriteLine("1. Eat");
            Console.WriteLine("2. Play");
            Console.WriteLine("3. Chase Tail");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(dog.Eat());
                    break;
                case "2":
                    Console.WriteLine(dog.Play());
                    break;
                case "3":
                    Console.WriteLine(dog.ChaseTail());
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }