using System;
using System.Reflection.Metadata;
namespace CaloriesCount
{
    class CaloriesCalaculatorOnBaseOfSpeed
    {
        public double weight { set; get; }
        public double timetorun { set; get; }
        public const double minutes = 60;
        public double speedvalue { set; get; }

        public CaloriesCalaculatorOnBaseOfSpeed (double weight, double timetorun , double minutes, double speedvalue)
        {
            this.weight = weight;
            this.timetorun = timetorun;
            this.speedvalue = speedvalue;
        }

        public double CaloriesBurnOnBaseOfSpeed()
        {
            double MET = 0.0;
            if (speedvalue >= 1 && speedvalue <=5)
            {
                MET = 7.0;
                
            }
            else if (speedvalue ==5.5)
            {
                MET = 8.0;
            }
            else if (speedvalue == 6)
            {
                MET = 9.8;
            }
            else if (speedvalue >= 7 && speedvalue <=8)
            {
                MET = 11.0;
            }
            else if (speedvalue == 10)
            {
                MET = 16;
            }

            double caloriesBurned = (MET * weight) * (timetorun / 60.0);

            return caloriesBurned;
        }
    }
}
