using System;

namespace Task_1
{
    internal class Circle : GeometricFigure, IGeometricFigure
    {
        double radius;
        const string exMessage = "невозможно создать круг";

        public double Radius
        {
            get { return radius; }
            private set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new AggregateException(exMessage);
                }
            }
        }

        public override string ToString()
        {
            return $"Периметр круга равен {figurePerimeter:F3}" +
                $"{Environment.NewLine}Площадь круга равна {figureArea:F3}";
        }

        public Circle(double radius)
        {
            Radius = radius;

            figurePerimeter = Perimetr();
            figureArea = Area();
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double Perimetr()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
