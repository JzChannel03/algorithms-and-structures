using Algorithms;

namespace TestingCode.Algorithms
{
    public class DuplicateCountTest
    {
        [Fact]
        public void Run_ReturnsCorrectCount_ForCaseInsensitiveDuplicates()
        {
            // Arrange
            string input = "Indivisibilities";
            int expected = 2;

            // Act
            int duplicates = DuplicateCount.Run(input);

            // Assert
            Assert.Equal(expected, duplicates);
        }

        [Fact]
        public void Run2_ReturnsCorrectCount_ForCaseInsensitiveDuplicates()
        {
            // Arrange
            string input = "Indivisibilities";
            int expected = 2;

            // Act
            int result = DuplicateCount.Run2(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Run_ReturnsCorrectCount_ForDifferentInput()
        {
            // Arrange
            string input = "aA11";
            int expected = 2;

            // Act
            int duplicates = DuplicateCount.Run(input);

            // Assert
            Assert.Equal(expected, duplicates);
        }

        [Fact]
        public void Run2_ReturnsCorrectCount_ForDifferentInput()
        {
            // Arrange
            string input = "aA11";
            int expected = 2;

            // Act
            int result = DuplicateCount.Run2(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
