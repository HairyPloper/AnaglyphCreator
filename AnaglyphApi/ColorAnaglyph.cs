﻿using System.Drawing;
using Picture3D;
using Picture3D.AnaglyphApi;

namespace AnaglyphGenerator.Models
{
    public class ColorAnaglyph : IAnaglyph
    {

        public ColorAnaglyph()
        {
            AnaglyphParameters.InitParameters(1,1,1,10,0);
        }

        public Bitmap Calc(Bitmap image)
        {
            int width = image.Width;
            int height = image.Height;

            int r, g, b;
            int tempX, tempY;

            Bitmap outputImage = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    tempX = x + (int)AnaglyphParameters.Xaxis;
                    tempY = y + (int)AnaglyphParameters.Yaxis;

                    if (tempX >= image.Width)
                        tempX = image.Width-1;
                    if (tempY >= image.Height)
                        tempY = image.Height-1;

                    r = image.GetPixel(x, y).R;
                    g = (image.GetPixel(tempX, tempY).G + image.GetPixel(x, y).G) / 2;
                    b = image.GetPixel(tempX, tempY).B;

                    if (r > 255)
                        r = 255;
                    if (b > 255)
                        b = 255;
                    if (g > 255)
                        g = 255;

                    Color c = Color.FromArgb(r, g, b);
                    outputImage.SetPixel(x, y, c);
                }
            }
            return outputImage;
        }
    }
}