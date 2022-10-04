namespace AirBomber
{
    public partial class FormAirBomber : Form
    {
        private DrawingAirBomber _airBomber;
        /// <summary>
        /// Выбранный объект
        /// </summary>
        public DrawingAirBomber SelectedAirBomber { get; private set; }

        public FormAirBomber()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new(pictureBoxAirBomber.Width, pictureBoxAirBomber.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _airBomber?.DrawTransport(gr);
            pictureBoxAirBomber.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateAirBomber_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            Color color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            ColorDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;
            }
            _airBomber = new DrawingAirBomber(rnd.Next(100, 300), rnd.Next(1000, 2000), color);
            SetData();
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок движения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = ((Button)sender)?.Name ?? string.Empty;
            switch (name)
            {
                case "buttonUp":
                    _airBomber?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    _airBomber?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    _airBomber?.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    _airBomber?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
        /// <summary>
        /// Изменение размеров формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAirBomber_Resize(object sender, EventArgs e)
        {
            _airBomber?.ChangeBorders(pictureBoxAirBomber.Width, pictureBoxAirBomber.Height);
            Draw();
        }

        /// <summary>
		/// Метод установки данных
		/// </summary>
		private void SetData()
        {
            Random rnd = new();
            _airBomber.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAirBomber.Width, pictureBoxAirBomber.Height);
            toolStripStatusLabelSpeed.Text = $"Скорость: {_airBomber.AirBomber.Speed}";
            toolStripStatusLabelWeight.Text = $"Вес: {_airBomber.AirBomber.Weight}";
            toolStripStatusLabelBodyColor.Text = $"Цвет: {_airBomber.AirBomber.BodyColor.Name}";
        }

        /// <summary>
        /// Обработка нажатия кнопки "Модификация"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateModif_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            Color color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            ColorDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;
            }
            Color dopColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            ColorDialog dialogDop = new();
            if (dialogDop.ShowDialog() == DialogResult.OK)
            {
                dopColor = dialogDop.Color;
            }
            _airBomber = new DrawingHeavyAirBomber(rnd.Next(100, 300), rnd.Next(1000, 2000),
                color,
                dopColor,
                Convert.ToBoolean(rnd.Next(0, 2)), Convert.ToBoolean(rnd.Next(0, 2)), Convert.ToBoolean(rnd.Next(0, 2)));
            SetData();
            Draw();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (_airBomber == null) return;
            SelectedAirBomber = _airBomber;
            DialogResult = DialogResult.OK;
        }
    }
}