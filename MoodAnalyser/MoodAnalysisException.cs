using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    class MoodAnalysisException : Exception
    {
        public enum Errors{Empty};

        // custom exception for mood analysis. display an empty or null message
        public MoodAnalysisException()
        {
            Console.WriteLine(Errors.Empty);
        }
    }
}
