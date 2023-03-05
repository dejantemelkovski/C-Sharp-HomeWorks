            string[] names = new string[10];
            int count = 0;
            string answer = "Y";

            while (answer.ToUpper() == "Y")
            {
                Console.Write("Enter a name: ");
                names[count] = Console.ReadLine();
                count++;

                Console.Write("Do you want to enter another name? (Y/N): ");
                answer = Console.ReadLine();
            }

            Console.WriteLine("The names in the array are:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();