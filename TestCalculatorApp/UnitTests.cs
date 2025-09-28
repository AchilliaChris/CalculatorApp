using CalculatorApp;
namespace TestCalculatorApp
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void SubtractTest() => Assert.That(Solution.Run("subtracting", 10, 2), Is.EqualTo("8"));
        [Test]
        public void AddingTest() => Assert.That(Solution.Run("adding", 3, 5), Is.EqualTo("8"));
        [Test]
        public void MultiplyTest() => Assert.That(Solution.Run("multiplying", 4, 2), Is.EqualTo("8"));
        [Test]
        public void DivideTest() => Assert.That(Solution.Run("dividing", 20, 2), Is.EqualTo("10"));
        [Test]
        public void SingleNegativeMultiplyTest() => Assert.That(Solution.Run("multiplying", 4, -2), Is.EqualTo("-8"));
        [Test]
        public void SingleNegativeDivideTest() => Assert.That(Solution.Run("dividing", 20, -2), Is.EqualTo("-10"));
        [Test]
        public void DoubleNegativeMultiplyTest() => Assert.That(Solution.Run("multiplying", -4, -2), Is.EqualTo("8"));
        [Test]
        public void DoubleNegativeDivideTest() => Assert.That(Solution.Run("dividing", -20, -2), Is.EqualTo("10"));

        // Additional test scenarios
        [Test]
        public void AddZeroTest() => Assert.That(Solution.Run("adding", 0, 5), Is.EqualTo("5"));
        [Test]
        public void SubtractZeroTest() => Assert.That(Solution.Run("subtracting", 5, 0), Is.EqualTo("5"));
        [Test]
        public void MultiplyByZeroTest() => Assert.That(Solution.Run("multiplying", 5, 0), Is.EqualTo("0"));
        [Test]
        public void DivideByZeroTest() => Assert.Throws<ArgumentException>(() => Solution.Run("dividing", 5, 0));
        [Test]
        public void AddNegativeNumbersTest() => Assert.That(Solution.Run("adding", -3, -5), Is.EqualTo("-8"));
        [Test]
        public void SubtractNegativeNumbersTest() => Assert.That(Solution.Run("subtracting", -3, -5), Is.EqualTo("2"));
        [Test]
        public void MultiplyLargeNumbersTest() => Assert.That(Solution.Run("multiplying", 100000, 100000), Is.EqualTo("10000000000"));
        [Test]
        public void DivideLargeNumbersTest() => Assert.That(Solution.Run("dividing", 100000000, 10000), Is.EqualTo("10000"));
        [Test]
        public void InvalidOperationTest() => Assert.Throws<ArgumentException>(() => Solution.Run("unknown", 1, 2));

    }
}
