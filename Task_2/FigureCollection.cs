using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class FigureCollection
    {
        IFigure[] figures;

        public void PrintAll()
        {
            foreach (var figure in figures)
            {
                figure.Draw();
            }
        }
    }
}
