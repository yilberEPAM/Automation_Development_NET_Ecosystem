using EventsTesting.Enums;
using System;
namespace EventsTesting.Payments
{
    public class PaymentMethod
    {
        private PaymentType type;
        public event EventHandler<PaymentMethodChangedEventArgs> PaymentMethodChanged;
        public PaymentType Type
        {
            get
            {
                return type;
            }
            set
            {
                AlertType alertType = AlertType.Error;
                if (value.Equals(PaymentType.Card)
                    || value.Equals(PaymentType.Transfer)
                    || value.Equals(PaymentType.Others))
                {
                    type = value;
                    alertType = AlertType.Success;
                }
                PaymentMethodChangedEventArgs args = new PaymentMethodChangedEventArgs
                {
                    PaymentType = type,
                    AlertType = alertType
                };
                PaymentMethodChanged?.Invoke(this, args);
            }
        }
    }
}
