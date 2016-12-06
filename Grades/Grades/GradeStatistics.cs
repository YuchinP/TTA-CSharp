using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
        
        public string Description
        {
            get
            {
                string letterGrade;
                switch (getletterGrade)
                {
                    case "A":
                        letterGrade = "Excellent";
                        break;
                    case "B":
                        letterGrade = "Good";
                        break;
                    case "C":
                        letterGrade = "Average";
                        break;
                    case "D":
                        letterGrade = "Below Average";
                        break;
                    default:
                        letterGrade = "Failing";
                        break;
                }
                return letterGrade;
            }
        }

        public string getletterGrade
        {
            get
            {
                double AverageGrade = Math.Round(this.AverageGrade);
                string letterGrade;
                if (AverageGrade >= 90)
                {
                    letterGrade = "A";
                }
                else if (AverageGrade >= 80)
                {
                    letterGrade = "B";
                }
                else if (AverageGrade >= 70)
                {
                    letterGrade = "C";
                }
                else if (AverageGrade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }
                return letterGrade;
            }
        }


        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
