using PolimorfismTesting.Action;
using PolimorfismTesting.Figures;

namespace PolimorfismTesting.Tests
{
    [TestFixture]
    public class DrawingPolymorphismTests
    {
        [Test]
        public void Area_Circle_ReturnsCorrectArea()
        {
            // Arrange
            Drawing drawing = new Circle(); // Polimorfismo
            double expected = 3.14 * 5 * 5;

            // Act
            double area = drawing.Area();

            // Assert
            Assert.That(area, Is.EqualTo(expected).Within(0.0001));
        }

        [Test]
        public void Area_Rectangle_ReturnsCorrectArea()
        {
            // Arrange
            Drawing drawing = new Rectangle(); // Polimorfismo
            double expected = 5.3 * 3.4;

            // Act
            double area = drawing.Area();

            // Assert
            Assert.That(area, Is.EqualTo(expected).Within(0.0001));
        }

        [Test]
        public void Area_Square_ReturnsCorrectArea()
        {
            // Arrange
            Drawing drawing = new Square(); // Polimorfismo
            double expected = 6 * 6;

            // Act
            double area = drawing.Area();

            // Assert
            Assert.That(area, Is.EqualTo(expected).Within(0.0001));
        }

        [Test]
        public void Area_DrawingBase_ReturnsZero()
        {
            // Arrange
            Drawing drawing = new Drawing();

            // Act
            double area = drawing.Area();

            // Assert
            Assert.That(area, Is.EqualTo(0));
        }
    }
}
