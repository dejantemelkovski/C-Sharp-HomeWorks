Queue<int> numbers = new Queue<int>();

while (true)
{
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine());
    numbers.Enqueue(number);

    Console.Write("Do you want to enter another number? (Y/N): ");
    string input = Console.ReadLine().ToUpper();

    if (input != "Y")
    {
        break;
    }
}

Console.WriteLine("You entered the following numbers:");
while (numbers.Count > 0)
{
    int number = numbers.Dequeue();
    Console.WriteLine(number);
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();