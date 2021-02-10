using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fractals
{
    class CantorSet : Fractal
    {
        // Расстояние между отрезками соседних итераций.
        public override int Distance { get; set; } = 70;

        /// <summary>
        ///  Метод, вызывающий рекурсивную функцию для рисования фрактала множество Кантора.
        /// </summary>
        /// <param name="pictureWidth"> Ширина картинки. </param>
        /// <param name="pictureHeight"> Высота картинки. </param>
        /// <param name="gr"> Графика. </param>
        /// <param name="colorList"> Список цветов градиента. </param>
        public override void Draw(int pictureWidth, int pictureHeight, Graphics gr, List<Color> colorList)
        {
            // Номер итерации.
            int step = 1;

            var p = new Pen(colorList[step - 1], 10);

            // Рисование первого отрезка.
            gr.DrawLine(p, (float)pictureWidth / 100, (float)pictureHeight / 20, (float)pictureWidth * 99 / 100, (float)pictureHeight / 20);

            // Вызов рекурсивной функции для рисования фрактала.
            DrawSet(step + 1, pictureWidth / 100, pictureHeight / 20, pictureWidth * 99 / 100, pictureHeight / 20, gr, colorList);

        }

        /// <summary>
        /// Метод, рекурсивно рисующий фрактал множество Кантора.
        /// </summary>
        /// <param name="step"> Номер итерации. </param>
        /// <param name="x1"> Абсцисса начала отрезка. </param>
        /// <param name="y1"> Ордината начала отрезка. </param>
        /// <param name="x2"> Абсцисса конца отрезка. </param>
        /// <param name="y2"> Ордината конца отрезка. </param>
        /// <param name="gr"> Графика. </param>
        /// <param name="colorList"> Список цветов градиента. </param>
        void DrawSet(int step, float x1, float y1, float x2, float y2, Graphics gr, List<Color> colorList)
        {
            // Условие выхода из рекурсии.
            if (step > RecursionDepth) return;

            var pen = new Pen(colorList[step - 1], 10);

            // Рисование двух отрезков длиной в три раза меньше предыдущего.
            gr.DrawLine(pen, x1, y1 + Distance, (2 * x1 + x2) / 3, y2 + Distance);
            gr.DrawLine(pen, x2, y2 + Distance, (2 * x2 + x1) / 3, y2 + Distance);

            // Вызов рекурсивной функции для каждого из отрезков.
            DrawSet(step + 1, x1, y1 + Distance, (2 * x1 + x2) / 3, y2 + Distance, gr, colorList);
            DrawSet(step + 1, x2, y2 + Distance, (2 * x2 + x1) / 3, y2 + Distance, gr, colorList);
        }
    }
}
