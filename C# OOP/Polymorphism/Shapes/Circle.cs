﻿
using System;

namespace Shapes
{
    public class Circle : Shape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea() => Math.PI * Math.Pow(this.radius, 2);

        public override double CalculatePerimeter() => 2 * Math.PI * this.radius;
        public override string Draw()
        {
            return base.Draw() + Environment.NewLine + $"Drawing Circle";
        }

    }
}
