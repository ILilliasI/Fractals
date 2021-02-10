using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fractals
{
    class SierpinskiTriangle : Fractal
    {
        /// <summary>
        ///  Метод, вызывающий рекурсивную функцию для рисования фрактала треугольник Серпинского.
        /// </summary>
        /// <param name="pictureWidth"> Ширина картинки. </param>
        /// <param name="pictureHeight"> Высота картинки. </param>
        /// <param name="gr"> Графика. </param>
        /// <param name="colorList"> Список цветов градиента. </param>
        public override void Draw(int pictureWidth, int pictureHeight, Graphics gr, List<Color> colorList)
        {
            int step = 1;

            DrawTriangle(pictureWidth / 100, pictureHeight * 99 / 100, pictureWidth / 2, pictureHeight / 10, pictureWidth * 99 / 100, pictureHeight * 99 / 100, step, gr, colorList);
        }

        /// <summary>
        /// Метод, рекурсивно рисующий фрактал треугольник Серпинского.
        /// </summary>
        /// <param name="x1"> Абсцисса 1ой вершины треугольника. </param>
        /// <param name="y1"> Ордината 1ой вершины треугольника. </param>
        /// <param name="x2"> Абсцисса 2ой вершины треугольника. </param>
        /// <param name="y2"> Ордината 2ой вершины треугольника. </param>
        /// <param name="x3"> Абсцисса 3ей вершины треугольника. </param>
        /// <param name="y3"> Ордината 3ей вершины треугольника. </param>
        /// <param name="step"> Номер итерации. </param>
        /// <param name="gr"> Графика. </param>
        /// <param name="colorList"> Список цветов графиента. </param>
        void DrawTriangle(float x1, float y1, float x2, float y2, float x3, float y3, int step, Graphics gr, List<Color> colorList)
        {
            // Условие выхода из рекурсии.
            if (step > RecursionDepth) return;

            var pen = new Pen(colorList[step - 1]);

            if (step == 1)
            {
                // Рисование первого треугольника.
                gr.DrawLine(pen, x1, y1, x2, y2);
                gr.DrawLine(pen, x2, y2, x3, y3);
                gr.DrawLine(pen, x3, y3, x1, y1);
                step++;
                // Выход из рекурсии, если её глубина равна 1.
                if (step > RecursionDepth) return;
            }

            pen = new Pen(colorList[step - 1]);

            // Вычисление координат нового треугольника.
            float x1New = (x1 + x2) / 2;
            float y1New = (y1 + y2) / 2;

            float x2New = (x2 + x3) / 2;
            float y2New = (y2 + y3) / 2;

            float x3New = (x3 + x1) / 2;
            float y3New = (y3 + y1) / 2;

            // Рисование нового треугольника.
            gr.DrawLine(pen, x1New, y1New, x2New, y2New);
            gr.DrawLine(pen, x2New, y2New, x3New, y3New);
            gr.DrawLine(pen, x3New, y3New, x1New, y1New);

            // Вызов рекурсивной функции для трёх получившихся треугольников.
            DrawTriangle(x1, y1, x1New, y1New, x3New, y3New, step + 1, gr, colorList);
            DrawTriangle(x2, y2, x1New, y1New, x2New, y2New, step + 1, gr, colorList);
            DrawTriangle(x3, y3, x2New, y2New, x3New, y3New, step + 1, gr, colorList);
        }
    }
}
