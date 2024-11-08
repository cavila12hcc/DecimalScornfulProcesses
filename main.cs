using System;

class Program
{
    static void Main(string[] args)
    {
        ShowMotto();
        DisplayMenu();
    }

    static void ShowMotto()
    {
        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************\n");
    }

    static void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("Please Enter the following number below from the following menu:");
            Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
            Console.WriteLine("2. Exit\n");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CalculateRevenue();
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nThank you for using the Greenville Revenue App, good-bye!");
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid option. Please try again.\n");
            }
        }
    }

    static void CalculateRevenue()
    {
        Console.Write("\nEnter the number of contestants from last year: ");
        int lastYearContestants = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of contestants from this year: ");
        int currentYearContestants = Convert.ToInt32(Console.ReadLine());

        int revenue = currentYearContestants * 25;
        bool isBigger = currentYearContestants > lastYearContestants;

        Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {currentYearContestants} contestants");
        Console.WriteLine($"Revenue expected this year is ${revenue}");
        Console.WriteLine($"It is {isBigger.ToString().ToLower()} that this year's competition is bigger than last year's.\n");

        ShowMotto();
    }
    }