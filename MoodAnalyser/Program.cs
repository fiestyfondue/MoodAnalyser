using System;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyse mood = new MoodAnalyse("SAD");
            mood.AnalyseMood();
        }
    }
}
