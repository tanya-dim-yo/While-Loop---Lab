using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grades = 1;
            double sum = 0;
            int excluded = 0;

            while (grades <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4)
                {
                    excluded++;

                    if (excluded > 1)
                    {
                        break;
                    }
                    continue;
                }

                sum += grade;
                grades++;
            }

            double average = sum / 12.0;

            if (excluded <= 1)
            {
                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {grades} grade");

            }
        }
    }
}