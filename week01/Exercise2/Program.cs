using System;

class Program
{
    static void Main(string[] args)
    {
        //practicing asking for input without jumping to the next line
        Console.Write("Enter your grade percentage");
        string inputPercentage = Console.ReadLine();

        //practicing turning a user input (which must be a string intitially) into an integer, assuming the use actually entered integers
        int gradePercentage = int.Parse(inputPercentage);

        if (gradePercentage >= 90)
        {
            Console.WriteLine($"Your grade is a A");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine($"Your grade is a B");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine($"Your grade is a C");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine($"Your grade is a D");
        }
        else
        {
            Console.WriteLine($"Your grade is a F");
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("You have passed the class.");
        }
        else
        {
            Console.WriteLine("You have failed the class.");
        }

    }
}