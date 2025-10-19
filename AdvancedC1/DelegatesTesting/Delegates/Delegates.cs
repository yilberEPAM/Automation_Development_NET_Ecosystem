namespace DelegatesTesting.Delegates
{
    public class Delegates
    {
        public delegate float CalculateTotal(float subtotal);
        public delegate void CalculateTotalRef(ref float subtotal);
        public delegate void PrintMessage(string msg);
    }
}
