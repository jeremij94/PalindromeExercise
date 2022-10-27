using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        //Palindrome test to see whether a word is a palindrome

        [Theory]
        [InlineData("radar", true)] // ← you will need to put some test data and expected result here.  
        [InlineData("racecar", true)]
        [InlineData("bracket", false)]
        [InlineData("MOM", true)]
        [InlineData("Google", false)]
        [InlineData("", false)]
        [InlineData(null, false)]


        public void Palindrome_Test(string word, bool expected)
        {
            //Arrange
            var testDrome = new WordSmith();

            //Act
           
            var actual = WordSmith.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
