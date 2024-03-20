using System;
using System.ComponentModel;
using CaloriesCount;
namespace CaloriesTarget
{
    public class TargetCaloriesToBurn
    {
        double weight { get; set; }
        double targetcalories { get; set; }
        double timetorun { get;  set; }
        double metValue { get; set; }
        double InclinePercentage { set; get; }
        double speedValue { get; set; }
        
        public TargetCaloriesToBurn()
        {
            
        }

        public TargetCaloriesToBurn (double weight , double targetcalories , double timetorun )
        {
            this.weight = weight;
            this.targetcalories = targetcalories;
            this.timetorun = timetorun;
            this.metValue = metValue;
        }

        public double calculateMetvalue()
        {
            return targetcalories / (weight * timetorun);
        }

        public double DurationofTimeBurenTargetedCalories ()
        {
            double metValue = calculateMetvalue();
            double duration = targetcalories / (metValue * InclinePercentage * speedValue); 
            return duration;
        }

        public void SuggestRunningParameterSet ( )
        {
            Console.WriteLine("Suggested Running Parameters Sets: ");

            PrintRunningParamterSet(7.0, 5.0);
            PrintRunningParamterSet(8.0, 3.0);
            PrintRunningParamterSet(4.0, 8.0);
        }

        public void PrintRunningParamterSet(double speedValue, double InclinePercentage)
        {

            Console.WriteLine($"Running Speed {speedValue} , Incline Angle {InclinePercentage} , Time Duration {timetorun}");
        }

    } 

}