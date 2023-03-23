using HomeWork07Task3.Classes;
using HomeWork07Task3.Enums;

AnimalManager animalManager = new AnimalManager();

animalManager.AddAnimal(new Animal { Name = "Alexander", Color = "Black", Age = 3, Gender = Gender.Male });
animalManager.AddAnimal(new Animal { Name = "Bartholomew", Color = "Brown", Age = 6, Gender = Gender.Male });
animalManager.AddAnimal(new Animal { Name = "Charlotte", Color = "Brown", Age = 2, Gender = Gender.Female });
animalManager.AddAnimal(new Animal { Name = "Dorothea", Color = "Gray", Age = 8, Gender = Gender.Female });
animalManager.AddAnimal(new Animal { Name = "Eleonora", Color = "Brown", Age = 4, Gender = Gender.Female });
animalManager.AddAnimal(new Animal { Name = "Ferdinand", Color = "White", Age = 1, Gender = Gender.Male });
animalManager.AddAnimal(new Animal { Name = "Gabriella", Color = "Orange", Age = 5, Gender = Gender.Female });
animalManager.AddAnimal(new Animal { Name = "Hermione", Color = "Gray", Age = 2, Gender = Gender.Female });
animalManager.AddAnimal(new Animal { Name = "Isadora", Color = "Brown", Age = 7, Gender = Gender.Female });
animalManager.AddAnimal(new Animal { Name = "Juliana", Color = "Black", Age = 4, Gender = Gender.Female });
animalManager.AddAnimal(new Animal { Name = "Kassandra", Color = "Gray", Age = 6, Gender = Gender.Female });
animalManager.AddAnimal(new Animal { Name = "Leonard", Color = "Brown", Age = 3, Gender = Gender.Male });
animalManager.AddAnimal(new Animal { Name = "Anthony", Color = "White", Age = 5, Gender = Gender.Male });
animalManager.AddAnimal(new Animal { Name = "Nathaniel", Color = "Black", Age = 1, Gender = Gender.Male });
animalManager.AddAnimal(new Animal { Name = "Octavia", Color = "Brown", Age = 8, Gender = Gender.Female });


List<string> agedFiveOrMore = animalManager.GetAnimalsAgedFiveOrMore();
        Console.WriteLine("Animals aged 5 or more: " + string.Join(", ", agedFiveOrMore));

        List<string> startingWithA = animalManager.GetAnimalsStartingWithA();
        Console.WriteLine("Animals starting with 'A': " + string.Join(", ", startingWithA));

        List<string> maleBrownAnimals = animalManager.GetMaleBrownAnimals();
        Console.WriteLine("Male, brown animals: " + string.Join(", ", maleBrownAnimals));

        Animal longNameAnimal = animalManager.GetFirstAnimalWithLongName();
        if (longNameAnimal != null)
        {
            Console.WriteLine("First animal with a name longer than 10 characters: " + longNameAnimal.Name);
        }