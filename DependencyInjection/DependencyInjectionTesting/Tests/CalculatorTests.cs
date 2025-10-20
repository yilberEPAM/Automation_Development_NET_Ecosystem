using DependencyInjectionTesting.Classes;
using DependencyInjectionTesting.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionTesting.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private ServiceProvider _serviceProvider;

        [SetUp]
        public void Setup()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<ICalculator, Calculator>();
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        [Test]
        public void Add_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = _serviceProvider.GetService<ICalculator>();

            // Act
            var result = calculator.Add(2, 3);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TearDown]
        public void TearDown()
        {
            if (_serviceProvider != null)
            {
                _serviceProvider.Dispose();
            }
        }
    }
}
