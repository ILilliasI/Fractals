using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fractals
{
    class FractalTree : Fractal
    {
        // Угол наклона правого отрезка.
        public override double RightAng { get; set; } = Math.PI / 4;
        // Угол наклона левого отрезка.
        public override double LeftAng { get; set; } = Math.PI / 4;
        // Отношение отрезков соседних итераций.
        public override double SegmentsRatio { get; set; } = 0.7F;

        /// <summary>
        /// Метод, вызывающий рекурсивную функцию для рисования фрактала дерево Пифагора.
        /// </summary>
        /// <param name="pictureWidth"> Ширина картинки. </param>
        /// <param name="pictureHeight"> Высота картинки. </param>
        /// <param name="gr"> Графика. </param>
        /// <param name="colorList"> Список цветов графиента. </param> 
        public override void Draw(int pictureWidth, int pictureHeight, Graphics gr, List<Color> colorList)
        {
            // Длина первого отрезка.
            double length;

            if ((RecursionDepth > 5) && (SegmentsRatio == 0.7F)) length = pictureHeight * 2 / 10;
            else length = pictureHeight * 3 / 10;

            // Номер итерации.
            int step = 1;

            var p = new Pen(colorList[step - 1]);

            // Рисование первого отрезка.
            if ((RecursionDepth > 5) && (SegmentsRatio == 0.7F))
                gr.DrawLine(p, (float)pictureWidth / 2, (float)pictureHeight * 9 / 10, (float)pictureWidth / 2, (float)pictureHeight * 7 / 10);
            else
                gr.DrawLine(p, (float)pictureWidth / 2, (float)pictureHeight * 9 / 10, (float)pictureWidth / 2, (float)pictureHeight * 3 / 5);

            // Вызов рекурсивной функции для рисования фрактала.
            if ((RecursionDepth > 5) && (SegmentsRatio == 0.7F))
                DrawTree(pictureWidth / 2, pictureHeight * 7 / 10, step + 1, Math.PI / 2, length, gr, colorList);
            else
                DrawTree(pictureWidth / 2, pictureHeight * 3 / 5, step + 1, Math.PI / 2, length, gr, colorList);
        }

        /// <summary>
        /// Метод, рекурсивно рисующий фрактал дерево Пифагора.
        /// </summary>
        /// <param name="x"> Абсцисса начала отрезка. о</param>
        /// <param name="y"> Ордината начала отрезка. </param>
        /// <param name="step"> Номер итерации. </param>
        /// <param name="angle"> Угол наклона первого отрезка. </param>
        /// <param name="length"> Длина отрезка предыдущей итерации. </param>
        /// <param name="gr"> Графика. </param>
        /// <param name="colorList"> Список цветов градиента. </param>
        void DrawTree(double x, double y, int step, double angle, double length, Graphics gr, List<Color> colorList)
        {
            // Условие выхода из рекурсии.
            if (step > RecursionDepth) return;

            var p = new Pen(colorList[step - 1]);

            length *= SegmentsRatio;

            // Координаты для концов левого и правого отрезков.
            double xnewLeft = Math.Round(x + length * Math.Cos(angle + LeftAng));
            double ynewLeft = Math.Round(y - length * Math.Sin(angle + LeftAng));
            double xnewRight = Math.Round(x + length * Math.Cos(angle - RightAng));
            double ynewRight = Math.Round(y - length * Math.Sin(angle - RightAng));

            // Рисование левого и правого отрезков.
            gr.DrawLine(p, (float)x, (float)y, (float)xnewLeft, (float)ynewLeft);
            gr.DrawLine(p, (float)x, (float)y, (float)xnewRight, (float)ynewRight);

            // Вызывов рекурсивной функции для двух вершин-потомков.
            DrawTree(xnewLeft, ynewLeft, step + 1, angle + LeftAng, length, gr, colorList);
            DrawTree(xnewRight, ynewRight, step + 1, angle - RightAng, length, gr, colorList);
        }
    }
}