    Console.Write("Enter a string: ");
    string input = Console.ReadLine();

    if (input.Length >= 5)
    {
        string result = input.Substring(input.Length - 5);
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("String is too short.");
    }