using System;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public static bool IsAPalindrome(string word)
        {
             if (word == null || word.Length == 0)
            {
                return false;
            }

            string lowerWord = word.ToLower();
            string reversed = "".ToLower();

            for (int i = (lowerWord.Length - 1); i >= 0; i--)
            {
                if (lowerWord[i].ToString() == " ")
                {
                    continue;
                }
                reversed += lowerWord[i];
            }
            return lowerWord == reversed;
        }
    }
}

