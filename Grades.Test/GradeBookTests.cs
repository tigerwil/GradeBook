using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grades.Test
{
    [TestClass]
    public class GradeBookTests
    {
        //We will instantiate the Gradebook and give it some data
        //then write some assertions to make sure it computes correct 
        //highest grade

        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook.GradeBook book = new GradeBook.GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeBook.GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);//pass
            //Assert.AreEqual(10, result.HighestGrade);//fail   

        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook.GradeBook book = new GradeBook.GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeBook.GradeStatistics result = book.ComputeStatistics();
            //Assert.AreEqual(90, result.LowestGrade);//fail
            Assert.AreEqual(10, result.LowestGrade);//pass      



        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook.GradeBook book = new GradeBook.GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);//explicitly convert double 89.5 to float by adding f
            book.AddGrade(75);

            GradeBook.GradeStatistics result = book.ComputeStatistics();
            //Assert.AreEqual(85.16, result.AverageGrade);//fail     
            Assert.AreEqual(85.16, result.AverageGrade,0.01);
            ////failed. Expected:<85.16>. Actual:<85.1666641235352>



        }

    }
}
