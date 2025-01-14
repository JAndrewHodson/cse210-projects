using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade as a percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string passFail = "pass";
        string letterGrade = "A";

        if (grade < 60)
        {
            letterGrade = "F";
            passFail = "fail";

        }
        else if (grade < 70)
        {
            letterGrade = "D";
            passFail = "fail";
        }
        else if (grade < 80)
        {
            letterGrade = "C";
            passFail = "pass";
        }
        else if (grade < 90)
        {
            letterGrade = "B";
            passFail = "pass";
        }
        else
        {
            letterGrade = "A";
            passFail = "pass";
        }
        Console.WriteLine($"You got a {letterGrade}.");
        if (passFail == "pass")
        {
            Console.WriteLine($"You {passFail} the course. Congratulations!");
        } else 
        {
            Console.WriteLine($"You {passFail} the course. Better luck next time!");
        }
    }
}