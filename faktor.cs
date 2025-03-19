using System;

string[] input = Console.ReadLine().Split(' ');
 int A = int.Parse(input[0]); //number of articles
 int I = int.Parse(input[1]); //the impact factor the owners require.
 
 if (A >= 1 && A <= 100 && I >= 1 && I <= 100)
 {
     int bribe = A * (I-1) +1;
     Console.WriteLine(bribe);
     
 }