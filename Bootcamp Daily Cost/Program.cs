using System;

namespace Bootcamp_Daily_Cost {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine("To the C# World...");
            


            var TotalCost = 15500m;
            var AvgDailyCost = TotalCost / 65;
            var PreMessage = "Total cost is ";
            var PostMessage = "Daily Cost";
            var Message = "{PreMessage}{AvgDailyCost}{PostMessage}";
            Console.WriteLine($"{PreMessage}{AvgDailyCost}{PostMessage}");
            Console.WriteLine($"Total Cost is {TotalCost}, Avg is {AvgDailyCost}");
            Console.WriteLine($"{Message}");
            System.Diagnostics.Debug.WriteLine($"{Message}");
            





        }
        
       }
}
