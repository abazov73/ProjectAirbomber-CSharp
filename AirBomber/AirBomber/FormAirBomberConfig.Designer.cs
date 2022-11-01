namespace AirBomber
{
    partial class FormAirBomberConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.panelObject = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.pictureBoxObject = new System.Windows.Forms.PictureBox();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.labelModifiedObject = new System.Windows.Forms.Label();
            this.labelSimpleObject = new System.Windows.Forms.Label();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.checkBoxTailLine = new System.Windows.Forms.CheckBox();
            this.checkBoxFuelTank = new System.Windows.Forms.CheckBox();
            this.checkBoxBombs = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.panelObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObject)).BeginInit();
            this.groupBoxConfig.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(775, 268);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(119, 40);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(637, 268);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(119, 40);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // panelObject
            // 
            this.panelObject.AllowDrop = true;
            this.panelObject.Controls.Add(this.labelDopColor);
            this.panelObject.Controls.Add(this.labelBaseColor);
            this.panelObject.Controls.Add(this.pictureBoxObject);
            this.panelObject.Location = new System.Drawing.Point(614, 15);
            this.panelObject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelObject.Name = "panelObject";
            this.panelObject.Size = new System.Drawing.Size(299, 245);
            this.panelObject.TabIndex = 7;
            this.panelObject.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelObject_DragDrop);
            this.panelObject.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelObject_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(161, 12);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(119, 42);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(23, 12);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(119, 42);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // pictureBoxObject
            // 
            this.pictureBoxObject.Location = new System.Drawing.Point(23, 59);
            this.pictureBoxObject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxObject.Name = "pictureBoxObject";
            this.pictureBoxObject.Size = new System.Drawing.Size(257, 167);
            this.pictureBoxObject.TabIndex = 0;
            this.pictureBoxObject.TabStop = false;
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.labelModifiedObject);
            this.groupBoxConfig.Controls.Add(this.labelSimpleObject);
            this.groupBoxConfig.Controls.Add(this.groupBoxColors);
            this.groupBoxConfig.Controls.Add(this.checkBoxTailLine);
            this.groupBoxConfig.Controls.Add(this.checkBoxFuelTank);
            this.groupBoxConfig.Controls.Add(this.checkBoxBombs);
            this.groupBoxConfig.Controls.Add(this.numericUpDownWeight);
            this.groupBoxConfig.Controls.Add(this.labelWeight);
            this.groupBoxConfig.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxConfig.Controls.Add(this.labelSpeed);
            this.groupBoxConfig.Location = new System.Drawing.Point(13, 15);
            this.groupBoxConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxConfig.Size = new System.Drawing.Size(594, 293);
            this.groupBoxConfig.TabIndex = 6;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Параметры";
            // 
            // labelModifiedObject
            // 
            this.labelModifiedObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelModifiedObject.Location = new System.Drawing.Point(450, 216);
            this.labelModifiedObject.Name = "labelModifiedObject";
            this.labelModifiedObject.Size = new System.Drawing.Size(111, 50);
            this.labelModifiedObject.TabIndex = 16;
            this.labelModifiedObject.Text = "Продвинутый";
            this.labelModifiedObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelModifiedObject.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelObject_MouseDown);
            // 
            // labelSimpleObject
            // 
            this.labelSimpleObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSimpleObject.Location = new System.Drawing.Point(322, 216);
            this.labelSimpleObject.Name = "labelSimpleObject";
            this.labelSimpleObject.Size = new System.Drawing.Size(111, 50);
            this.labelSimpleObject.TabIndex = 15;
            this.labelSimpleObject.Text = "Простой";
            this.labelSimpleObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSimpleObject.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelObject_MouseDown);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelPurple);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelGray);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Location = new System.Drawing.Point(305, 29);
            this.groupBoxColors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxColors.Size = new System.Drawing.Size(275, 169);
            this.groupBoxColors.TabIndex = 14;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.Location = new System.Drawing.Point(210, 97);
            this.panelPurple.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(46, 53);
            this.panelPurple.TabIndex = 3;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(210, 29);
            this.panelYellow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(46, 53);
            this.panelYellow.TabIndex = 1;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(145, 97);
            this.panelBlack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(46, 53);
            this.panelBlack.TabIndex = 4;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(145, 29);
            this.panelBlue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(46, 53);
            this.panelBlue.TabIndex = 1;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(82, 97);
            this.panelGray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(46, 53);
            this.panelGray.TabIndex = 5;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(82, 29);
            this.panelGreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(46, 53);
            this.panelGreen.TabIndex = 1;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(17, 97);
            this.panelWhite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(46, 53);
            this.panelWhite.TabIndex = 2;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(17, 29);
            this.panelRed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(46, 53);
            this.panelRed.TabIndex = 0;
            // 
            // checkBoxTailLine
            // 
            this.checkBoxTailLine.AutoSize = true;
            this.checkBoxTailLine.Location = new System.Drawing.Point(25, 248);
            this.checkBoxTailLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxTailLine.Name = "checkBoxTailLine";
            this.checkBoxTailLine.Size = new System.Drawing.Size(286, 24);
            this.checkBoxTailLine.TabIndex = 13;
            this.checkBoxTailLine.Text = "Признак наличия полосок на хвосте";
            this.checkBoxTailLine.UseVisualStyleBackColor = true;
            // 
            // checkBoxFuelTank
            // 
            this.checkBoxFuelTank.AutoSize = true;
            this.checkBoxFuelTank.Location = new System.Drawing.Point(25, 200);
            this.checkBoxFuelTank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxFuelTank.Name = "checkBoxFuelTank";
            this.checkBoxFuelTank.Size = new System.Drawing.Size(279, 24);
            this.checkBoxFuelTank.TabIndex = 12;
            this.checkBoxFuelTank.Text = "Признак наличия топливных баков";
            this.checkBoxFuelTank.UseVisualStyleBackColor = true;
            // 
            // checkBoxBombs
            // 
            this.checkBoxBombs.AutoSize = true;
            this.checkBoxBombs.Location = new System.Drawing.Point(25, 154);
            this.checkBoxBombs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxBombs.Name = "checkBoxBombs";
            this.checkBoxBombs.Size = new System.Drawing.Size(196, 24);
            this.checkBoxBombs.TabIndex = 11;
            this.checkBoxBombs.Text = "Признак наличия бомб";
            this.checkBoxBombs.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(103, 96);
            this.numericUpDownWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(90, 27);
            this.numericUpDownWeight.TabIndex = 10;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(25, 100);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(36, 20);
            this.labelWeight.TabIndex = 9;
            this.labelWeight.Text = "Вес:";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(103, 40);
            this.numericUpDownSpeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(90, 27);
            this.numericUpDownSpeed.TabIndex = 8;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(25, 44);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(76, 20);
            this.labelSpeed.TabIndex = 7;
            this.labelSpeed.Text = "Скорость:";
            // 
            // FormAirBomberConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 323);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.panelObject);
            this.Controls.Add(this.groupBoxConfig);
            this.Name = "FormAirBomberConfig";
            this.Text = "FormAirBomberConfig";
            this.panelObject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObject)).EndInit();
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            this.groupBoxColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCancel;
        private Button buttonOk;
        private Panel panelObject;
        private Label labelDopColor;
        private Label labelBaseColor;
        private PictureBox pictureBoxObject;
        private GroupBox groupBoxConfig;
        private Label labelModifiedObject;
        private Label labelSimpleObject;
        private GroupBox groupBoxColors;
        private Panel panelPurple;
        private Panel panelYellow;
        private Panel panelBlack;
        private Panel panelBlue;
        private Panel panelGray;
        private Panel panelGreen;
        private Panel panelWhite;
        private Panel panelRed;
        private CheckBox checkBoxTailLine;
        private CheckBox checkBoxFuelTank;
        private CheckBox checkBoxBombs;
        private NumericUpDown numericUpDownWeight;
        private Label labelWeight;
        private NumericUpDown numericUpDownSpeed;
        private Label labelSpeed;
    }
}