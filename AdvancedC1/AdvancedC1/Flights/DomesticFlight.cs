namespace DelegatesPractice.Flights
{
    public class DomesticFlight
    {
        float Vat
        {
            get
            {
                if (RoundTrip)
                    return 0.16f;
                return 0.04f;
            }
        }
        float Tua
        {
            get
            {
                return 220f;
            }
        }
        public bool RoundTrip { get; set; }
        public float CalculateTotalAmount(float amount)
        {
            return amount + amount * Vat + Tua;
        }
    }
}
