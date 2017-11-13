using System;
using System.Collections.Generic;

namespace sample_app_for_team_city
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Format("{0} {1}", "Hello, ", "UseStringInterpolation inspection"));

            var hello = "Hello, ";
            Console.WriteLine(hello+" ConvertToConstant.Local inspection");
            
            Console.WriteLine("Hello, TeamCity");
        }
    }
}