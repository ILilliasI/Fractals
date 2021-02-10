using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fractals
{
    class KochCurve : Fractal
    {
        /// <summary>
        ///  Метод, вызывающий рекурсивную функцию для рисования фрактала кривая Коха.
        /// </summary>
        /// <param name="pictureWidth"> Ширина картинки. </param>
        /// <param name="pictureHeight"> Высота картинки. </param>
        /// <param name="gr"> Графика. </param>
        /// <param name="colorList"> Список цветов графиента. </param>
        public override void Draw(int pictureWidth, int pictureHeight, Graphics gr, List<Color> colorList)
        {
            // Номер итерации.
            int step = 1;

            var pen = new Pen(colorList[0]);

            // Координаты конца и начала исходного отрезка.
            var point11 = new PointF(pictureWidth / 100, pictureHeight * 2 / 3);
            var point21 = new PointF(pictureWidth * 99 / 100, pictureHeight * 2 / 3);

            // Координаты вершин первого треугольника..
            var point12 = new PointF((2 * point11.X + point21.X) / 3, (2 * point11.Y + point21.Y) / 3);
            var point22 = new PointF((point11.X + 2 * point21.X) / 3, (point11.Y + 2 * point21.Y) / 3);
            var point32 = new PointF(pictureWidth * 49 / 100, (float)(pictureHeight * 2 / 3 - Math.Sqrt(3) * pictureWidth * 49 / 300));

            // Координаты вершин двух треугольников, противоположных сторонам, являющмися отрезками слева и справа от первого треугольника.
            var point31 = new PointF((point12.X + point11.X) / 2, 2 * point12.Y - point32.Y);
            var point33 = new PointF((point22.X + point21.X) / 2, 2 * point12.Y - point32.Y);

            // Рисование первого треугольника (без нижней стороны).
            gr.DrawLine(pen, point12, point32);
            gr.DrawLine(pen, point22, point32);

            // Рисование отрезков справа и слева от треугольника.
            gr.DrawLine(pen, point11, point12);
            gr.DrawLine(pen, point22, point21);

            // Вызов рекурсивной функции для сторон первого треугольника.
            DrawCurve(point22, point32, point12, step + 1, gr, colorList);
            DrawCurve(point32, point12, point22, step + 1, gr, colorList);
            // Вызов рекурсивной функции для отрезков слева и справа от первого треугольника.
            DrawCurve(point12, point11, point31, step + 1, gr, colorList);
            DrawCurve(point21, point22, point33, step + 1, gr, colorList);
        }

        /// <summary>
        /// Метод, рекурсивно рисующий фрактал кривую Коха.
        /// </summary>
        /// <param name="p1"> Вершина треугольника. </param>
        /// <param name="p2"> Вершина треугольника. </param>
        /// <param name="p3"> Вершина треугольника. </param>
        /// <param name="step"> Номер итерации. </param>
        /// <param name="gr">Графика. </param>
        /// <param name="colorList"> Список цветов градиента. </param>
        void DrawCurve(PointF p1, PointF p2, PointF p3, int step, Graphics gr, List<Color> colorList)
        {
            // Условие выхода из рекурсии.
            if (step > RecursionDepth) return;

            var pen = new Pen(colorList[step - 1]);
            var eraser = new Pen(Color.White, 1);

            // Нахождение точек, делящих отрезок на три части (первые две вершины треугольника).
            var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
            var p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
            // Нахождение координат последней вершины треугольника.
            var ps = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
            var p6 = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);

            // Рисование треугольника.
            gr.DrawLine(pen, p4, p6);
            gr.DrawLine(pen, p5, p6);
            gr.DrawLine(eraser, p4, p5);

            // Вызов рекурсивной функции для двух сторон треугольника и отрезков слева и справа от него.
            DrawCurve(p4, p6, p5, step + 1, gr, colorList);
            DrawCurve(p6, p5, p4, step + 1, gr, colorList);
            DrawCurve(p1, p4, new PointF((2 * p1.X + p3.X) / 3, (2 * p1.Y + p3.Y) / 3), step + 1, gr, colorList);
            DrawCurve(p5, p2, new PointF((2 * p2.X + p3.X) / 3, (2 * p2.Y + p3.Y) / 3), step + 1, gr, colorList);
        }
    }
}
