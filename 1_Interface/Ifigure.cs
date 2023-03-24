using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Interface
{
    interface IFigure
    {
        void FigureType();
        void Area();
        double PropA { get; set; }
    }
    interface IFigureAngle : IFigure
    {
        void Diagonal();
        double PropB { get; set; }        
    }
    interface IFigureRound : IFigure
    {
        void Length();
    }
}

