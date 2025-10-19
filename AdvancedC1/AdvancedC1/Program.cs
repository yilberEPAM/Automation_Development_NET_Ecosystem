using DelegatesPractice.Tests;
namespace DelegatesPractice
{
    public class Program
    {
        public delegate float CalculateTotal(float subtotal);
        public delegate void CalculateTotalRef(ref float subtotal);
        public delegate void PrintMessage(string msg);

        static void Main(string[] args)
        {
            var tests = new FlightTests();
            tests.DomesticFlight_CalculatesCorrectTotal();
            tests.InternationalFlight_CalculatesCorrectTotal();
            tests.InternationalFlight_SeniorDiscount_AppliesCorrectly();
            tests.InternationalFlight_InsuranceCost_CalculatesCorrectly();
            tests.InternationalFlight_CostWithInsuranceRef_CalculatesCorrectly();
            tests.AnonymousDelegate_PrintsCorrectMessage();
        }
    }
}