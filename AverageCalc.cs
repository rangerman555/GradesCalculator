using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesCalculator
{
    public class AverageCalc
    {
        public double Average { get; set; }
        public int SumOfPoints { get; set; }
        public int SumOfGrades { get; set; }


        public void calcAverage()
        {
            Average = (double)(SumOfGrades) / SumOfPoints;
            Average = System.Math.Round(Average, 2);
        }

        public void addGradeAndPoints(string grade, string points)
        {
            SumOfPoints += int.Parse(points);
            SumOfGrades += int.Parse(grade) * int.Parse(points);
        }
    }
}
