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
                    throw new MoodAnalysisException(message);
                if (message == SAD_MESSAGE)
                    return "SAD";
                if (message == HAPPY_MESSAGE)
                    return "HAPPY";
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Traversing Done");
            }
            return null;
        }
    }
}

