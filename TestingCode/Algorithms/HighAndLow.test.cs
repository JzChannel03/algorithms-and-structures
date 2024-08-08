using Algorithms;

namespace TestingCode.Algorithms
{
    public class HighAndLowTest
    {
        [Fact]
        public void Run_ReturnsMaxAndMin_ForMultipleNumbers()
        {
            // Arrange
            string input = "1 3 5 7 9";
            string expected = "9 1";

            // Act
            string result = HighAndLow.Run(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Run_ReturnsSameNumber_ForSingleNumber()
        {
            // Arrange
            string input = "42";
            string expected = "42 42";

            // Act
            string result = HighAndLow.Run(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Run_HandlesNegativeNumbers()
        {
            // Arrange
            string input = "-10 20 -30 40";
            string expected = "40 -30";

            // Act
            string result = HighAndLow.Run(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
