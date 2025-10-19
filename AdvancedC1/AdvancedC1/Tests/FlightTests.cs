using DelegatesPractice.Flights;
using DelegatesPractice.Helpers;
using NUnit.Framework;
using static DelegatesPractice.Program;

namespace DelegatesPractice.Tests
{
    [TestFixture]
    public class FlightTests
    {
        [Test]
        public void DomesticFlight_CalculatesCorrectTotal()
        {
            DomesticFlight domesticFlight = new DomesticFlight { RoundTrip = true };
            CalculateTotal total = domesticFlight.CalculateTotalAmount;
            float price = 5500f;
            float expected = price + price * 0.16f + 220f;
            Assert.That(expected, Is.EqualTo(total(price)).Within(0.01f));
        }

        [Test]
        public void InternationalFlight_CalculatesCorrectTotal()
        {
            InternationalFlight internationalFlight = new InternationalFlight
            {
                RoundTrip = false,
                Destination = 559,
            };
            CalculateTotal total = internationalFlight.CalculateTotalAmount;
            float price = 9800f;
            float expected = price + price * 0.04f + 360f + 190.75f;
            Assert.That(expected, Is.EqualTo(total(price)).Within(0.01f));
        }

        [Test]
        public void InternationalFlight_SeniorDiscount_AppliesCorrectly()
        {
            InternationalFlight internationalFlight = new InternationalFlight
            {
                RoundTrip = false,
                Destination = 559,
            };
            CalculateTotal total = internationalFlight.CalculateTotalAmount;
            float price = 9800f;
            float subtotal = total(price);
            float expected = subtotal - 0.35f * subtotal;
            float result = FlightHelpers.CalculateWithSeniorDiscount(price, total);
            Assert.That(expected, Is.EqualTo(result).Within(0.01f));
        }

        [Test]
        public void InternationalFlight_InsuranceCost_CalculatesCorrectly()
        {
            InternationalFlight internationalFlight = new InternationalFlight
            {
                RoundTrip = false,
                Destination = 559,
            };
            CalculateTotal totalB = internationalFlight.CalculateTotalAmount;
            totalB += FlightHelpers.CalculateInsuranceTotal;
            float price = 9800f;
            float expected = totalB(price);
            float subtotal = internationalFlight.CalculateTotalAmount(price);
            float insurance = FlightHelpers.CalculateInsuranceTotal(subtotal);
            Assert.That(expected, Is.EqualTo(subtotal + insurance).Within(0.01f));
        }

        [Test]
        public void InternationalFlight_CostWithInsuranceRef_CalculatesCorrectly()
        {
            InternationalFlight internationalFlight = new InternationalFlight
            {
                RoundTrip = false,
                Destination = 559,
            };
            float price = 9800f;
            CalculateTotalRef tr = internationalFlight.CalculateTotalWithTaxes;
            tr += FlightHelpers.CalculateTotalWithInsuranceRef;
            float expected = price + price * 0.04f + 360f + 190.75f;
            expected += expected * 0.1f; // Seguro
            tr(ref price);
            Assert.That(expected, Is.EqualTo(price).Within(0.01f));
        }

        [Test]
        public void AnonymousDelegate_PrintsCorrectMessage()
        {
            string result = "";
            PrintMessage pm = delegate (string msg)
            {
                result = $"Message: {msg}";
            };
            pm("Anonymous delegate");
            Assert.That("Message: Anonymous delegate", Is.EqualTo(result));
        }
    }
}

