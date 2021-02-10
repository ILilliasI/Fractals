using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals
{
    public partial class Fractals : Form
    {
        // Фрактал.
        Fractal fractal;

        // Начальный цвет градиента.
        static Color startColor = Color.Red;
        // Конечный цвет градиента.
        static Color endColor = Color.Aqua;
        // Список цветов градиента.
        List<Color> colorList;

        // Массив доступных значений глубины рекурсии.
        string[] recursionDepths = new string[15] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };

        // Массив доступных углов наклонов левого отрезка.
        string[] firstAngles = new string[4] { "pi/6", "pi/4", "pi/3", "pi/2" };
        // Массив доступных углов наклонов правого отрезка.
        string[] secondAngles = new string[4] { "pi/6", "pi/4", "pi/3", "pi/2" };
        // Массив отношений отрезков соседних итераций.
        string[] segmentRatio = new string[7] { "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7" };

        // Массив доступных расстояний между отрезками соседних итераций.
        string[] distances = new string[9] { "2", "3", "4", "5", "6", "7", "8", "9", "10" };

        // Массив доступных маштабов картинки.
        string[] sizes = new string[4] { "в 2 раза", "в 3 раза", "в 5 раз", "вернуть к первоначальному размеру" };

        public Fractals()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Загрузка формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fractals_Load(object sender, EventArgs e)
        {
            // Установка минимального размера формы.
            this.MinimumSize = Screen.PrimaryScreen.Bounds.Size / 2;

            firstColor.BackColor = Color.Red;
            secondColor.BackColor = Color.Aqua;

            LengthRatioList.Items.AddRange(segmentRatio);
            Angle1List.Items.AddRange(firstAngles);
            Angle2List.Items.AddRange(secondAngles);
            DistanceList.Items.AddRange(distances);

            ZoomPictureList.Items.AddRange(sizes);
        }

        /// <summary>
        /// Метод, изменяющий размеры pictureBox под квадрат.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_SizeChanged(object sender, EventArgs e)
        {
            PictureBox.Dock = DockStyle.Fill;

            if (PictureBox.Height > PictureBox.Width) PictureBox.Height = PictureBox.Width;
            else PictureBox.Width = PictureBox.Height;
        }

        /// <summary>
        /// Создание списка цветов градиента.
        /// </summary>
        /// <param name="steps">  Количество цветов. </param>
        /// <returns> Список цветов градиента. </returns>
        public static List<Color> GetGradientColors(int steps)
        {
            List<Color> colorList = new List<Color>();

            if (steps == 1)
            {
                colorList.Add(startColor);
                return colorList;
            }

            int stepA = ((endColor.A - startColor.A) / (steps - 1));
            int stepR = ((endColor.R - startColor.R) / (steps - 1));
            int stepG = ((endColor.G - startColor.G) / (steps - 1));
            int stepB = ((endColor.B - startColor.B) / (steps - 1));

            for (int i = 0; i < steps; i++)
            {
                colorList.Add(Color.FromArgb(startColor.A + (stepA * i),
                                            startColor.R + (stepR * i),
                                            startColor.G + (stepG * i),
                                            startColor.B + (stepB * i)));
            }
            return colorList;
        }

        /// <summary>
        /// Отрисовка фрактала в pictureBox.
        /// </summary>
        private void DrawFractal()
        {
            MakeVisible();

            var bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            PictureBox.Image = bitmap;

            var gr = Graphics.FromImage(bitmap);

            colorList = GetGradientColors(fractal.RecursionDepth);

            int pictureHeight = PictureBox.Height;
            int pictureWidth = PictureBox.Width;

            // Вызов метода для отрисовки фрактала.
            fractal.Draw(pictureWidth, pictureHeight, gr, colorList);
        }

        /// <summary>
        /// Построение фрактала треугольник Серпинского.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SierpinskiTriangle_Click(object sender, EventArgs e)
        {
            if (!(fractal is SierpinskiTriangle))
                fractal = new SierpinskiTriangle();
            // Удаление лишних элементов из формы.
            MakeInvisible();
            // Добавление необходимых элементов в форму.
            MakeVisible();

            // Обновление списка глубин рекурсии.
            RecursionDepthsList.Items.Clear();
            RecursionDepthsList.Items.AddRange(recursionDepths.Take(10).ToArray());

            DrawFractal();
        }

        /// <summary>
        /// Построение фрактала дерево Пифагора.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FractalTree_Click(object sender, EventArgs e)
        {
            if (!(fractal is FractalTree))
                fractal = new FractalTree();

            // Удаление лишних элементов из формы.
            MakeInvisible();
            // Добавление необходимых элементов в форму.
            MakeVisible();

            // Обновление списка глубин рекурсии.
            RecursionDepthsList.Items.Clear();
            RecursionDepthsList.Items.AddRange(recursionDepths);

            DrawFractal();
        }

        /// <summary>
        /// Построение фрактала ковёр Серпинского.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SierpinskiCarpet_Click(object sender, EventArgs e)
        {
            if (!(fractal is SierpinskiCarpet))
                fractal = new SierpinskiCarpet();
            // Удаление лишних элементов из формы.
            MakeInvisible();
            // Добавление необходимых элементов в форму.
            MakeVisible();

            // Обновление списка глубин рекурсии.
            RecursionDepthsList.Items.Clear();
            RecursionDepthsList.Items.AddRange(recursionDepths.Take(6).ToArray());

            DrawFractal();
        }

        /// <summary>
        /// Построение фрактала кривая Коха.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KochCurve_Click(object sender, EventArgs e)
        {
            if (!(fractal is KochCurve))
                fractal = new KochCurve();

            // Удаление лишних элементов из формы.
            MakeInvisible();
            // Добавление необходимых элементов в форму.
            MakeVisible();

            // Обновление списка глубин рекурсии.
            RecursionDepthsList.Items.Clear();
            RecursionDepthsList.Items.AddRange(recursionDepths.Take(5).ToArray());

            DrawFractal();
        }

        /// <summary>
        /// Построение фрактала множество Кантора.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CantorSet_Click(object sender, EventArgs e)
        {
            if (!(fractal is CantorSet))
                fractal = new CantorSet();

            // Удаление лишних элементов из формы.
            MakeInvisible();
            // Добавление необходимых элементов в форму.
            MakeVisible();

            // Обновление списка глубин рекурсии.
            RecursionDepthsList.Items.Clear();
            RecursionDepthsList.Items.AddRange(recursionDepths.Take(10).ToArray());

            DrawFractal();
        }

        /// <summary>
        /// Изменение начального цвета градиента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetStartColor_Click_1(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.ShowHelp = true;

            colorDialog1.Color = startColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                startColor = colorDialog1.Color;
                firstColor.BackColor = startColor;
                // Перерисовка фрактала.
                if (fractal != null) DrawFractal();
            }
        }

        /// <summary>
        /// Изменение конечного цвета градиента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetEndColor_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.ShowHelp = true;
            colorDialog1.Color = endColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                endColor = colorDialog1.Color;
                secondColor.BackColor = endColor;
                // Перерисовка фрактала.
                if (fractal != null) DrawFractal();
            }
        }

        /// <summary>
        /// Изменение глубины рекурсии.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecursionDepthsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            fractal.RecursionDepth = RecursionDepthsList.SelectedIndex + 1;

            // Перерисовка фрактала.
            if (fractal != null) DrawFractal();
        }

        /// <summary>
        /// Метод, делающий невидимыми лишние элементы формы.
        /// </summary>
        void MakeInvisible()
        {
            LengthRatioList.Items.Clear();
            Angle1List.Items.Clear();
            Angle2List.Items.Clear();
            DistanceList.Items.Clear();

            LengthRatioList.Items.AddRange(segmentRatio);
            Angle1List.Items.AddRange(firstAngles);
            Angle2List.Items.AddRange(secondAngles);
            DistanceList.Items.AddRange(distances);

            lengthRatioLabel.Visible = false;
            LengthRatioList.Visible = false;

            angle1Label.Visible = false;
            Angle1List.Visible = false;

            angle2Label.Visible = false;
            Angle2List.Visible = false;

            distanceLabel.Visible = false;
            DistanceList.Visible = false;
        }

        /// <summary>
        /// Метод, делающий видимыми нужные элементы формы.
        /// </summary>
        void MakeVisible()
        {
            zoomPictureLabel.Visible = true;
            ZoomPictureList.Visible = true;

            // Обновление списка маштабов.
            ZoomPictureList.Items.Clear();
            ZoomPictureList.Items.AddRange(sizes.ToArray());

            if (fractal is FractalTree)
            {
                lengthRatioLabel.Visible = true;
                LengthRatioList.Visible = true;

                angle1Label.Visible = true;
                Angle1List.Visible = true;

                angle2Label.Visible = true;
                Angle2List.Visible = true;
            }

            if (fractal is CantorSet)
            {
                distanceLabel.Visible = true;
                DistanceList.Visible = true;
            }
        }

        /// <summary>
        /// Изменение наклона левого отрезка дерева Пифагора.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Angle1List_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Angle1List.SelectedIndex)
            {
                case (0):
                    {
                        fractal.LeftAng = Math.PI / 6;
                        break;
                    }
                case (1):
                    {
                        fractal.LeftAng = Math.PI / 4;
                        break;
                    }
                case (2):
                    {
                        fractal.LeftAng = Math.PI / 3;
                        break;
                    }
                case (3):
                    {
                        fractal.LeftAng = Math.PI / 2;
                        break;
                    }
            }
            // Перерисовка фрактала.
            DrawFractal();
        }

        /// <summary>
        /// Изменение наклона правого отрезка дерева Пифагора.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Angle2List_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Angle2List.SelectedIndex)
            {
                case (0):
                    {
                        fractal.RightAng = Math.PI / 6;
                        break;
                    }
                case (1):
                    {
                        fractal.RightAng = Math.PI / 4;
                        break;
                    }
                case (2):
                    {
                        fractal.RightAng = Math.PI / 3;
                        break;
                    }
                case (3):
                    {
                        fractal.RightAng = Math.PI / 2;
                        break;
                    }
            }
            // Перерисовка фрактала.
            DrawFractal();
        }

        /// <summary>
        /// Изменение отношения отрезков соседних итераций дерева Пифагора.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LengthRatioList_SelectedIndexChanged(object sender, EventArgs e)
        {
            fractal.SegmentsRatio = (LengthRatioList.SelectedIndex + 1) / 10f;

            // Перерисовка фрактала.
            DrawFractal();
        }

        /// <summary>
        /// Изменение расстояния между отрезками соседних итераций.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DistanceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            fractal.Distance = (DistanceList.SelectedIndex + 2) * 10;

            // Перерисовка фрактала.
            DrawFractal();
        }

        /// <summary>
        /// Изменение маштаба картинки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomPictureList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Во сколько раз увеличивается картинка.
            double zoom = 1;

            if (ZoomPictureList.SelectedIndex == 0) zoom = (double)1 / 2;
            else if (ZoomPictureList.SelectedIndex == 1) zoom = (double)1 / 3;
            else if (ZoomPictureList.SelectedIndex == 2) zoom = (double)1 / 5;
            else
            {
                DrawFractal();
                return;
            }

            var bmp = new Bitmap(PictureBox.Image, Convert.ToInt32(PictureBox.Width * zoom), Convert.ToInt32(PictureBox.Height * zoom));
            PictureBox.Image = bmp;

            var gr = Graphics.FromImage(bmp);
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Очистка pictureBox.
            Graphics.FromImage(bmp).Clear(Color.White);

            int pictureHeight = PictureBox.Height;
            int pictureWidth = PictureBox.Width;

            // Изменение начала координат.
            if ((fractal is SierpinskiTriangle) || (fractal is KochCurve))
                gr.TranslateTransform(-pictureWidth / 3, -pictureHeight / 3);
            else if (fractal is FractalTree)
                gr.TranslateTransform((float)(-(pictureWidth * 4 / 10)), (float)(-pictureHeight / 2));

            colorList = GetGradientColors(fractal.RecursionDepth);

            // Вызов метода для перерисовки фрактала.
            fractal.Draw(pictureWidth, pictureHeight, gr, colorList);
        }

        /// <summary>
        /// Сохранение картинки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavePicture_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)PictureBox.Image;
            if (bmp != null)
                bmp.Save(@"fractal.jpg", ImageFormat.Png);
            MessageBox.Show(@"Картинка сохранена в папку ...Fractals\testform\bin\Debug\netcoreapp3.1");
        }
    }
}
