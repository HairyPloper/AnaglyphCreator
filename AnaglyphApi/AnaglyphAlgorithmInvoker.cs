﻿using System;
using AnaglyphGenerator.Models;
using System.Drawing;
using Picture3D;

namespace AnaglyphGenerator.Models
{
    public class AnaglyphAlgorithmInvoker
    {
        private IAnaglyph algorithm;

        public AnaglyphAlgorithmInvoker(string kindOfAlgorithm)
        {
            switch (kindOfAlgorithm)
            {
                case "True Anaglyph":
                    algorithm = new TrueAnaglyph();
                    break;
                case "Gray Anaglyph":
                    algorithm = new GrayAnaglyph();
                    break;
                case "Color Anaglyph":
                    algorithm = new ColorAnaglyph();
                    break;
                case "Half-color Anaglyph":
                    System.Diagnostics.Debug.WriteLine("sssssss");
                    algorithm = new HalfColorAnaglyph();
                    break;
                case "Optimized Anaglyph":
                default:
                    algorithm = new OptimizedAnaglyph();
                    break;
            }
        }

        public Bitmap Apply(Bitmap Image)
        {
            System.Diagnostics.Debug.WriteLine("SSSSS");
            return algorithm.Calc(Image);
        }

    }
}