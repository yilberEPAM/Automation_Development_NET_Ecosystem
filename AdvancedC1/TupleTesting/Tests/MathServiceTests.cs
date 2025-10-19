using TupleTesting.Services;

namespace TupleTesting.Tests
{
    [TestFixture]
    public class MathServiceTests
    {
        [Test]
        public void SumAndProduct_ReturnsCorrectTuple()
        {
            var service = new MathService();
            var result = service.SumAndProduct(3, 4);

            Assert.That(result.Sum, Is.EqualTo(7));
            Assert.That(result.Product, Is.EqualTo(12));
        }

        [Test]
        public void Analyze_ReturnsCorrectMinMaxAvg()
        {
            var service = new MathService();
            var result = service.Analyze(1, 2, 3, 4, 5);

            Assert.That(result.Min, Is.EqualTo(1));
            Assert.That(result.Max, Is.EqualTo(5));
            Assert.That(result.Average, Is.EqualTo(3.0));
        }

        [Test]
        public void Analyze_ThrowsException_OnEmptyInput()
        {
            var service = new MathService();
            Assert.Throws<ArgumentException>(() => service.Analyze());
        }
    }
}
