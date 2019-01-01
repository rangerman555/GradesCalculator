using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesCalculator
{
    public class DataToSave
    {
        public string Subject { get; set; }
        public string Points { get; set; }
        public string Grade { get; set; }

        public void addNewGrade(string subject, string points, string grade)
        {
            Subject = subject;
            Points = points;
            Grade = grade;
        }
    }
}
