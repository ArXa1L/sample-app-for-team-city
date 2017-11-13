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

            var a1 = "";
            var a2 = "";
            var a3 = "";
            var a4 = "";
            var a5 = "";
            
            Console.WriteLine("Hello, TeamCity");
        }
    }
}