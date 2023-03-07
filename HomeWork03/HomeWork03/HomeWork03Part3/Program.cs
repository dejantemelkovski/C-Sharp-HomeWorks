        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int number;
        if (int.TryParse(input, out number))
        {
            int digitSum = DigitSum(number);
            Console.WriteLine("The sum of the digits is: " + digitSum);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        Console.ReadLine();
    

    int DigitSum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }