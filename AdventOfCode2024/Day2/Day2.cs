using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Day2AdventOfCode
{
    public class Day2Class
    {
        public static void Day2(){
            string filepath = "Day2/input.txt";
            try
            {
                string[] lines = File.ReadAllLines(filepath);
                int totalSafe = 0;
                foreach (string line in lines) {
                    List<int> numberList = new List<int>();
                    string[] numberStrings = line.Split(' ');
                    foreach (string number in numberStrings) {
                        numberList.Add(int.Parse(number));
                    }
                    List<int> checkedList = RemoveFirstUnsafe(numberList);
                    Console.WriteLine(string.Join(",", checkedList.ToArray()));
                    Console.WriteLine(IsReportSafe(checkedList));
                    if (IsReportSafe(checkedList) == true){
                        totalSafe += 1;
                    } 
                }
                Console.WriteLine("Total Safe: "+totalSafe);
            }
            catch(Exception ex)
            {                
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
           

        }


        static List<int> RemoveFirstUnsafe(List<int> input)
        {
            bool? isIncreasing = null;
            bool? isDecreasing = null;
            bool? isSmallSteps = null;
            for (int i = 1; i < input.Count; i++)
            {
                int prev = input[i - 1] - '0';
                int current = input[i] - '0';

                // If numbers are the same, return false
                if (prev == current)
                {
                    input.RemoveAt(i);
                    return input;
                }
                    

                if (current <= prev)
                {
                    if (isIncreasing == true){ 
                        input.RemoveAt(i);
                        return input;}
                    else isDecreasing = true;
                }
                if (current >= prev)
                {
                    if (isDecreasing == true){
                        input.RemoveAt(i);
                        return input;
                    }  
                    else isIncreasing = true;
                }
                if (Math.Abs(current - prev) > 3)
                {
                    input.RemoveAt(i);
                    return input;
                }
            }
            //Console.WriteLine(isIncreasing +" increasing" + "\n decreasing " + isDecreasing  + "\n small steps" + isSmallSteps);
            //return ((isIncreasing ^ isDecreasing) && isSmallSteps);
            return input;
        }




        static bool IsReportSafe(List<int> input)
        {
            bool isIncreasing = true;
            bool isDecreasing = true;
            bool isSmallSteps = true;
            for (int i = 1; i < input.Count; i++)
            {
                int prev = input[i - 1] - '0';
                int current = input[i] - '0';

                // If numbers are the same, return false
                if (prev == current)
                    return false;

                if (current <= prev)
                {
                    isIncreasing = false;
                }
                if (current >= prev)
                {
                    isDecreasing = false;
                }
                if (Math.Abs(current - prev) > 3)
                {
                    isSmallSteps = false;
                }
            }
            //Console.WriteLine(isIncreasing +" increasing" + "\n decreasing " + isDecreasing  + "\n small steps" + isSmallSteps);
            return ((isIncreasing ^ isDecreasing) && isSmallSteps);
        }
    }
    
}