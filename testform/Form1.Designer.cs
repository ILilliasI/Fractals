namespace Fractals
{
    partial class Fractals
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CantorSet = new System.Windows.Forms.Button();
            this.drawFractalLabel = new System.Windows.Forms.Label();
            this.KochCurve = new System.Windows.Forms.Button();
            this.SierpinskiCarpet = new System.Windows.Forms.Button();
            this.FractalTree = new System.Windows.Forms.Button();
            this.sierpinskiTriangle = new System.Windows.Forms.Button();
            this.SavePicture = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SetStartColor = new System.Windows.Forms.Button();
            this.ZoomPictureList = new System.Windows.Forms.ComboBox();
            this.zoomPictureLabel = new System.Windows.Forms.Label();
            this.DistanceList = new System.Windows.Forms.ComboBox();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.Angle2List = new System.Windows.Forms.ComboBox();
            this.lengthRatioLabel = new System.Windows.Forms.Label();
            this.gradientColorsLabel = new System.Windows.Forms.Label();
            this.Angle1List = new System.Windows.Forms.ComboBox();
            this.LengthRatioList = new System.Windows.Forms.ComboBox();
            this.angle2Label = new System.Windows.Forms.Label();
            this.angle1Label = new System.Windows.Forms.Label();
            this.recursionDepthLabel = new System.Windows.Forms.Label();
            this.RecursionDepthsList = new System.Windows.Forms.ComboBox();
            this.secondColor = new System.Windows.Forms.Button();
            this.firstColor = new System.Windows.Forms.Button();
            this.SetEndColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CantorSet);
            this.panel1.Controls.Add(this.drawFractalLabel);
            this.panel1.Controls.Add(this.KochCurve);
            this.panel1.Controls.Add(this.SierpinskiCarpet);
            this.panel1.Controls.Add(this.FractalTree);
            this.panel1.Controls.Add(this.sierpinskiTriangle);
            this.panel1.Controls.Add(this.SavePicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1030, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 573);
            this.panel1.TabIndex = 1;
            // 
            // CantorSet
            // 
            this.CantorSet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CantorSet.Location = new System.Drawing.Point(17, 290);
            this.CantorSet.Name = "CantorSet";
            this.CantorSet.Size = new System.Drawing.Size(218, 57);
            this.CantorSet.TabIndex = 5;
            this.CantorSet.Text = "Множество Кантора";
            this.CantorSet.UseVisualStyleBackColor = true;
            this.CantorSet.Click += new System.EventHandler(this.CantorSet_Click);
            // 
            // drawFractalLabel
            // 
            this.drawFractalLabel.AutoSize = true;
            this.drawFractalLabel.Location = new System.Drawing.Point(14, 3);
            this.drawFractalLabel.Name = "drawFractalLabel";
            this.drawFractalLabel.Size = new System.Drawing.Size(184, 25);
            this.drawFractalLabel.TabIndex = 4;
            this.drawFractalLabel.Text = "Нарисовать фрактал:";
            // 
            // KochCurve
            // 
            this.KochCurve.Location = new System.Drawing.Point(15, 225);
            this.KochCurve.Name = "KochCurve";
            this.KochCurve.Size = new System.Drawing.Size(218, 59);
            this.KochCurve.TabIndex = 3;
            this.KochCurve.Text = "Кривая Коха";
            this.KochCurve.UseVisualStyleBackColor = true;
            this.KochCurve.Click += new System.EventHandler(this.KochCurve_Click);
            // 
            // SierpinskiCarpet
            // 
            this.SierpinskiCarpet.Location = new System.Drawing.Point(14, 160);
            this.SierpinskiCarpet.Name = "SierpinskiCarpet";
            this.SierpinskiCarpet.Size = new System.Drawing.Size(218, 58);
            this.SierpinskiCarpet.TabIndex = 2;
            this.SierpinskiCarpet.Text = "Ковёр Серпинского";
            this.SierpinskiCarpet.UseVisualStyleBackColor = true;
            this.SierpinskiCarpet.Click += new System.EventHandler(this.SierpinskiCarpet_Click);
            // 
            // FractalTree
            // 
            this.FractalTree.Location = new System.Drawing.Point(14, 31);
            this.FractalTree.Name = "FractalTree";
            this.FractalTree.Size = new System.Drawing.Size(218, 58);
            this.FractalTree.TabIndex = 1;
            this.FractalTree.Text = "Дерево Пифагора";
            this.FractalTree.UseVisualStyleBackColor = true;
            this.FractalTree.Click += new System.EventHandler(this.FractalTree_Click);
            // 
            // sierpinskiTriangle
            // 
            this.sierpinskiTriangle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sierpinskiTriangle.Location = new System.Drawing.Point(15, 95);
            this.sierpinskiTriangle.Name = "sierpinskiTriangle";
            this.sierpinskiTriangle.Size = new System.Drawing.Size(218, 59);
            this.sierpinskiTriangle.TabIndex = 0;
            this.sierpinskiTriangle.Text = "Треугольник Серпинского";
            this.sierpinskiTriangle.UseVisualStyleBackColor = true;
            this.sierpinskiTriangle.Click += new System.EventHandler(this.SierpinskiTriangle_Click);
            // 
            // SavePicture
            // 
            this.SavePicture.BackColor = System.Drawing.Color.SteelBlue;
            this.SavePicture.Location = new System.Drawing.Point(14, 401);
            this.SavePicture.Name = "SavePicture";
            this.SavePicture.Size = new System.Drawing.Size(217, 58);
            this.SavePicture.TabIndex = 1;
            this.SavePicture.Text = "Сохранить картинку";
            this.SavePicture.UseVisualStyleBackColor = false;
            this.SavePicture.Click += new System.EventHandler(this.SavePicture_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PictureBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(426, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 570);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.White;
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(3, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(564, 564);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.SizeChanged += new System.EventHandler(this.PictureBox_SizeChanged);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.SetStartColor);
            this.panel2.Controls.Add(this.ZoomPictureList);
            this.panel2.Controls.Add(this.zoomPictureLabel);
            this.panel2.Controls.Add(this.DistanceList);
            this.panel2.Controls.Add(this.distanceLabel);
            this.panel2.Controls.Add(this.Angle2List);
            this.panel2.Controls.Add(this.lengthRatioLabel);
            this.panel2.Controls.Add(this.gradientColorsLabel);
            this.panel2.Controls.Add(this.Angle1List);
            this.panel2.Controls.Add(this.LengthRatioList);
            this.panel2.Controls.Add(this.angle2Label);
            this.panel2.Controls.Add(this.angle1Label);
            this.panel2.Controls.Add(this.recursionDepthLabel);
            this.panel2.Controls.Add(this.RecursionDepthsList);
            this.panel2.Controls.Add(this.secondColor);
            this.panel2.Controls.Add(this.firstColor);
            this.panel2.Controls.Add(this.SetEndColor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 573);
            this.panel2.TabIndex = 3;
            // 
            // SetStartColor
            // 
            this.SetStartColor.Location = new System.Drawing.Point(16, 31);
            this.SetStartColor.Name = "SetStartColor";
            this.SetStartColor.Size = new System.Drawing.Size(162, 58);
            this.SetStartColor.TabIndex = 20;
            this.SetStartColor.Text = "Начальный цвет градиента ";
            this.SetStartColor.UseVisualStyleBackColor = true;
            this.SetStartColor.Click += new System.EventHandler(this.SetStartColor_Click_1);
            // 
            // ZoomPictureList
            // 
            this.ZoomPictureList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ZoomPictureList.FormattingEnabled = true;
            this.ZoomPictureList.Location = new System.Drawing.Point(25, 469);
            this.ZoomPictureList.Name = "ZoomPictureList";
            this.ZoomPictureList.Size = new System.Drawing.Size(344, 33);
            this.ZoomPictureList.TabIndex = 19;
            this.ZoomPictureList.Visible = false;
            this.ZoomPictureList.SelectedIndexChanged += new System.EventHandler(this.ZoomPictureList_SelectedIndexChanged);
            // 
            // zoomPictureLabel
            // 
            this.zoomPictureLabel.AutoSize = true;
            this.zoomPictureLabel.Location = new System.Drawing.Point(16, 441);
            this.zoomPictureLabel.Name = "zoomPictureLabel";
            this.zoomPictureLabel.Size = new System.Drawing.Size(179, 25);
            this.zoomPictureLabel.TabIndex = 18;
            this.zoomPictureLabel.Text = "Увеличить картинку:";
            this.zoomPictureLabel.Visible = false;
            // 
            // DistanceList
            // 
            this.DistanceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DistanceList.FormattingEnabled = true;
            this.DistanceList.Location = new System.Drawing.Point(25, 292);
            this.DistanceList.Name = "DistanceList";
            this.DistanceList.Size = new System.Drawing.Size(88, 33);
            this.DistanceList.TabIndex = 17;
            this.DistanceList.Visible = false;
            this.DistanceList.SelectedIndexChanged += new System.EventHandler(this.DistanceList_SelectedIndexChanged);
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(15, 239);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(259, 50);
            this.distanceLabel.TabIndex = 16;
            this.distanceLabel.Text = "Расстояние между отрезками \r\nсоседних итераций:";
            this.distanceLabel.Visible = false;
            // 
            // Angle2List
            // 
            this.Angle2List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Angle2List.FormattingEnabled = true;
            this.Angle2List.Location = new System.Drawing.Point(25, 401);
            this.Angle2List.Name = "Angle2List";
            this.Angle2List.Size = new System.Drawing.Size(88, 33);
            this.Angle2List.TabIndex = 15;
            this.Angle2List.Visible = false;
            this.Angle2List.SelectedIndexChanged += new System.EventHandler(this.Angle2List_SelectedIndexChanged);
            // 
            // lengthRatioLabel
            // 
            this.lengthRatioLabel.AutoSize = true;
            this.lengthRatioLabel.Location = new System.Drawing.Point(15, 234);
            this.lengthRatioLabel.Name = "lengthRatioLabel";
            this.lengthRatioLabel.Size = new System.Drawing.Size(369, 25);
            this.lengthRatioLabel.TabIndex = 14;
            this.lengthRatioLabel.Text = "Отношение меньшего отрезка к большему:";
            this.lengthRatioLabel.Visible = false;
            // 
            // gradientColorsLabel
            // 
            this.gradientColorsLabel.AutoSize = true;
            this.gradientColorsLabel.Location = new System.Drawing.Point(15, 3);
            this.gradientColorsLabel.Name = "gradientColorsLabel";
            this.gradientColorsLabel.Size = new System.Drawing.Size(151, 25);
            this.gradientColorsLabel.TabIndex = 13;
            this.gradientColorsLabel.Text = "Цвета градиента:";
            // 
            // Angle1List
            // 
            this.Angle1List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Angle1List.FormattingEnabled = true;
            this.Angle1List.Location = new System.Drawing.Point(25, 326);
            this.Angle1List.Name = "Angle1List";
            this.Angle1List.Size = new System.Drawing.Size(88, 33);
            this.Angle1List.TabIndex = 12;
            this.Angle1List.Visible = false;
            this.Angle1List.SelectedIndexChanged += new System.EventHandler(this.Angle1List_SelectedIndexChanged);
            // 
            // LengthRatioList
            // 
            this.LengthRatioList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LengthRatioList.FormattingEnabled = true;
            this.LengthRatioList.Location = new System.Drawing.Point(25, 262);
            this.LengthRatioList.Name = "LengthRatioList";
            this.LengthRatioList.Size = new System.Drawing.Size(88, 33);
            this.LengthRatioList.TabIndex = 11;
            this.LengthRatioList.Visible = false;
            this.LengthRatioList.SelectedIndexChanged += new System.EventHandler(this.LengthRatioList_SelectedIndexChanged);
            // 
            // angle2Label
            // 
            this.angle2Label.AutoSize = true;
            this.angle2Label.Location = new System.Drawing.Point(15, 373);
            this.angle2Label.Name = "angle2Label";
            this.angle2Label.Size = new System.Drawing.Size(268, 25);
            this.angle2Label.TabIndex = 10;
            this.angle2Label.Text = "Угол наклона правого отрезка:";
            this.angle2Label.Visible = false;
            // 
            // angle1Label
            // 
            this.angle1Label.AutoSize = true;
            this.angle1Label.Location = new System.Drawing.Point(16, 298);
            this.angle1Label.Name = "angle1Label";
            this.angle1Label.Size = new System.Drawing.Size(256, 25);
            this.angle1Label.TabIndex = 9;
            this.angle1Label.Text = "Угол наклона левого отрезка:";
            this.angle1Label.Visible = false;
            // 
            // recursionDepthLabel
            // 
            this.recursionDepthLabel.AutoSize = true;
            this.recursionDepthLabel.Location = new System.Drawing.Point(16, 163);
            this.recursionDepthLabel.Name = "recursionDepthLabel";
            this.recursionDepthLabel.Size = new System.Drawing.Size(163, 25);
            this.recursionDepthLabel.TabIndex = 7;
            this.recursionDepthLabel.Text = "Глубина рекурсии:";
            // 
            // RecursionDepthsList
            // 
            this.RecursionDepthsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RecursionDepthsList.FormattingEnabled = true;
            this.RecursionDepthsList.Location = new System.Drawing.Point(25, 191);
            this.RecursionDepthsList.Name = "RecursionDepthsList";
            this.RecursionDepthsList.Size = new System.Drawing.Size(88, 33);
            this.RecursionDepthsList.TabIndex = 6;
            this.RecursionDepthsList.SelectedIndexChanged += new System.EventHandler(this.RecursionDepthsList_SelectedIndexChanged);
            // 
            // secondColor
            // 
            this.secondColor.Location = new System.Drawing.Point(181, 95);
            this.secondColor.Name = "secondColor";
            this.secondColor.Size = new System.Drawing.Size(61, 58);
            this.secondColor.TabIndex = 5;
            this.secondColor.UseVisualStyleBackColor = true;
            // 
            // firstColor
            // 
            this.firstColor.Location = new System.Drawing.Point(181, 31);
            this.firstColor.Name = "firstColor";
            this.firstColor.Size = new System.Drawing.Size(61, 58);
            this.firstColor.TabIndex = 4;
            this.firstColor.UseVisualStyleBackColor = true;
            // 
            // SetEndColor
            // 
            this.SetEndColor.Location = new System.Drawing.Point(16, 95);
            this.SetEndColor.Name = "SetEndColor";
            this.SetEndColor.Size = new System.Drawing.Size(163, 58);
            this.SetEndColor.TabIndex = 3;
            this.SetEndColor.Text = "Конечный цвет градиента";
            this.SetEndColor.UseVisualStyleBackColor = true;
            this.SetEndColor.Click += new System.EventHandler(this.SetEndColor_Click);
            // 
            // Fractals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1277, 573);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Fractals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фракталы";
            this.Load += new System.EventHandler(this.Fractals_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button SierpinskiCarpet;
        private System.Windows.Forms.Button FractalTree;
        private System.Windows.Forms.Button sierpinskiTriangle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button secondColor;
        private System.Windows.Forms.Button firstColor;
        private System.Windows.Forms.Button SetEndColor;
        private System.Windows.Forms.Button SetStartColor;
        private System.Windows.Forms.Button SavePicture;
        private System.Windows.Forms.ComboBox RecursionDepthsList;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button KochCurve;
        private System.Windows.Forms.ComboBox Angle2List;
        private System.Windows.Forms.Label lengthRatioLabel;
        private System.Windows.Forms.Label gradientColorsLabel;
        private System.Windows.Forms.ComboBox Angle1List;
        private System.Windows.Forms.ComboBox LengthRatioList;
        private System.Windows.Forms.Label angle2Label;
        private System.Windows.Forms.Label angle1Label;
        private System.Windows.Forms.Label recursionDepthLabel;
        private System.Windows.Forms.Label drawFractalLabel;
        private System.Windows.Forms.Button CantorSet;
        private System.Windows.Forms.ComboBox DistanceList;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.ComboBox ZoomPictureList;
        private System.Windows.Forms.Label zoomPictureLabel;
    }
}

