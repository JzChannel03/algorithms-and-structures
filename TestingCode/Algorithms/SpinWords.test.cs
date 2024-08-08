using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCode.Algorithms
{
    public class SpinWordsTest
    {
        [Fact]
        public void Run_ReversesWordsWithSixOrMoreLetters()
        {
            // Arrange
            string input = "Hey fellow warriors";
            string expected = "Hey wollef sroirraw";

            // Act
            string result = SpinWords.Run(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Run_DoesNotChangeShortWords()
        {
            // Arrange
            string input = "This is a test";
            string expected = "This is a test";

            // Act
            string result = SpinWords.Run(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Run_ReversesPalindromicWordsWithSixOrMoreLetters()
        {
            // Arrange
            string input = "The racecar level rotor";
            string expected = "The racecar level rotor";

            // Act
            string result = SpinWords.Run(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Run_HandlesSingleLongWord()
        {
            // Arrange
            string input = "abcdefghijklmnopqrstuvwxyz";
            string expected = "zyxwvutsrqponmlkjihgfedcba";

            // Act
            string result = SpinWords.Run(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Run_HandlesEmptyString()
        {
            // Arrange
            string input = "";
            string expected = "";

            // Act
            string result = SpinWords.Run(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
