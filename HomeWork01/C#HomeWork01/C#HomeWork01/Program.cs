            Console.Write("Enter the First number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the Operation (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine());

            double result = 0.0;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    break;
            }

            Console.WriteLine("The result is: " + result);
            Console.ReadLine();