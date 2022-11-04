
using System;
using System.Text;

namespace _01.ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;



        public Box(double lenght, double width, double height)
        {
            this.Length = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return this.length; }

            private set
            {
                if (value <= 0) throw new ArgumentException(String.Format(ExceptionMessage.ValueIsLessThanZero, nameof(this.Length)));

                this.length = value;
            }
        }


        public double Width
        {
            get { return this.width; }

            private set
            {
                if (value <= 0) throw new ArgumentException(String.Format(ExceptionMessage.ValueIsLessThanZero, nameof(this.Width)));

                this.width = value;
            }
        }


        public double Height
        {
            get { return this.height; }

            private set
            {
                if (value <= 0) throw new ArgumentException(String.Format(ExceptionMessage.ValueIsLessThanZero, nameof(this.Height)));



                this.height = value;
            }
        }

        public double SurfaceArea() => 2 * (Length * Width + Length * Height + Width *Height);
        public double LateralSurfaceArea() => 2 * Height * (Length + Width);
        public double Volume() => Length * Width * Height;
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {this.SurfaceArea():f2}")
               .AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}")
                .AppendLine($"Volume - {this.Volume():f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
