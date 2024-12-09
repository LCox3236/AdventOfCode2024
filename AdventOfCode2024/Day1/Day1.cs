using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day1AdventOfCode
{
    public class Day1Class
    {
        public static void Day1()
        {
            string filepath = "Day1/input.txt";
            try
            {
                string[] lines = File.ReadAllLines(filepath);
                List<int> leftLines = new List<int>();
                List<int> rightLines = new List<int>();
                foreach (string line in lines)
                {
                    // Split the row by spaces
                    string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 2){
                        leftLines.Add(int.Parse(parts[0]));
                        rightLines.Add(int.Parse(parts.Last()));
                    }
                }

                List<int>orderedLeft = leftLines.OrderBy(num => num).ToList();
                List<int>orderedRight = rightLines.OrderBy(num => num).ToList();
                
                //PartOne(orderedLeft, orderedRight); 
                PartTwo(orderedLeft, orderedRight);

                // for (int i = 0; i < orderedLeft.Count; i++){
                //     Console.WriteLine(orderedRight[i]);
                // }
            }
            catch(Exception ex)
            {                
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    

        public static void PartOne(List<int> orderedLeft, List<int> orderedRight){
            int total = 0;
                for (int i = 0; i < orderedLeft.Count; i++){
                    total += Math.Abs(orderedLeft[i] - orderedRight[i]);
                }
                Console.WriteLine("Part One Total " + total);
        }
        


        public static void PartTwo(List<int> orderedLeft, List<int> orderedRight){
            int similarityScore = 0;
            for (int i = 0; i < orderedLeft.Count; i++){
                int countmatchs = 0;
                    for (int j = 0; j < orderedLeft.Count; j++){
                        if (orderedLeft[i] == orderedRight[j]){
                            countmatchs++;
                        }
                    }
                    similarityScore += (orderedLeft[i] * countmatchs);
                }
            Console.WriteLine(similarityScore);
        }
    }
}