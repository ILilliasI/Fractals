using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fractals
{
    class SierpinskiCarpet : Fractal
    {
        // Номер цвета, которым закрашивается квадрат.
        int color;
        // Количество закрашенных квадратов в большом квадрате.
        int rectangleCount;
        // Часть квадратов, которые надо закрасить текущим цветом.
        int part;

        /// <summary>
        /// Метод, вызывающий рекурсивную функцию для рисования фрактала ковёр Серпинского.
        /// </summary>
        /// <param name="pictureWidth"> Ширина картинки. </param>
        /// <param name="pictureHeight"> высота картинки. </param>
        /// <param name="gr"> Графика. </param>
        /// <param name="colorList"> Список цветов градиента. </param>
        public override void Draw(int pictureWidth, int pictureHeight, Graphics gr, List<Color> colorList)
        {
            int step = 1;

            rectangleCount = 0;
            color = 0;
            part = 1;

            DrawRectangle(step, new RectangleF(0, 0, pictureWidth, pictureHeight), gr, colorList);
        }

        /// <summary>
        /// Метод, рекурсивно рисующий фрактал ковёр Серпинского. 
        /// </summary>
        /// <param name="step"> Номер итерации. </param>
        /// <param name="carpet"> Квадрат. </param>
        /// <param name="gr"> Графика. </param>
        /// <param name="colorList"> Список цветов градиента. </param>
        void DrawRectangle(int step, RectangleF carpet, Graphics gr, List<Color> colorList)
        {
            // Обновление параметров цвета, если все 8 маленьких квадратов закрашены.
            if (rectangleCount == 8) { color = 0; rectangleCount = 0; part = 1; }

            // Обновление параметров цвета, если вся часть маленьких квадратов закрашена цветом.
            if (((double)rectangleCount >= (double)(8 * part) / colorList.Count)) { color++; part++; }

            var brush = new SolidBrush(colorList[color]);

            if (step == RecursionDepth)
            {
                rectangleCount++;
                // Отрисовка квадрата.
                gr.FillRectangle(brush, carpet);
            }
            else if (step < RecursionDepth)
            {
                // Вычисление 1/3 стороны квадрата.
                var width = carpet.Width / 3f;

                // Координаты верхней левой вершины квадрата.
                var x1 = carpet.Left;
                var y1 = carpet.Top;
                var x2 = x1 + width;
                var y2 = y1 + width;
                var x3 = x1 + 2f * width;
                var y3 = y1 + 2f * width;

                // Вызов рекурсивной функции для 8 квадратов, составляющих исходный квадрат.
                DrawRectangle(step + 1, new RectangleF(x1, y1, width, width), gr, colorList);
                DrawRectangle(step + 1, new RectangleF(x2, y1, width, width), gr, colorList);
                DrawRectangle(step + 1, new RectangleF(x3, y1, width, width), gr, colorList);
                DrawRectangle(step + 1, new RectangleF(x1, y2, width, width), gr, colorList);
                DrawRectangle(step + 1, new RectangleF(x3, y2, width, width), gr, colorList);
                DrawRectangle(step + 1, new RectangleF(x1, y3, width, width), gr, colorList);
                DrawRectangle(step + 1, new RectangleF(x2, y3, width, width), gr, colorList);
                DrawRectangle(step + 1, new RectangleF(x3, y3, width, width), gr, colorList);
            }
        }
    }
}
