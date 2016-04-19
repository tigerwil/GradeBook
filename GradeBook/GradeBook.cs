using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    /* Encapsulation:  Enclosing or hiding details
     * 
     * Access Modifiers: https://msdn.microsoft.com/en-us/library/wxh6fsc7.aspx 
     *
     * public:  access outside of class - uppercase is the convention
     * private:  access inside of class (default) -lower is the convention
     * 
     * Static Keyword:
     * --------------
     * Use to static members of a class without creating an instance 
     * (do not need the new keyword)
     * for example:  Console.WriteLine("Hello");
     * 
     */
    public class GradeBook
    {
        private List<float> grades;

        //Default Constructor method - without parameters
        //type ctor and tab twice (snippet)
        public GradeBook()
        {
            //Initialize grade as a new list of float
            grades = new List<float>();

        }

        internal void AddGrade(double v)
        {
            throw new NotImplementedException();
        }

        //Create a method to compute grade statistics
        //(lowest, highest and average) scores
        //returns GradeStatistics
        public GradeStatistics ComputeStatistics()
        {
            //Instantiate the GradeStatistics 
            GradeStatistics stats = new GradeStatistics();

            //Loop through all grades (in grades collection)
            //float sum = 0;
            foreach (float grade in grades)
            {
                //get largest of the two (new grade compared the current highest)
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                //get the smallest of the two
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                //sum += grade;//running sum             

            }

            //average
            stats.AverageGrade = grades.Average();
            //or manually
            //stats.AverageGrade = sum / grades.Count;


            //return stats
            return stats;
        }

        //Create a method to add a new grade
        //void:  does not return a value
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

    }//end of class
}//end of namespace
