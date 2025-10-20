using PolimorfismTesting.Action;

namespace PolimorfismTesting.Figures
{
    public class Square : Drawing
    {
        public double Length { get; set; }
        public Square()
        {
            Length = 6;
        }
        public override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }
}
