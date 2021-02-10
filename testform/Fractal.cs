using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Fractals
{
    class Fractal
    {
        // Глубина рекурсии.
        public int RecursionDepth { get; set; } = 5;

        // Переопределяемое свойство угла поворота правого отрезка.
        public virtual double RightAng { get; set; }
        // Переопределяемое свойство угла поворота левого отрезка.
        public virtual double LeftAng { get; set; }
        // Переопределяемое свойство отношения отрезков соседних итераций.
        public virtual double SegmentsRatio { get; set; }

        // Переопределяемое свойство расстояния между отрезками.
        public virtual int Distance { get; set; }

        /// <summary>
        /// Переопределяемый медод для вызова рекурсивной функции рисования фрактала.
        /// </summary>
        /// <param name="pictureWidth"> Ширина картинки. </param>
        /// <param name="pictureHeight"> Высота картинки. </param>
        /// <param name="gr"> Графика. </param>
        /// <param name="colorList"> Список цветов градиента. </param>
        public virtual void Draw(int pictureWidth, int pictureHeight, Graphics gr, List<Color> colorList) { }
    }
}
