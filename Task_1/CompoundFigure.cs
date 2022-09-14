using System;

namespace Task_1
{
    internal class CompoundFigure
    {
        //GeometricFigure[] geometricFigures;
        IGeometricFigure[] figure;

        //public CompoundFigure(params GeometricFigure[] geometricFigures)
        //{
        //    this.geometricFigures = geometricFigures;
        //}

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
            //foreach (var item in geometricFigures)
            //{
            //    if (item is Triangle)
            //    {
            //        area += (item as Triangle).Area();
            //    }
            //    else if (item is Square)
            //    {
            //        area += (item as Square).Area();
            //    }
            //    else if (item is Rhomb)
            //    {
            //        area += (item as Rhomb).Area();
            //    }
            //    else if (item is Rectangle)
            //    {
            //        area += (item as Rectangle).Area();
            //    }
            //    else if (item is Parallelogramm)
            //    {
            //        area += (item as Parallelogramm).Area();
            //    }
            //    else if (item is Ellipse)
            //    {
            //        area += (item as Ellipse).Area();
            //    }
            //    else if (item is Circle)
            //    {
            //        area += (item as Circle).Area();
            //    }
            //}
            return area;
        }

        public void PrintAreaCompaundFigure()
        {
            Console.WriteLine($"Площадь составной фигуры равна {AreaCompaundFigure():F3}");
        }
    }
}
