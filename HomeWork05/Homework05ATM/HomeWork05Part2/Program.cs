using HomeWork05Part2.Classes;

class Program
{
    static void Main(string[] args)
    {
        Driver[] drivers = new Driver[]
        {
                new Driver { Name = "Bob", Level = 4 },
                new Driver { Name = "Greg", Level = 6 },
                new Driver { Name = "Jill", Level = 8 },
                new Driver { Name = "Anne", Level = 5 }
        };

        Car[] cars = new Car[]
        {
                new Car { Model = "Hyundai", Speed = 120 },
                new Car { Model = "Mazda", Speed = 150 },
                new Car { Model = "Ferrari", Speed = 200 },
                new Car { Model = "Porsche", Speed = 180 }
        };

        Console.WriteLine("Choose a car no.1:");
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine($"{i + 1}.{cars[i].Model}");
        }

        int car1Choice;
        while (!int.TryParse(Console.ReadLine(), out car1Choice) || car1Choice < 1 || car1Choice > 4)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.WriteLine("Choose Driver for Car 1:");
        for (int i = 0; i < drivers.Length; i++)
        {
            Console.WriteLine($"{i + 1}.{drivers[i].Name}");
        }

        int driver1Choice;
        while (!int.TryParse(Console.ReadLine(), out driver1Choice) || driver1Choice < 1 || driver1Choice > 4)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Car chosenCar1 = cars[car1Choice - 1];
        Driver chosenDriver1 = drivers[driver1Choice - 1];
        chosenCar1.Driver = chosenDriver1;


        Car[] remainingCars = cars.Where(c => c != chosenCar1).ToArray();
        Driver[] remainingDrivers = drivers.Where(d => d != chosenDriver1).ToArray();

        Console.WriteLine("Choose a car no.2:");
        for (int i = 0; i < remainingCars.Length; i++)
        {
            Console.WriteLine($"{i + 1}.{remainingCars[i].Model}");
        }

        int car2Choice;
        while (!int.TryParse(Console.ReadLine(), out car2Choice) || car2Choice < 1 || car2Choice > 3)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.WriteLine("Choose Driver for Car 2:");
        for (int i = 0; i < remainingDrivers.Length; i++)
        {
            Console.WriteLine($"{i + 1}.{remainingDrivers[i].Name}");
        }

        int driver2Choice;
        while (!int.TryParse(Console.ReadLine(), out driver2Choice) || driver2Choice < 1 || driver2Choice > 3)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Car chosenCar2 = remainingCars[car2Choice - 1];
        Driver chosenDriver2 = remainingDrivers[driver2Choice - 1];
        chosenCar2.Driver = chosenDriver2;

        RaceCars(chosenCar1, chosenCar2);

        Console.WriteLine("Do you want to race again? (Y/N)");
        string choice = Console.ReadLine();
        if (choice.ToUpper() == "Y")
        {
            Main(args);
        }
    }

    static void RaceCars(Car car1, Car car2)
    {
        double car1Speed = car1.CalculateSpeed();
        double car2Speed = car2.CalculateSpeed();

        if (car1Speed > car2Speed)
        {
            Console.WriteLine($"{car1.Model} driven by {car1.Driver.Name} was faster");
            Console.WriteLine($"{car1.Model} was going {car1.Speed} mph");
        }
        else if (car2Speed > car1Speed)
        {
            Console.WriteLine($"{car2.Model} driven by {car2.Driver.Name} was faster");
            Console.WriteLine($"{car2.Model} was going {car2.Speed} mph");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }
}

