namespace DelegatesPractice.Flights
{
    public class InternationalFlight
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
                return 360f;
            }
        }
        float FederalSecurityTax
        {
            get
            {
                return 190.75f;
            }
        }
        public bool RoundTrip { get; set; }
        public int Destination { get; set; }
        public float CalculateTotalAmount(float amount)
        {
            float total = amount + amount * Vat + Tua;
            if (Destination == 559)
                return total + FederalSecurityTax;
            return total;
        }
        public void CalculateTotalWithTaxes(ref float amount)
        {
            float total = amount + amount * Vat + Tua;
            if (Destination == 559)
                total += FederalSecurityTax;
            amount = total;
        }
    }
}
