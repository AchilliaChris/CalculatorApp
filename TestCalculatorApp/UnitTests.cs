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
    }
}
