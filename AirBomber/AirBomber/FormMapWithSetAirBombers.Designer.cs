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
            this.groupBoxMaps = new System.Windows.Forms.GroupBox();
            this.buttonAddMap = new System.Windows.Forms.Button();
            this.buttonDeleteMap = new System.Windows.Forms.Button();
            this.listBoxMaps = new System.Windows.Forms.ListBox();
            this.textBoxNewMapName = new System.Windows.Forms.TextBox();
            this.comboBoxSelectorMap = new System.Windows.Forms.ComboBox();
            this.buttonShowOnMap = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonShowStorage = new System.Windows.Forms.Button();
            this.buttonRemoveAirBomber = new System.Windows.Forms.Button();
            this.maskedTextBoxPosition = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddAirBomber = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxTools.SuspendLayout();
            this.groupBoxMaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Controls.Add(this.groupBoxMaps);
            this.groupBoxTools.Controls.Add(this.buttonShowOnMap);
            this.groupBoxTools.Controls.Add(this.buttonRight);
            this.groupBoxTools.Controls.Add(this.buttonDown);
            this.groupBoxTools.Controls.Add(this.buttonLeft);
            this.groupBoxTools.Controls.Add(this.buttonUp);
            this.groupBoxTools.Controls.Add(this.buttonShowStorage);
            this.groupBoxTools.Controls.Add(this.buttonRemoveAirBomber);
            this.groupBoxTools.Controls.Add(this.maskedTextBoxPosition);
            this.groupBoxTools.Controls.Add(this.buttonAddAirBomber);
            this.groupBoxTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxTools.Location = new System.Drawing.Point(621, 28);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(261, 695);
            this.groupBoxTools.TabIndex = 0;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Инструменты";
            // 
            // groupBoxMaps
            // 
            this.groupBoxMaps.Controls.Add(this.buttonAddMap);
            this.groupBoxMaps.Controls.Add(this.buttonDeleteMap);
            this.groupBoxMaps.Controls.Add(this.listBoxMaps);
            this.groupBoxMaps.Controls.Add(this.textBoxNewMapName);
            this.groupBoxMaps.Controls.Add(this.comboBoxSelectorMap);
            this.groupBoxMaps.Location = new System.Drawing.Point(18, 34);
            this.groupBoxMaps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMaps.Name = "groupBoxMaps";
            this.groupBoxMaps.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMaps.Size = new System.Drawing.Size(219, 331);
            this.groupBoxMaps.TabIndex = 20;
            this.groupBoxMaps.TabStop = false;
            this.groupBoxMaps.Text = "Карты";
            // 
            // buttonAddMap
            // 
            this.buttonAddMap.Location = new System.Drawing.Point(13, 107);
            this.buttonAddMap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddMap.Name = "buttonAddMap";
            this.buttonAddMap.Size = new System.Drawing.Size(200, 47);
            this.buttonAddMap.TabIndex = 2;
            this.buttonAddMap.Text = "Добавить карту";
            this.buttonAddMap.UseVisualStyleBackColor = true;
            this.buttonAddMap.Click += new System.EventHandler(this.buttonAddMap_Click);
            // 
            // buttonDeleteMap
            // 
            this.buttonDeleteMap.Location = new System.Drawing.Point(13, 275);
            this.buttonDeleteMap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteMap.Name = "buttonDeleteMap";
            this.buttonDeleteMap.Size = new System.Drawing.Size(200, 47);
            this.buttonDeleteMap.TabIndex = 4;
            this.buttonDeleteMap.Text = "Удалить карту";
            this.buttonDeleteMap.UseVisualStyleBackColor = true;
            this.buttonDeleteMap.Click += new System.EventHandler(this.buttonDeleteMap_Click);
            // 
            // listBoxMaps
            // 
            this.listBoxMaps.FormattingEnabled = true;
            this.listBoxMaps.ItemHeight = 20;
            this.listBoxMaps.Location = new System.Drawing.Point(13, 161);
            this.listBoxMaps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxMaps.Name = "listBoxMaps";
            this.listBoxMaps.Size = new System.Drawing.Size(199, 104);
            this.listBoxMaps.TabIndex = 3;
            this.listBoxMaps.SelectedIndexChanged += new System.EventHandler(this.listBoxMaps_SelectedIndexChanged);
            // 
            // textBoxNewMapName
            // 
            this.textBoxNewMapName.Location = new System.Drawing.Point(13, 29);
            this.textBoxNewMapName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNewMapName.Name = "textBoxNewMapName";
            this.textBoxNewMapName.Size = new System.Drawing.Size(199, 27);
            this.textBoxNewMapName.TabIndex = 0;
            // 
            // comboBoxSelectorMap
            // 
            this.comboBoxSelectorMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectorMap.FormattingEnabled = true;
            this.comboBoxSelectorMap.Items.AddRange(new object[] {
            "Простая карта"});
            this.comboBoxSelectorMap.Location = new System.Drawing.Point(13, 68);
            this.comboBoxSelectorMap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSelectorMap.Name = "comboBoxSelectorMap";
            this.comboBoxSelectorMap.Size = new System.Drawing.Size(199, 28);
            this.comboBoxSelectorMap.TabIndex = 1;
            // 
            // buttonShowOnMap
            // 
            this.buttonShowOnMap.Location = new System.Drawing.Point(6, 546);
            this.buttonShowOnMap.Name = "buttonShowOnMap";
            this.buttonShowOnMap.Size = new System.Drawing.Size(243, 41);
            this.buttonShowOnMap.TabIndex = 19;
            this.buttonShowOnMap.Text = "Посмотреть карту";
            this.buttonShowOnMap.UseVisualStyleBackColor = true;
            this.buttonShowOnMap.Click += new System.EventHandler(this.buttonShowOnMap_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::AirBomber.Properties.Resources.arrowRight;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRight.Location = new System.Drawing.Point(148, 653);
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
            this.buttonDown.Location = new System.Drawing.Point(112, 653);
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
            this.buttonLeft.Location = new System.Drawing.Point(76, 653);
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
            this.buttonUp.Location = new System.Drawing.Point(112, 617);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 15;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonShowStorage
            // 
            this.buttonShowStorage.Location = new System.Drawing.Point(6, 499);
            this.buttonShowStorage.Name = "buttonShowStorage";
            this.buttonShowStorage.Size = new System.Drawing.Size(243, 41);
            this.buttonShowStorage.TabIndex = 14;
            this.buttonShowStorage.Text = "Посмотреть хранилище";
            this.buttonShowStorage.UseVisualStyleBackColor = true;
            this.buttonShowStorage.Click += new System.EventHandler(this.buttonShowStorage_Click);
            // 
            // buttonRemoveAirBomber
            // 
            this.buttonRemoveAirBomber.Location = new System.Drawing.Point(6, 452);
            this.buttonRemoveAirBomber.Name = "buttonRemoveAirBomber";
            this.buttonRemoveAirBomber.Size = new System.Drawing.Size(243, 41);
            this.buttonRemoveAirBomber.TabIndex = 13;
            this.buttonRemoveAirBomber.Text = "Удалить бомбардировщик";
            this.buttonRemoveAirBomber.UseVisualStyleBackColor = true;
            this.buttonRemoveAirBomber.Click += new System.EventHandler(this.buttonRemoveAirBomber_Click);
            // 
            // maskedTextBoxPosition
            // 
            this.maskedTextBoxPosition.Location = new System.Drawing.Point(31, 419);
            this.maskedTextBoxPosition.Mask = "00";
            this.maskedTextBoxPosition.Name = "maskedTextBoxPosition";
            this.maskedTextBoxPosition.Size = new System.Drawing.Size(199, 27);
            this.maskedTextBoxPosition.TabIndex = 12;
            this.maskedTextBoxPosition.ValidatingType = typeof(int);
            // 
            // buttonAddAirBomber
            // 
            this.buttonAddAirBomber.Location = new System.Drawing.Point(6, 372);
            this.buttonAddAirBomber.Name = "buttonAddAirBomber";
            this.buttonAddAirBomber.Size = new System.Drawing.Size(243, 41);
            this.buttonAddAirBomber.TabIndex = 11;
            this.buttonAddAirBomber.Text = "Добавить бомбардировщик";
            this.buttonAddAirBomber.UseVisualStyleBackColor = true;
            this.buttonAddAirBomber.Click += new System.EventHandler(this.buttonAddAirBomber_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(621, 695);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.LoadToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.LoadToolStripMenuItem.Text = "Загрузить";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // FormMapWithSetAirBombers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 723);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBoxTools);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMapWithSetAirBombers";
            this.Text = "Карта с набором объектов";
            this.groupBoxTools.ResumeLayout(false);
            this.groupBoxTools.PerformLayout();
            this.groupBoxMaps.ResumeLayout(false);
            this.groupBoxMaps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxTools;
        private PictureBox pictureBox;
        private MaskedTextBox maskedTextBoxPosition;
        private Button buttonAddAirBomber;
        private Button buttonShowStorage;
        private Button buttonRemoveAirBomber;
        private Button buttonRight;
        private Button buttonDown;
        private Button buttonLeft;
        private Button buttonUp;
        private Button buttonShowOnMap;
        private GroupBox groupBoxMaps;
        private Button buttonAddMap;
        private Button buttonDeleteMap;
        private ListBox listBoxMaps;
        private TextBox textBoxNewMapName;
        private ComboBox comboBoxSelectorMap;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem LoadToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}