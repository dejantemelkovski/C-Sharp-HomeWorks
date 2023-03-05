            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Ana", "Marija", "Petar", "Ivan", "Marko" };

            Console.Write("Enter student group: (there are 1 and 2) ");
            int group = int.Parse(Console.ReadLine());

            Console.WriteLine("The Students in G" + group + " are:");
            if (group == 1)
            {
                foreach (string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
            }
            else if (group == 2)
            {
                foreach (string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            Console.ReadLine();