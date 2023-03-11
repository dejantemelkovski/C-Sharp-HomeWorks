namespace HomeWork04Part1.Classes
{
    class Human
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public string GetPersonStats()
    {
        return $"Name: {FirstName} {LastName}, Age: {Age}";
    }
}
}