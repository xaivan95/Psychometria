using System;
using System.Collections.Generic;
using System.Text;

namespace Psychometria
{
    /// <summary>
    /// Интерфейс для фигуры, поддерживающей нотацию FEN
    /// </summary>
    public interface IFENFigure
    {
        /// <summary>
        /// Тип фигуры
        /// </summary>
        ChessFigureType FigureType { get; }
        /// <summary>
        /// Положение на доске
        /// </summary>
        Position Position { get; }
    }
}
