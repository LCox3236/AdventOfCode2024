using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day3AdventOfCode
{
    public class Day3Class
    {
        public static void Day3()
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