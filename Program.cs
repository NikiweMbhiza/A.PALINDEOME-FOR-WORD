using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.PALINDEOME_FOR_WORD
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a word to check if it's a palindrome:");
            string word = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("Invalid input! Please enter a word.");
                return;
            }

            // Convert to lowercase to ensure case-insensitive comparison
            string lowerCaseWord = word.ToLower();
            string reversedWord = ReverseString(lowerCaseWord);

            if (lowerCaseWord == reversedWord)
            {
                Console.WriteLine($"'{word}' is a palindrome.");
            }
            else
            {
                Console.WriteLine($"'{word}' is not a palindrome.");
            }

            Console.ReadKey();
        }

        static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }

        
    }
    
}
