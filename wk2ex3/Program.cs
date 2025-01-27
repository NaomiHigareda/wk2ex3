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
            //cont the vowels
            int vowelCount = CountVowels(input);
            //print out the number of vowels
            Console.WriteLine($"The number of vowels in the string is: {vowelCount}");
        }
        //method to count vowels
        static int CountVowels(string str)
        {
            int count = 0;
            //loop for each character
            foreach (char c in str)
            {
                //check if its a vowel
                if (IsVowel(c))
                {
                    count++;
                }
            }
            return count; // Ensure a value is returned
        }
        //check if method is a vowel
         static bool IsVowel(char c)
        {
            // method to check if a character is a vowel
            char lowerC = char.ToLower(c);
            // return if true, otherwise false
            return lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u';
        }
    }
    }

