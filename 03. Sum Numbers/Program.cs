﻿using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < n)
            {
                int currentNum = int.Parse(Console.ReadLine());

                sum += currentNum;
            }

            Console.WriteLine(sum);
        }
    }
}