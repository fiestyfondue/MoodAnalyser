using System;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Refactoring for UC2

            Console.WriteLine("Mood Analyser program using Exceptions");

            object objName = MoodAnalyserFactory.CreateObjectAtRuntime("MoodAnalyser.MoodAnalysers");
            Console.WriteLine(objName);



        }
    }
}
