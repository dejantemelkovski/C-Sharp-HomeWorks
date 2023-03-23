List<int> numbers = new List<int>();
Random rand = new Random();

for (int i = 0; i < 10; i++)
{
    numbers.Add(rand.Next(1, 101));
}

List<int> squares = numbers.Select(x => x * x).ToList();

Console.WriteLine("Original list:");
Console.WriteLine(string.Join(", ", numbers));

Console.WriteLine("List of squares:");
Console.WriteLine(string.Join(", ", squares));

Console.WriteLine("Press any key to exit.");
Console.ReadKey();
