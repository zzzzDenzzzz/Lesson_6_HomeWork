using System;

namespace Task_1
{
    internal class Rhomb : GeometricFigure, IGeometricFigure
    {
        double sideLength;
        double angleInRadians;
        const string exMessage = "невозможно создать ромб";

        public double Side
        {
            get { return sideLength; }
            set
            {
                if (value > 0)
                {
                    sideLength = value;
                }
                else
                {
                    throw new ArgumentException(exMessage);
                }
            }
        }

        public double Angle
        {
            get { return angleInRadians; }
            private set
            {
                if (value > 0 && value < 90)
                {
                    angleInRadians = Math.PI * value / 180;
                }
                else
                {
                    throw new ArgumentException(exMessage);
                }
            }
        }

        public Rhomb(double sideLength, double angle)
        {
            Side = sideLength;
            Angle = angle;

            figurePerimeter = Perimetr();
            figureArea = Area();
        }

        public override string ToString()
        {
            return $"Периметр ромба равен {figurePerimeter:F3}" +
                $"{Environment.NewLine}Площадь ромба равна {figureArea:F3}";
        }

        public double Perimetr()
        {
            return 4 * Side;
        }

        public double Area()
        {
            return Math.Pow(Side, 2) * Math.Sin(Angle);
        }
    }
}
