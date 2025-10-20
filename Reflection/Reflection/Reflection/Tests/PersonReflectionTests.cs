using Reflection.Classes;
using System.Reflection;

namespace Reflection.Tests
{
    [TestFixture]
    public class PersonReflectionTests
    {
        [Test]
        public void CanAccessPrivateProperty_Age_UsingReflection()
        {
            var person = new Person("Alice", 30);

            var type = typeof(Person);
            var ageProperty = type.GetProperty("Age", BindingFlags.Instance | BindingFlags.NonPublic);

            Assert.IsNotNull(ageProperty);

            var ageValue = ageProperty.GetValue(person);

            Assert.That(ageValue, Is.EqualTo(30));
        }

        [Test]
        public void CanSetPrivateProperty_Age_UsingReflection()
        {
            var person = new Person("Bob", 25);

            var type = typeof(Person);
            var ageProperty = type.GetProperty("Age", BindingFlags.Instance | BindingFlags.NonPublic);
            ageProperty.SetValue(person, 40);

            var info = person.GetInfo();

            Assert.That(info, Is.EqualTo("Bob is 40 years old."));
        }
    }
}
