using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBomber
{
    public partial class FormAirBomberConfig : Form
    {
        DrawingAirBomber _airBomber = null;

        public FormAirBomberConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += PanelColor_MouseDown;
            panelPurple.MouseDown += PanelColor_MouseDown;
            panelGray.MouseDown += PanelColor_MouseDown;
            panelGreen.MouseDown += PanelColor_MouseDown;
            panelRed.MouseDown += PanelColor_MouseDown;
            panelWhite.MouseDown += PanelColor_MouseDown;
            panelYellow.MouseDown += PanelColor_MouseDown;
            panelBlue.MouseDown += PanelColor_MouseDown;
        }

        private void DrawAirBomber()
        {
            Bitmap bmp = new(pictureBoxObject.Width, pictureBoxObject.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _airBomber?.SetPosition(5, 5, pictureBoxObject.Width, pictureBoxObject.Height);
            _airBomber?.DrawTransport(gr);
            pictureBoxObject.Image = bmp;
        }

        private void labelObject_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Label).DoDragDrop((sender as Label).Name, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void PanelObject_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelObject_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "labelSimpleObject":
                    _airBomber = new DrawingAirBomber((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "labelModifiedObject":
                    _airBomber = new DrawingHeavyAirBomber((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black,
                        checkBoxBombs.Checked, checkBoxFuelTank.Checked, checkBoxTailLine.Checked);
                    break;
            }
            DrawAirBomber();
        }

        private void PanelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            _airBomber?.AirBomber?.setColor(Color.FromName(e.Data.GetData(DataFormats.Text).ToString()));
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (_airBomber.AirBomber is EntityHeavyAirBomber heavyAirBomber)
            {
                heavyAirBomber.setDopColor(Color.FromName(e.Data.GetData(DataFormats.Text).ToString()));
            }
        }
    }
}
