using static DelegatesTesting.Delegates.Delegates;

namespace DelegatesPractice.Helpers
{
    public static class FlightHelpers
    {
        public static float CalculateWithSeniorDiscount(float amount, CalculateTotal total)
        {
            float subtotal = total(amount);
            return subtotal - (0.35f * subtotal);
        }

        public static float CalculateInsuranceTotal(float total)
        {
            float insurancePercentage = 0.1f;
            return total * insurancePercentage;
        }

        public static void CalculateTotalWithInsuranceRef(ref float total)
        {
            float insurancePercentage = 0.1f;
            total += total * insurancePercentage;
        }
    }
}
