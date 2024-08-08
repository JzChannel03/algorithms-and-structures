using Algorithms;

namespace TestingCode.Algorithms
{
    public class ArrayDiffTest
    {
        [Fact]
        public void Run_RemovesElements_WhenMultipleOccurrences()
        {
            // Arrange
            var input = new int[] { 1, 2, 2, 2, 3 };
            var input2 = new int[] { 2 };
            var expected = new int[] { 1, 3 };

            // Act
            var result = ArrayDiff.Run(input, input2);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Run_ReturnsOriginalArray_WhenNoElementsToRemove()
        {
            // Arrange
            var input = new int[] { 1, 2, 3, 4, 5 };
            var input2 = new int[] { 6 };
            var expected = new int[] { 1, 2, 3, 4, 5 };

            // Act
            var result = ArrayDiff.Run(input, input2);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Run_ReturnsEmptyArray_WhenAllElementsRemoved()
        {
            // Arrange
            var input = new int[] { 1, 1, 1 };
            var input2 = new int[] { 1 };
            var expected = new int[] { };

            // Act
            var result = ArrayDiff.Run(input, input2);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Run_RemovesElements_WhenInput2HasMultipleElements()
        {
            // Arrange
            var input = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var input2 = new int[] { 2, 4, 6 };
            var expected = new int[] { 1, 3, 5, 7 };

            // Act
            var result = ArrayDiff.Run(input, input2);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
