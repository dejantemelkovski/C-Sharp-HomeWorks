            Console.Write("Enter the First number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            double num3 = double.Parse(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            double num4 = double.Parse(Console.ReadLine());

            double average = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("The average of " + num1 + ", " + num2 + ", " + num3 + ", and " + num4 + " is: " + average);
            Console.ReadLine();