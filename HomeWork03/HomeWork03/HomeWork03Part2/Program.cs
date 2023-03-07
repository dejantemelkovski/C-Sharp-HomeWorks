Console.Write("Enter a sentence: ");
string input = Console.ReadLine();

string[] words = input.Split(' ');

foreach (string word in words)
{
    Console.Write(word + " ");
}

Console.WriteLine();