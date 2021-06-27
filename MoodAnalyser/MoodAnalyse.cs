using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        //constants
        private const string SAD_MESSAGE = "Iam in Sad Mood";
        private const string HAPPY_MESSAGE = "Iam in Any Mood";
        //variables
        private string message;
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        
        // Check for mood if sad return sad message and
        // if happy return happy message.
        // if mood is null throw an exception invalid mood.
      
        public string AnalyseMood()
        {
            try
            {
                if (message == null || message == string.Empty)
                    throw new Exception();
                if (message == SAD_MESSAGE)
                    return "SAD";
                if (message == HAPPY_MESSAGE)
                    return "HAPPY";
            }
            catch (Exception)
            {
                return "HAPPY";
            }
            return null;
        }
    }
}

