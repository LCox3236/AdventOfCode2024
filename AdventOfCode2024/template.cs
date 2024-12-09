using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DayAdventOfCode
{
    public class DayClass
    {
        public static void Day()
        {
            string filepath = "Day1/input.txt";
            try
            {
                string[] lines = File.ReadAllLines(filepath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split();
                }

            }
            catch(Exception ex)
            {                
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}