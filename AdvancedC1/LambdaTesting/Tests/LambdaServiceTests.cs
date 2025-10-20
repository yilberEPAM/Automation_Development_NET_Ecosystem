using LambdaTesting.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaTesting.Tests
{
    [TestFixture]
    public class LambdaServiceTests
    {
        [Test]
        public void Transform_SquaresNumbers()
        {
            var service = new LambdaService();
            var result = service.Transform(new List<int> { 1, 2, 3 }, x => x * x);
            CollectionAssert.AreEqual(new List<int> { 1, 4, 9 }, result);
        }

        [Test]
        public void Filter_ReturnsEvenNumbers()
        {
            var service = new LambdaService();
            var result = service.Filter(new List<int> { 1, 2, 3, 4 }, x => x % 2 == 0);
            CollectionAssert.AreEqual(new List<int> { 2, 4 }, result);
        }

        [Test]
        public void Aggregate_SumsNumbers()
        {
            var service = new LambdaService();
            var result = service.Aggregate(new List<int> { 1, 2, 3, 4 }, (a, b) => a + b);
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void ForEach_CollectsResults()
        {
            var service = new LambdaService();
            var output = new List<int>();
            service.ForEach(new List<int> { 1, 2, 3 }, x => output.Add(x * 10));
            CollectionAssert.AreEqual(new List<int> { 10, 20, 30 }, output);
        }

        [Test]
        public void Lambda_CapturesExternalVariable()
        {
            var service = new LambdaService();
            int factor = 3;
            var result = service.Transform(new List<int> { 1, 2 }, x => x * factor);
            CollectionAssert.AreEqual(new List<int> { 3, 6 }, result);
        }
    }
}
