﻿            Console.Write("Input the First Number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Input the Second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After Swapping:");
            Console.WriteLine("First Number: " + num1);
            Console.WriteLine("Second Number: " + num2);
            Console.ReadLine();