using System;

namespace Task_1
{
    internal class Rhomb : GeometricFigure
    {
        double sideLength;
        double angleInRadians;

        public Rhomb(double sideLength, double angle)
        {
            if (sideLength > 0 && angle > 0 && angle < 90)
            {
                this.sideLength = sideLength;
                angleInRadians = Math.PI * angle / 180;

                figurePerimeter = 4 * sideLength;
                figureArea = Math.Pow(sideLength, 2) * Math.Sin(angleInRadians);
            }
            else
            {
                throw new ArgumentException("невозможно создать ромб");
            }
        }

        public override string ToString()
        {
            return $"Периметр ромба равен {figurePerimeter:F3}{Environment.NewLine}Площадь ромба равна {figureArea:F3}";
        }
    }
}
