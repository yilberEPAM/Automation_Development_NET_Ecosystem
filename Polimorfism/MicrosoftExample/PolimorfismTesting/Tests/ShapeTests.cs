using MicrosoftExample;
using PolimorfismTesting.Draw;

namespace PolimorfismTesting.Tests
{
    [TestFixture]
    public class ShapeTests
    {
        [TestCase(typeof(Circle), "Drawing a circle")]
        [TestCase(typeof(Rectangle), "Drawing a rectangle")]
        [TestCase(typeof(Triangle), "Drawing a triangle")]
        public void Draw_ShouldPrintCorrectShapeMessage(Type shapeType, string expectedMessage)
        {
            // Arrange
            Shape? shape = Activator.CreateInstance(shapeType) as Shape;
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            shape.Draw();
            var output = stringWriter.ToString();

            // Assert
            StringAssert.Contains(expectedMessage, output);
            StringAssert.Contains("Performing base class drawing tasks", output);
        }

        [Test]
        public void Draw_BaseShape_ShouldPrintBaseMessageOnly()
        {
            // Arrange
            Shape shape = new Shape();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            shape.Draw();
            var output = stringWriter.ToString();

            // Assert
            Assert.That(output, Is.EqualTo("Performing base class drawing tasks\r\n"));
        }
    }
}
