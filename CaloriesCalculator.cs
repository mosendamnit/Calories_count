using System;
using System.Reflection.Metadata;
namespace CaloriesCount
{
    class CaloriesCalaculatorOnBaseOfIncline
    {
        public double weight { set; get; }
        public double timetorun{ set; get; }
        public const double minutes = 60;
        public double InclinePercentage { set; get; }

        public CaloriesCalaculatorOnBaseOfIncline()
        {
            
        }

        public CaloriesCalaculatorOnBaseOfIncline (double weight, double timetorun , double minutes, double InclinePercentage)
        {
            this.weight = weight;
            this.timetorun = timetorun;
            this.InclinePercentage = InclinePercentage;
        }

        public double CaloriesBurnOnBaseOfIncline()
        {
            double MET = 0.0;
            if (InclinePercentage >= 1 && InclinePercentage <=5)
            {
                MET = 8;
                
            }
            else if (InclinePercentage >=6 && InclinePercentage <=10)
            {
                MET = 9;
            }
            else if (InclinePercentage >= 11 & InclinePercentage <=15)
            {
                MET = 10;
                
            }
            else
            {
                MET = 7;
            }

            double caloriesBurned = (MET * weight) * (timetorun / 60.0);

            return caloriesBurned;
        }
    
    }
    



}
