using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalysisException : Exception
    {
        public enum Errors
        {
            EMPTY,
            CLASS_ERROR

        }
        // custom exception for mood analysis. dDisplays an empty message.
        
        public MoodAnalysisException(string message)
        {
            if (message == null || message == string.Empty)
            {
                Console.WriteLine(Errors.EMPTY + ": Mood cannot be empty.");
            }
            if (message.Contains("Mood"))
            {
                Console.WriteLine(Errors.CLASS_ERROR + ": No Such Class Error.");
            }
        }
    }
}
