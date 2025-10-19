using TupleTesting.Classes;

namespace TupleTesting.Tests
{
    [TestFixture]
    public class PersonServiceTests
    {
        [Test]
        public void GetPersonInfo_ReturnsCorrectTuple()
        {
            var service = new PersonService();
            var result = service.GetPersonInfo(1);

            Assert.That(result.Name, Is.EqualTo("Alice"));
            Assert.That(result.Age, Is.EqualTo(30));
        }

        [Test]
        public void GetPersonInfo_ReturnsUnknownForInvalidId()
        {
            var service = new PersonService();
            var result = service.GetPersonInfo(99);

            Assert.That(result.Name, Is.EqualTo("Unknown"));
            Assert.That(result.Age, Is.EqualTo(0));
        }

        [Test]
        public void GetDetailedPersonInfo_ReturnsIsAdultTrue()
        {
            var service = new PersonService();
            var result = service.GetDetailedPersonInfo(2);

            Assert.That(result.Name, Is.EqualTo("Bob"));
            Assert.That(result.Age, Is.EqualTo(25));
            Assert.IsTrue(result.IsAdult);
        }

        [Test]
        public void GetDetailedPersonInfo_ReturnsIsAdultFalse()
        {
            var service = new PersonService();
            var result = service.GetDetailedPersonInfo(99);

            Assert.That(result.Name, Is.EqualTo("Unknown"));
            Assert.That(result.Age, Is.EqualTo(0));
            Assert.IsFalse(result.IsAdult);
        }
    }
}
