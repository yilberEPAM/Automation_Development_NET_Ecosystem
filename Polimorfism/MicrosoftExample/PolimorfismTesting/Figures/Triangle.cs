using PolimorfismTesting.Draw;

namespace PolimorfismTesting.Figures
{
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }
    }
}
