using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitnine_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string input_word = Console.ReadLine();

            if (IsPalindrome(input_word))
            {
                Console.WriteLine("The word is a palindrome.");
            }
            else
            {
                string reversed = ReverseString(input_word);
                Console.WriteLine($"The word is not a palindrome. Reversed word is: {reversed}");
            }

            Console.ReadKey();
        }

        public static string ReverseString(string input_word)
        {
            char[] char_array = input_word.ToCharArray();
            Array.Reverse(char_array);

            return new string(char_array);
        }

        public static bool IsPalindrome(string word)
        {
            int left = 0;
            int right = word.Length - 1;

            while (left < right)
            {
                if (word[left] != word[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
