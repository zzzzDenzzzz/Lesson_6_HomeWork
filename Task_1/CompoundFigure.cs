using System;

namespace Task_1
{
    internal class CompoundFigure
    {
        IGeometricFigure[] figure;

        public CompoundFigure(params IGeometricFigure[] geometricFigures)
        {
            figure = geometricFigures;
        }

        public double AreaCompaundFigure()
        {
            double area = 0;
            foreach (var item in figure)
            {
                area += item.Area();
            }
            return area;
        }

        public void PrintAreaCompaundFigure()
        {
            Console.WriteLine($"Площадь составной фигуры равна {AreaCompaundFigure():F3}");
        }
    }
}
