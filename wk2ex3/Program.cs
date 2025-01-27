using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk2ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print out the prompt to ask user to enter a string
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            int vowelCount = CountVowels(input);
            //print out the number of vowels
            Console.WriteLine($"The number of vowels in the string is: {vowelCount}");
        }
        static int CountVowels(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (IsVowel(c))
                {
                    count++;
                }
            }
            return count; // Ensure a value is returned
        }

        private static bool IsVowel(char c)
        {
            // Implement the IsVowel method to check if a character is a vowel
            char lowerC = char.ToLower(c);
            return lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u';
        }
    }
    }

