    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public static void Main()
            {
                Console.WriteLine(100.ToEuroLabel());
            }
            
            
        }
        
        public static class Helper
        {
             public static string ToEuroLabel(this int val)
             {
                 return val + " euros";
             }
        }
    }