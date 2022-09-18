using System;

namespace Task_1
{
    internal class Triangle : GeometricFigure, ISimpleNAngle
    {
        double sideLengthAB;
        double sideLengthBC;
        double sideLengthAC;
        const string exMessage = "невозможно создать треугольник";

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
                };
            }
        }

        public double AC
        {
            get { return sideLengthAC; }
            private set
            {
                if (value > 0)
                {
                    sideLengthAC = value;
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
                double p = (AB + BC + AC) / 2;
                double heigth = 2 * Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC) / AC);
                return heigth;
            }
        }
        public double Base
        {
            get { return AC; }
        }
        public double Angle
        {
            get
            {
                return (Math.Acos((Math.Pow(AB, 2) + Math.Pow(AC, 2) - Math.Pow(BC, 2)) / (2 * AB * AC))) * 180 / Math.PI;
            }
        }
        public double LengthSide
        {
            get { return AC; }
        }
        public int NumberOfSide
        {
            get 
            {
                double[] ar = {AB, BC, AC};
                return ar.Length; 
            }
        }

        public Triangle(double sideLengthAB, double sideLengthBC, double sideLengthAC)
        {
            AB = sideLengthAB;
            BC = sideLengthBC;
            AC = sideLengthAC;

            if (AB + AC > BC && AB + BC > AC && AC + BC > AB)
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
            return $"Периметр треугольника равен {figurePerimeter:F3}" +
                $"{Environment.NewLine}Площадь треугольника равна {figureArea:F3}";
        }

        public double Perimetr()
        {
            return AB + BC + AC;
        }

        public double Area()
        {
            double halfPerimeter = (AB + AC + BC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - AB) * (halfPerimeter - AC) * (halfPerimeter - BC));
        }
    }
}
