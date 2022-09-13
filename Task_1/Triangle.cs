﻿using System;

namespace Task_1
{
    internal class Triangle : GeometricFigure, IGeometricFigure
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
