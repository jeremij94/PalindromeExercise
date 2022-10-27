using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a word to see if it is indeed a palindrome: ");
            var input = Console.ReadLine().ToLower();

            WordSmith.IsAPalindrome(input);

        }
    }
}
