namespace Lab03_Review.Tests
{
    public class ReviewTests
    {
        [Fact]
        public void Challenge1_ProductOfThreeNumbers()
        {
            // Arrange
            int expected = 24;

            // Act
            int actual = Review.CalculateProduct("2 3 4");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Challenge2_GetAverage_Test()
        {
            // Arrange
            int[] inputRange = new int[] { 2, 4, 6, 8 }; // Test input
            double expectedAverage = 5.0; // Expected average for the test input

            // Act
            double result = Review.CalculateAverage(inputRange);

            // Assert
            Assert.Equal(expectedAverage, result, precision: 2);
        }

        [Fact]
        public void Challenge4_MostFrequentNumber()
        {
            // Arrange
            int[] numbers = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            int expected = 1;

            // Act
            int actual = Review.FindMostFrequentNumber(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Challenge5_FindMaximumValue()
        {
            // Arrange
            int[] numbers = { 2, 5, 1, 9, 4 };
            int expected = 9;

            // Act
            int actual = Review.FindMaximumValue(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }
    }