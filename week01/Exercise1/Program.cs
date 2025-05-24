using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        //Practicing clearing the terminal
        Console.Clear();

        //practicing two types of including variables in string output, the $ recognition format and the + concatenation
        Console.WriteLine($"Your name is {lastName}, {firstName}" + " " + lastName + ".");

        //Practicing adding a blank line for spacing & readability
        Console.WriteLine("");
        //Using Console.Write would NOT jump to a new line afterwards.

        //Reminder to self, never run "DuBug Anyway" as that runs the previous version of code.
    }
}