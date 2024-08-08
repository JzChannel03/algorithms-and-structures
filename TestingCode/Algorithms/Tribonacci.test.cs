using Algorithms;

namespace TestingCode.Algorithms
{
    public class TribonacciTest
    {
        [Fact]
        public void Run_ReturnsEmptyArray_WhenNIsZero()
        {
            // Arrange
            double[] signature = { 1, 1, 1 };
            int n = 0;
            double[] expected = { };

            // Act
            double[] result = Tribonacci.Run(signature, n);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Run_ReturnsSignature_WhenNIsLessThanSignatureLength()
        {
            // Arrange
            double[] signature = { 1, 1, 1 };
            int n = 2;
            double[] expected = { 1, 1 };

            // Act
            double[] result = Tribonacci.Run(signature, n);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Run_CalculatesTribonacciSequence_CorrectlyForNSix()
        {
            // Arrange
            double[] signature = { 1, 1, 1 };
            int n = 6;
            double[] expected = { 1, 1, 1, 3, 5, 9 };

            // Act
            double[] result = Tribonacci.Run(signature, n);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Run_HandlesSingleElementSignature()
        {
            // Arrange
            double[] signature = [1];
            int n = 4;
            double[] expected = [1, 0, 0, 1];

            // Act
            double[] result = Tribonacci.Run(signature, n);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Run_HandlesTwoElementSignature()
        {
            // Arrange
            double[] signature = [1, 1];
            int n = 4;
            double[] expected = [1, 1, 0, 2];

            // Act
            double[] result = Tribonacci.Run(signature, n);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
