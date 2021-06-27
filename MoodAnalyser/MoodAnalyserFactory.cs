using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        //CreateMoodAnalyse method to create object of MoodAnalyse class
        public static object CreateObjectAtRuntime(string className)
        {
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type moodAnalyserType = assembly.GetType(className);
                if (moodAnalyserType == null)
                    throw new MoodAnalysisException(className);
                Console.WriteLine($"Name of the class at Runtime: {moodAnalyserType.Name}");
                object moodAnalyserObject = Activator.CreateInstance(moodAnalyserType);
                return moodAnalyserObject;
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
                Console.WriteLine("Done Reflections");
            }
            return null;
        }
    }
}
