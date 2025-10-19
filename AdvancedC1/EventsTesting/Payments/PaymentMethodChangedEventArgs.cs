using EventsTesting.Enums;

namespace EventsTesting.Payments
{
    public class PaymentMethodChangedEventArgs : EventArgs
    {
        public AlertType AlertType { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
