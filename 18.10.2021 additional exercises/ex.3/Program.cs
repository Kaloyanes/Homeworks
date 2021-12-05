using System;
using System.Collections.Generic;
using System.Linq;

namespace ex._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> answers = new List<string>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split('.').ToList();

                // Checking if it says ReadMe and if its true we break from the loop
                if (input[0] == "ReadMe") break;
                
                // Reversing the string so we can check if its a palindrome
                string reversed = reverseString(input[0]);
                string answer = "";

                // Checking if its a palindrome or not
                if (input.Count < 2 || input[input.Count - 1] != reversed) answer = "NO";
                else answer = "YES";

                // Adding the answer to the list of answers
                answers.Add(answer);
            }

            // Going through every answer
            foreach (var answer in answers)
                Console.WriteLine(answer);

        }

        public static string reverseString(string input)
        {
            // Даже си правя сам метода вместо да използвам LINQ

            bool invalid = false;
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '_' && input[i] == ' ')
                {
                    invalid = true;
                    break;
                }
                stack.Push(input[i]);
            }

            if (invalid) return "";

            string output = "";
            foreach (var c in stack)
                output += c;

            return output;
        }
    }
}
