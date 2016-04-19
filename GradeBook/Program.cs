using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;


/* Classes and Objects Demo
 * We need an electronic Grade book to read the scores of an individual student
 * and then compute some simple statistics from the scores.
 * 
 * The grade are entered as floating point numbers from 0 to 100, and the 
 * statistics should show us the highest grade, the lowest grade and the 
 * average grade.
 * 
 * 1.  Determine what classes we need - using nouns we could determine that we
 *     will probably need the following classes
 *     - GradeBook
 *     - GradeStatistics
 * 2.  Add these 2 new classes to your project (CTRL+SHIFT+A)
 *
 */
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Working with other references 
            //Using the Speech Synthesizer (Speak Method)

            SpeechSynthesizer synth = new SpeechSynthesizer();
            //first using default voice 
            //synth.Rate = -10;

            //now with another voice
            synth.SelectVoice("Microsoft Zira Desktop");
            synth.Speak("Hello this is the grade book program");




            //Instantiate the grade book class - creating the
            //the GradeBook object reprepresented by book
            GradeBook book = new GradeBook();

            //Add some random grades;
            book.AddGrade(91);
            book.AddGrade(89.5f);//explicitly convert double 89.5 to float by adding f
            book.AddGrade(75);

            //Get the stats and write out results to screen
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Average Grade: " + stats.AverageGrade);
            Console.WriteLine("Highest Grade: "+ stats.HighestGrade);
            Console.WriteLine("Lowest Grade: " + stats.LowestGrade);
            Console.WriteLine("Press any key to exit program");
            Console.ReadKey();


        }
    }
}
