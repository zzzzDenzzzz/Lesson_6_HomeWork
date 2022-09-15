using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal interface IFigure
    {
        void Color(int color);
        void CursorPosition(int left, int top);
        void Draw();
        void Size();
    }
}
