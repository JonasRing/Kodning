using System;        
        
        string[] input = Console.ReadLine().Split(' ');
        int X = int.Parse(input[0]);
        int Y = int.Parse(input[1]);
        int N = int.Parse(input[2]);
        
        if (X >= 1 && Y > X && N >= Y && N <= 100)
        {
            for (int i = 1; i <= N; i++)
        {
            if (i % X == 0 && i % Y == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % X == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % Y == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
            
        }
        }