using System;
using System.Collections.Generic;
using System.Text;

namespace Psychometria
{
    /// <summary>
    /// Положение фигуры на доске
    /// </summary>
    public readonly struct Position : IEquatable<Position>
    {
        /// <summary>
        /// Вертикаль фигуры
        /// </summary>
        public readonly Vertical Horizontal;
        /// <summary>
        /// Горизонталь фигуры
        /// </summary>
        public readonly Horizontal Vertical;

        public Position(Vertical horizontal, Horizontal vertical)
        {
            Horizontal = horizontal;
            Vertical = vertical;
        }

        /// <summary>
        /// Переопределения операции сравнения
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return obj is Position position && Equals(position);
        }

        /// <summary>
        /// Реализация интерфейса IEquatable
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Position other)
        {
            return Horizontal == other.Horizontal &&
                   Vertical == other.Vertical;
        }

        /// <summary>
        /// Переопределение операции расчёта хэш кода
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Horizontal, Vertical);
        }

        /// <summary>
        /// Переопределение операции генерации строки
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Horizontal}{Vertical}";
        }
    }
}
