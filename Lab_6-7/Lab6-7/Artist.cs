using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab6_7
{
    internal class Artist
    {
        public Image DrawLine(PictureBox pb, int[] xy)
        {
            var bmp = new Bitmap(pb.Width, pb.Height);
            var gr = Graphics.FromImage(bmp);

            gr = CentralizeGraphics(gr, pb);


            Gitter(gr, pb);

            var xPen = new Pen(Color.FromArgb(50, Color.Green), 1);
            var yPen = new Pen(Color.FromArgb(50, Color.DodgerBlue), 1);
            gr.DrawLine(xPen, -pb.Width / 2, 0, pb.Width / 2, 0);
            gr.DrawLine(yPen, 0, -pb.Height / 2, 0, pb.Height / 2);

            Draw(bmp, xy);

            return (Image)bmp.Clone();
        }


        public Image DrawCircle(PictureBox pb, int[] xy, int radius)
        {
            var bmp = new Bitmap(pb.Width, pb.Height);
            var gr = Graphics.FromImage(bmp);

            gr = CentralizeGraphics(gr, pb);


            Gitter(gr, pb);

            var xPen = new Pen(Color.FromArgb(50, Color.Green), 1);
            var yPen = new Pen(Color.FromArgb(50, Color.DodgerBlue), 1);
            gr.DrawLine(xPen, -pb.Width / 2, 0, pb.Width / 2, 0);
            gr.DrawLine(yPen, 0, -pb.Height / 2, 0, pb.Height / 2);

            Circle(bmp, xy, radius);

            return (Image)bmp.Clone();
        }

        private void Draw(Bitmap bmp, int[] xy)
        {
            int x = xy[0], y = xy[1], 
                x1 = xy[2], y1 = xy[3], 
                i = xy[0];

            double Dy = 0, Dx = 0, D = 0, X = xy[0], Y = xy[1];


            bmp.SetPixel(xy[0] + bmp.Width / 2, xy[1] + bmp.Height / 2, Color.Black);   

            while (x < x1)
            {
                bmp.SetPixel(x + bmp.Width / 2, y + bmp.Height / 2, Color.Black);

                Y = (xy[3] - xy[1]) * (X - xy[0]) / (xy[2] - xy[0]) + xy[1];
                Dy = Y - y;
                if (Dy > 0.5)
                {
                    y++;
                }
                if (xy[0] < xy[2])
                {
                    x++;
                }
                if (xy[0] > xy[2])
                {
                    x--;
                }
                X = x;
            }
 
            while (x > xy[2])
            {
                bmp.SetPixel(x + bmp.Width / 2, y + bmp.Height / 2, Color.Black);

                Y = (xy[3] - xy[1]) * (X - xy[0]) / (xy[2] - xy[0]) + xy[1];

                Dy = Y - y;

                if (Dy > 0.5)
                {
                    y++;
                }
                if (xy[0] > xy[2])
                {
                    x--;
                }
                X = x;
            }

            bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
        }


        private void Circle(Bitmap bmp, int[] xy, int radius)
        {
            int r = radius; //radius
            int c = 0; //y
            int radiusError = 1 - r;

            bmp.SetPixel(xy[0] + bmp.Width / 2, xy[1] + bmp.Height / 2, Color.Black);

            while (r >= c)
            {
                bmp.SetPixel(r + xy[0] + bmp.Width / 2, c + xy[1] + bmp.Height / 2, Color.Black);
                bmp.SetPixel(c + xy[0] + bmp.Width / 2, r + xy[1] + bmp.Height / 2, Color.Black);
                bmp.SetPixel(-r + xy[0] + bmp.Width / 2, c + xy[1] + bmp.Height / 2, Color.Black);
                bmp.SetPixel(-c + xy[0] + bmp.Width / 2, r + xy[1] + bmp.Height / 2, Color.Black);
                bmp.SetPixel(-r + xy[0] + bmp.Width / 2, -c + xy[1] + bmp.Height / 2, Color.Black);
                bmp.SetPixel(-c + xy[0] + bmp.Width / 2, -r + xy[1] + bmp.Height / 2, Color.Black);
                bmp.SetPixel(r + xy[0] + bmp.Width / 2, -c + xy[1] + bmp.Height / 2, Color.Black);
                bmp.SetPixel(c + xy[0] + bmp.Width / 2, -r + xy[1] + bmp.Height / 2, Color.Black);

                c++;

                if (radiusError < 0)
                {
                    radiusError += 2 * c + 1;
                }
                else
                {
                    r--;
                    radiusError += 2 * (c - r + 1);
                }
            }
            bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
        }

        private void Gitter(Graphics gr, PictureBox pb)
        {
            var pen = new Pen(Color.FromArgb(35, Color.LightBlue), 1);
            for (var i = -pb.Width / 2; i < pb.Width; i += 2)
            {
                gr.DrawLine(pen, -pb.Width / 2, i, pb.Width / 2, i);
                gr.DrawLine(pen, i, -pb.Width / 2, i, pb.Width / 2);
            }
        }

        private Graphics CentralizeGraphics(Graphics gr, PictureBox pb)
        {
            // Flip the Y-Axis
            gr.ScaleTransform(1.0F, -1.0F);

            // Translate the drawing area accordingly
            gr.TranslateTransform((float)pb.Width / 2, -(float)pb.Height / 2);

            return gr;
        }
    }
}
