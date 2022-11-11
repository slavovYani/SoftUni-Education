
namespace Shapes
{
    public class Rectangle : Shape
    {
        private readonly double height;
        private readonly double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public override double CalculateArea() => height * width;
        public override double CalculatePerimeter() => 2 * (height * width);
        public override string Draw()
        {
            return $"Drawing Rectangle";
        }

    }
}
