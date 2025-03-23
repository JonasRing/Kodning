using System;

        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        if (A > 90 || B > 90 || C > 90)
        {
            Console.WriteLine("Trubbig Triangel");
        }
        else if (A == 90 || B == 90 || C == 90)
        {
            Console.WriteLine("Ratvinklig Triangel");
        }
        else
        {
            Console.WriteLine("Spetsig Triangel");
        }