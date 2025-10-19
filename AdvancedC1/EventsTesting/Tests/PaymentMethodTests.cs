using EventsTesting.Enums;
using EventsTesting.Payments;

namespace EventsTesting.Tests
{
    [TestFixture]
    public class PaymentMethodTests
    {
        [Test]
        public void Setting_Valid_PaymentType_Raises_Success_Event()
        {
            var paymentMethod = new PaymentMethod();
            PaymentMethodChangedEventArgs eventArgs = null;
            paymentMethod.PaymentMethodChanged += (sender, args) => eventArgs = args;

            paymentMethod.Type = PaymentType.Card;

            Assert.IsNotNull(eventArgs, "Event should have been raised.");
            Assert.That(eventArgs.AlertType, Is.EqualTo(AlertType.Success));
            Assert.That(eventArgs.PaymentType, Is.EqualTo(PaymentType.Card));
        }

        [Test]
        public void Setting_Invalid_PaymentType_Raises_Error_Event()
        {
            var paymentMethod = new PaymentMethod();
            PaymentMethodChangedEventArgs eventArgs = null;
            paymentMethod.PaymentMethodChanged += (sender, args) => eventArgs = args;

            paymentMethod.Type = (PaymentType)99;

            Assert.IsNotNull(eventArgs, "Event should have been raised.");
            Assert.That(eventArgs.AlertType, Is.EqualTo(AlertType.Error));
            Assert.That(eventArgs.PaymentType, Is.EqualTo(default(PaymentType)));
        }

        [Test]
        public void Setting_Transfer_PaymentType_Raises_Success_Event()
        {
            var paymentMethod = new PaymentMethod();
            PaymentMethodChangedEventArgs eventArgs = null;
            paymentMethod.PaymentMethodChanged += (sender, args) => eventArgs = args;

            paymentMethod.Type = PaymentType.Transfer;

            Assert.IsNotNull(eventArgs, "Event should have been raised.");
            Assert.That(eventArgs.AlertType, Is.EqualTo(AlertType.Success));
            Assert.That(eventArgs.PaymentType, Is.EqualTo(PaymentType.Transfer));
        }
    }
}
