using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class GradeStatistics
    {
        //fields
        public float HighestGrade;
        public float LowestGrade;
        public float AverageGrade;

        //Constructor
        public GradeStatistics()
        {
            HighestGrade = 0f;
            LowestGrade = float.MaxValue;
        }

    }
}
