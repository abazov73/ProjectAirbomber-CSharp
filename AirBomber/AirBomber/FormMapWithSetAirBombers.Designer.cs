namespace AirBomber
{
    partial class FormMapWithSetAirBombers
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
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.comboBoxSelectorMap = new System.Windows.Forms.ComboBox();
            this.buttonAddAirBomber = new System.Windows.Forms.Button();
            this.maskedTextBoxPosition = new System.Windows.Forms.MaskedTextBox();
            this.buttonRemoveAirBomber = new System.Windows.Forms.Button();
            this.buttonShowStorage = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonShowOnMap = new System.Windows.Forms.Button();
            this.groupBoxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Controls.Add(this.buttonShowOnMap);
            this.groupBoxTools.Controls.Add(this.buttonRight);
            this.groupBoxTools.Controls.Add(this.buttonDown);
            this.groupBoxTools.Controls.Add(this.buttonLeft);
            this.groupBoxTools.Controls.Add(this.buttonUp);
            this.groupBoxTools.Controls.Add(this.buttonShowStorage);
            this.groupBoxTools.Controls.Add(this.buttonRemoveAirBomber);
            this.groupBoxTools.Controls.Add(this.maskedTextBoxPosition);
            this.groupBoxTools.Controls.Add(this.buttonAddAirBomber);
            this.groupBoxTools.Controls.Add(this.comboBoxSelectorMap);
            this.groupBoxTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxTools.Location = new System.Drawing.Point(621, 0);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(261, 453);
            this.groupBoxTools.TabIndex = 0;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Инструменты";
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(621, 453);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // comboBoxSelectorMap
            // 
            this.comboBoxSelectorMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxSelectorMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectorMap.FormattingEnabled = true;
            this.comboBoxSelectorMap.Items.AddRange(new object[] {
            "Простая карта",
            "Городская карта",
            "Линейная карта"});
            this.comboBoxSelectorMap.Location = new System.Drawing.Point(19, 35);
            this.comboBoxSelectorMap.Name = "comboBoxSelectorMap";
            this.comboBoxSelectorMap.Size = new System.Drawing.Size(218, 28);
            this.comboBoxSelectorMap.TabIndex = 10;
            this.comboBoxSelectorMap.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectorMap_SelectedIndexChanged);
            // 
            // buttonAddAirBomber
            // 
            this.buttonAddAirBomber.Location = new System.Drawing.Point(19, 109);
            this.buttonAddAirBomber.Name = "buttonAddAirBomber";
            this.buttonAddAirBomber.Size = new System.Drawing.Size(218, 41);
            this.buttonAddAirBomber.TabIndex = 11;
            this.buttonAddAirBomber.Text = "Добавить бомбардировщик";
            this.buttonAddAirBomber.UseVisualStyleBackColor = true;
            this.buttonAddAirBomber.Click += new System.EventHandler(this.buttonAddAirBomber_Click);
            // 
            // maskedTextBoxPosition
            // 
            this.maskedTextBoxPosition.Location = new System.Drawing.Point(19, 188);
            this.maskedTextBoxPosition.Mask = "00";
            this.maskedTextBoxPosition.Name = "maskedTextBoxPosition";
            this.maskedTextBoxPosition.Size = new System.Drawing.Size(218, 27);
            this.maskedTextBoxPosition.TabIndex = 12;
            this.maskedTextBoxPosition.ValidatingType = typeof(int);
            // 
            // buttonRemoveAirBomber
            // 
            this.buttonRemoveAirBomber.Location = new System.Drawing.Point(19, 221);
            this.buttonRemoveAirBomber.Name = "buttonRemoveAirBomber";
            this.buttonRemoveAirBomber.Size = new System.Drawing.Size(218, 41);
            this.buttonRemoveAirBomber.TabIndex = 13;
            this.buttonRemoveAirBomber.Text = "Удалить бомбардировщик";
            this.buttonRemoveAirBomber.UseVisualStyleBackColor = true;
            this.buttonRemoveAirBomber.Click += new System.EventHandler(this.buttonRemoveAirBomber_Click);
            // 
            // buttonShowStorage
            // 
            this.buttonShowStorage.Location = new System.Drawing.Point(19, 281);
            this.buttonShowStorage.Name = "buttonShowStorage";
            this.buttonShowStorage.Size = new System.Drawing.Size(218, 41);
            this.buttonShowStorage.TabIndex = 14;
            this.buttonShowStorage.Text = "Посмотреть хранилище";
            this.buttonShowStorage.UseVisualStyleBackColor = true;
            this.buttonShowStorage.Click += new System.EventHandler(this.buttonShowStorage_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::AirBomber.Properties.Resources.arrowRight;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRight.Location = new System.Drawing.Point(148, 411);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 18;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::AirBomber.Properties.Resources.arrowDown;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDown.Location = new System.Drawing.Point(112, 411);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 17;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::AirBomber.Properties.Resources.arrowLeft;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeft.Location = new System.Drawing.Point(76, 411);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 16;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::AirBomber.Properties.Resources.arrowUp;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUp.Location = new System.Drawing.Point(112, 375);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 15;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonShowOnMap
            // 
            this.buttonShowOnMap.Location = new System.Drawing.Point(19, 328);
            this.buttonShowOnMap.Name = "buttonShowOnMap";
            this.buttonShowOnMap.Size = new System.Drawing.Size(218, 41);
            this.buttonShowOnMap.TabIndex = 19;
            this.buttonShowOnMap.Text = "Посмотреть карту";
            this.buttonShowOnMap.UseVisualStyleBackColor = true;
            this.buttonShowOnMap.Click += new System.EventHandler(this.buttonShowOnMap_Click);
            // 
            // FormMapWithSetAirBombers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBoxTools);
            this.Name = "FormMapWithSetAirBombers";
            this.Text = "Карта с набором объектов";
            this.groupBoxTools.ResumeLayout(false);
            this.groupBoxTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxTools;
        private PictureBox pictureBox;
        private ComboBox comboBoxSelectorMap;
        private MaskedTextBox maskedTextBoxPosition;
        private Button buttonAddAirBomber;
        private Button buttonShowStorage;
        private Button buttonRemoveAirBomber;
        private Button buttonRight;
        private Button buttonDown;
        private Button buttonLeft;
        private Button buttonUp;
        private Button buttonShowOnMap;
    }
}