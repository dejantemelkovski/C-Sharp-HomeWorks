            int[] nums = new int[6];

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Enter integer no." + (i + 1) + ": ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }

            Console.WriteLine("The result is: " + sum);
            Console.ReadLine();