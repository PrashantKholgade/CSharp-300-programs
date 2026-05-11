// Program 90: Simple Number Guessing Game
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int secret = rnd.Next(1, 101);
        int guess, attempts = 0;
        Console.WriteLine("Guess the number between 1 and 100.");
        do
        {
            Console.Write("Your guess: ");
            guess = int.Parse(Console.ReadLine());
            attempts++;
            if (guess < secret) Console.WriteLine("Too low!");
            else if (guess > secret) Console.WriteLine("Too high!");
        } while (guess != secret);
        Console.WriteLine("Correct! You guessed it in " + attempts + " attempts.");
    }
}
