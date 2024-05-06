using System;
using System.Collections.Generic;
using System.Text;

namespace Psychometria
{
    public class Figure
    {

            public string name;
            public ChessFigureType color;
            public List<float> confidences;
            public Position position;
            public Position humanablePosition;
    }
}
