using HomeWork07Task3.Enums;

namespace HomeWork07Task3.Classes
{
    public class AnimalManager
    {
        private List<Animal> animals = new List<Animal>();

        public void AddAnimal(Animal animal) => animals.Add(animal);

        public List<string> GetAnimalsAgedFiveOrMore() => animals
            .Where(animal => animal.Age >= 5)
            .Select(animal => animal.Name)
            .ToList();

        public List<string> GetAnimalsStartingWithA() => animals
            .Where(animal => animal.Name.StartsWith("A"))
            .Select(animal => animal.Name)
            .ToList();

        public List<string> GetMaleBrownAnimals() => animals
            .Where(animal => animal.Gender == Gender.Male && animal.Color == "Brown")
            .Select(animal => animal.Name)
            .ToList();

        public Animal GetFirstAnimalWithLongName() => animals.FirstOrDefault(animal => animal.Name.Length > 10);
    }
}
