namespace AirBomber
{
    public partial class FormAirBomber : Form
    {
        private DrawingAirBomber _airBomber;

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
        /// ��������� ������� ������ "�������"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateAirBomber_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            _airBomber = new DrawingAirBomber(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            _airBomber.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAirBomber.Width, pictureBoxAirBomber.Height);
            toolStripStatusLabelSpeed.Text = $"��������: {_airBomber.AirBomber.Speed}";
            toolStripStatusLabelWeight.Text = $"���: {_airBomber.AirBomber.Weight}";
            toolStripStatusLabelBodyColor.Text = $"����: {_airBomber.AirBomber.BodyColor.Name}";
            Draw();
        }
        /// <summary>
        /// ��������� ������� ������ ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //�������� ��� ������
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
        /// ��������� �������� �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAirBomber_Resize(object sender, EventArgs e)
        {
            _airBomber?.ChangeBorders(pictureBoxAirBomber.Width, pictureBoxAirBomber.Height);
            Draw();
        }

        /// <summary>
		/// ����� ��������� ������
		/// </summary>
		private void SetData()
        {
            Random rnd = new();
            _airBomber.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAirBomber.Width, pictureBoxAirBomber.Height);
            toolStripStatusLabelSpeed.Text = $"��������: {_airBomber.AirBomber.Speed}";
            toolStripStatusLabelWeight.Text = $"���: {_airBomber.AirBomber.Weight}";
            toolStripStatusLabelBodyColor.Text = $"����: {_airBomber.AirBomber.BodyColor.Name}";
        }

        /// <summary>
        /// ��������� ������� ������ "�����������"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateModif_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            _airBomber = new DrawingHeavyAirBomber(rnd.Next(100, 300), rnd.Next(1000, 2000),
                Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)),
                Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)),
                Convert.ToBoolean(rnd.Next(0, 2)), Convert.ToBoolean(rnd.Next(0, 2)), Convert.ToBoolean(rnd.Next(0, 2)));
            SetData();
            Draw();
        }
    }
}