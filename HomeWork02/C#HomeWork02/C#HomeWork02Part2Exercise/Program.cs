            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("The sum of the array elements is: " + sum);
            Console.ReadLine();