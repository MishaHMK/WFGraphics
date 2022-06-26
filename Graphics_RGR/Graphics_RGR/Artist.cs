using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graphics_RGR
{
    internal class Artist
    {
        public Bitmap BuildFern(PictureBox pb)
        {
            const int w = 600;
            const int h = 600;
            var bitMap = new Bitmap(w, h);
            var randNum = new Random();
                

            double x = 0;
            double y = 0;

            for (int count = 0; count < 100000; count++)
            {
                bitMap.SetPixel((int)(300 + 58 * x), (int)(58 * y), Color.ForestGreen); //установка зеленого пікселя за координатами

                int roll = randNum.Next(100); //рандомне ціле число від 0 до 100

                double xp = x;

                if (roll < 1) // 1% випадків (стебло)
                {
                    x = 0;
                    y = 0.16 * y;
                }
                else if (roll < 86) // 85% випадків (листки, що послідовно зменшуються)
                {
                    x = 0.85 * x + 0.04 * y;
                    y = -0.04 * xp + 0.85 * y + 1.6;
                }
                else if (roll < 93) // 7% випадків (найбільший лівий листок)
                {
                    x = 0.2 * x - 0.26 * y;
                    y = 0.23 * xp + 0.22 * y + 1.6;
                }
                else //7% випадків (найбільший правий листок)
                {
                    x = -0.15 * x + 0.28 * y;
                    y = 0.26 * xp + 0.24 * y + 0.44;
                }
            }

            bitMap.RotateFlip(RotateFlipType.Rotate180FlipNone);

            return bitMap;
        }
    }
}
