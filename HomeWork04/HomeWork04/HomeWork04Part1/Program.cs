using HomeWork04Part1.Classes;

        Human human = new Human();
        Console.Write("Enter first name: ");
        human.FirstName = Console.ReadLine();

        Console.Write("Enter last name: ");
        human.LastName = Console.ReadLine();

        int age;
        Console.Write("Enter age: ");
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Invalid age input. Please enter a valid integer age.");
            Console.Write("Enter age: ");
        }
        human.Age = age;

        Console.WriteLine(human.GetPersonStats());