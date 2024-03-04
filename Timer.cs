using System;

class Program
{
    static void Main(string[] args, int workMinutes)
    {
       int minutes = 25;
        int breakMinutes = 5;
        int workSeconds = workMinutes * 60;
        int breakSeconds = breakMinutes * 60;
        int choice = 0;

        Console.WriteLine("Pomodoro Timer App!");
        Console.WriteLine("1. Start Work Timer");
        Console.WriteLine("2. Start Break Timer");
        Console.WriteLine("3. Exit");
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Work Timer Started");
            for (int i = workSeconds; i >= 0; i--)
            {
                if (i < 60)
                {
                    Console.WriteLine($"Time Left: {i} seconds");
                }
                else
                {
                      minutes = i / 60;
                    Console.WriteLine($"Time Left: {minutes} minutes {i % 60} seconds");
                }
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("Work Timer Ended");
        }
        else if (choice == 2)
        {
            Console.WriteLine("Break Timer Started");
            for (int i = breakSeconds; i >= 0; i--)
            {
                if (i < 60)
                {
                    Console.WriteLine($"Time Left: {i} seconds");
                }
                else
                {
                    minutes = i / 60;
                    Console.WriteLine($"Time Left: {minutes} minutes {i % 60} seconds");
                }
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("Break Timer Ended");
        }
        else if (choice == 3)
        {
            Console.WriteLine("Exiting...");
        }
        else
        {
            Console.WriteLine("Invalid Choice");
        }
    }
}
