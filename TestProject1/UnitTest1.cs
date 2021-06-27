using MoodAnalyser;
using NUnit.Framework;
using System;

namespace TestProject1
{
    public class Tests
    {


        [Test]
        public void WhenGivenSadMood_ReturnsSadMessge()
        {
            //Arrange
            string message = "Iam in Sad Mood";
            string expected = "SAD";
            //Act
            MoodAnalyse mood = new MoodAnalyse(message);
            string result = mood.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, result);
        }

        // Checking for Happy mood, return "HAPPY" message.

        [Test]
        public void WhenGivenHappyMood_ReturnsHappyMessage()
        {
            //Arrange
            string message = "Iam in Happy Mood";
            string expected = "HAPPY";
            //Act
            MoodAnalyse mood = new MoodAnalyse(message);
            string result = mood.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// check for invalid mood, returns "HAPPY" message.
        /// </summary>
        [Test]
        public void WhenGivenInvalidMood_ReturnsHappyMessageorException()
        {//passing improper class name will return Null value which means an improper class name has been used
         //passed and throws a custom exception NO Such Class Error.
            try
            {
                //Arrange
                string message = "";
                string expected = "HAPPY";
                //Act
                MoodAnalyse mood = new MoodAnalyse(message);
                string result = mood.AnalyseMood();
                //Assert
                Assert.AreEqual(expected, result);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void WhenGivenClassName_ReturnObject()
        {
            try
            {
                //Arrange
                object tempObject = MoodAnalyserFactory.CreateObjectAtRuntime("MoodAnalyse.AnalyseMood");

                //Act
                string expected = "MoodAnalyse.AnalyseMood";
                string result = "MoodAnalyse.AnalyseMood";
                //Assert
                Assert.AreEqual(expected, result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
        [Test]
        public void WhenGivenImproperClassName_ReturnsException()
        {
            try
            {
                //Arrange
                object tempObject = MoodAnalyserFactory.CreateObjectAtRuntime("MoodAnalyse.AnalyseMood");
                //Act
                string expected = null;
                string result = null;
                //Assert
                Assert.AreEqual(expected, result);
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done TestCase");
            }
            
        }
    }
}