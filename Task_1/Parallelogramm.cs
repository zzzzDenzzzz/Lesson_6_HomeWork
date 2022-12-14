using System;

namespace Task_1
{
    internal class Parallelogramm : GeometricFigure, ISimpleNAngle
    {
        double sideLengthAB;
        double sideLengthBC;
        double angleInRadians;
        const string exMessage = "невозможно создать параллелограмм";

        public double AB
        {
            get { return sideLengthAB; }
            private set
            {
                if (value > 0)
                {
                    sideLengthAB = value;
                }
                else
                {
                    throw new ArgumentException(exMessage);
                }
            }
        }

        public double BC
        {
            get { return sideLengthBC; }
            private set
            {
                if (value > 0)
                {
                    sideLengthBC = value;
                }
                else
                {
                    throw new ArgumentException(exMessage);
                }
            }
        }

        public double AngleP
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

        public double Heigth
        {
            get
            {
                return BC * Math.Sin(angleInRadians);
            }
        }
        public double Base
        {
            get { return BC; }
        }

        public double LengthSide
        {
            get { return AB; }
        }
        public int NumberOfSide
        {
            get
            {
                double[] ar = { AB, BC, AB, BC };
                return ar.Length;
            }
        }

        public double Angle
        {
            get { return Math.Asin(figureArea / (AB * BC)) * 180 / Math.PI; }
        }

        public Parallelogramm(double sideLengthAB, double sideLengthBC, double angle)
        {
            AB = sideLengthAB;
            BC = sideLengthBC;
            AngleP = angle;

            if (AB != BC)
            {
                figurePerimeter = Perimetr();
                figureArea = Area();
            }
            else
            {
                throw new ArgumentException(exMessage);
            }
        }

        public override string ToString()
        {
            return $"Периметр параллелограмма равен {figurePerimeter:F3}" +
                $"{Environment.NewLine}Площадь параллелограмма равна {figureArea:F3}";
        }

        public double Perimetr()
        {
            return 2 * (AB + BC);
        }

        public double Area()
        {
            return AB * BC * Math.Sin(AngleP);
        }
    }
}
