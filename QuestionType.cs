using System;
using System.Collections.Generic;
using System.Text;

namespace Psychometria
{
    /// <summary>
    /// Тип вопроса по методике
    /// </summary>
    public enum QuestionType
    {
        /// <summary>
        /// Вопрос - половина доски
        /// </summary>
        HalfBoard,
        /// <summary>
        /// Вопрос - горизонталь 1
        /// </summary>
        HorizontalLine1,
        /// <summary>
        /// Вопрос - горизонталь 2
        /// </summary>
        HorizontalLine2,
        /// <summary>
        /// Вопрос - вертикаль 1
        /// </summary>
        VerticalLine1,
        /// <summary>
        /// Вопрос - вертикаль 2
        /// </summary>
        VerticalLine2,
        /// <summary>
        /// Вопрос - ячейка
        /// </summary>
        Cell
    }
}
