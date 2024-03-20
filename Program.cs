using System;
using System.Net.Http.Headers;
using CaloriesCount;
using CaloriesTarget;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------Welcome to the Calories Countor-------");


        Console.WriteLine("Enter how much calories want to burn today :");
        double targetcalories = Convert.ToDouble(Console.ReadLine());


        

        Console.WriteLine(" Eneter your weight in kg: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the time you want to run for :");
        double timetorun = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Level of Incline: ");
        double InclinePercentage = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter your speed you want to run: ");
        double speedvalue = Convert.ToDouble(Console.ReadLine());


        var caloriescalculatorbaseofincline = new CaloriesCalaculatorOnBaseOfIncline(weight,timetorun, InclinePercentage, speedvalue);

        var caloriescalculatoronbaseofspeed = new CaloriesCalaculatorOnBaseOfSpeed(weight, timetorun, InclinePercentage, speedvalue);

        var targetCaloriesToBurn = new TargetCaloriesToBurn(weight, targetcalories,  timetorun);
        targetCaloriesToBurn.SuggestRunningParameterSet();
        Console.WriteLine($"This set of exercies will be best for you today {targetCaloriesToBurn}");


        double caloriesIncline = caloriescalculatorbaseofincline.CaloriesBurnOnBaseOfIncline();
        double caloriesSpeed = caloriescalculatoronbaseofspeed.CaloriesBurnOnBaseOfSpeed();

        Console.WriteLine($"Calories lost on base of incline {caloriesIncline} kalories. ");

        Console.WriteLine($"Calories lost on base of Speed {caloriesSpeed} kalories. ");

    }
}
