using MoodAnalyser;
using NUnit.Framework;

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
        public void WhenGivenInvalidMood_ReturnsHappyMessage()
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
    }
}