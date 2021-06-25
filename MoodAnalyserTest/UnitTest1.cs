using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyse moodAnalyser = new MoodAnalyse(message);

            //ACT
            string mood = moodAnalyser.AnalyseMood();

            //ASSERT
            Assert.AreEqual(expected, mood);
        }
    }
}
