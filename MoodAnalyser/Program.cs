using System;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Mood Analyser program using Reflections");
            //// method to create an instance of class at Run Time.
            MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory("MoodAnalyser.MoodAnalyserr");
            object objName = moodAnalyserFactory.CreateObjectAtRuntime();
            Console.WriteLine("object of the class :" + objName);
        }
    }
}
