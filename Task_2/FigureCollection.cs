using System;
using System.Threading;

namespace Task_2
{
    internal class FigureCollection
    {
        IFigure[] figures;

        public FigureCollection(params IFigure[] figures)
        {
            this.figures = figures;
        }

        public void PrintAll()
        {
            foreach (var figure in figures)
            {
                figure.Draw();
                Thread.Sleep(1500);
                Console.Clear();
            }
        }
    }
}
