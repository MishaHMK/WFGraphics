using Microsoft.Azure.Amqp.Framing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_RGR
{
    public partial class Form1 : Form
    {
        private int ImageWidth, ImageHeight;
        private float ImageScale = 1.0f;
        private int _xPos;
        private int _yPos;
        private bool _dragging;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pbResult.SendToBack();
            ImageWidth = pbResult.Width;
            ImageHeight = pbResult.Height;
            pbResult.SizeMode = PictureBoxSizeMode.Zoom;
            pbResult.Size = new Size(ImageWidth, ImageHeight);
            MouseWheel += OnMouseWheel;
        }

        private void pbResult_MouseMove(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (!_dragging || null == c) return;
            c.Top = e.Y + c.Top - _yPos;
            c.Left = e.X + c.Left - _xPos;
        }

        private void pbResult_MouseUp(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (null == c) return;
            _dragging = false;
        }

        private void pbResult_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _dragging = true;
            _xPos = e.X;
            _yPos = e.Y;
        }

        private void bDraw_Click_1(object sender, EventArgs e)
        {
            var artist = new Artist();
            Bitmap fernBmp = artist.BuildFern(pbResult);
            pbResult.Image = new Bitmap(fernBmp);
        }

        private void pDel_Click(object sender, EventArgs e)
        {
            pbResult.Image = null;
            File.Delete("Fern.png");
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            Bitmap fernBmp = new Bitmap(pbResult.Image);
            const string filename = "Fern.png";
            fernBmp.Save(filename);
        }

        private void OnMouseWheel(object sender, MouseEventArgs e)
        {
            // The amount by which we adjust scale per wheel click.
            const float scale_per_delta = 0.1f / 120;

            // Update the drawing based upon the mouse wheel scrolling.
            ImageScale += e.Delta * scale_per_delta;
            if (ImageScale < 0) ImageScale = 0;

            // Size the image.
            pbResult.Size = new Size(
                (int)(ImageWidth * ImageScale),
                (int)(ImageHeight * ImageScale));

            // Display the new scale.
            pbResult.Text = ImageScale.ToString("p0");
        }
    }
}
