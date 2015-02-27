// Copyright (c) 2013 Pieroxy <pieroxy@pieroxy.net>
// This work is free. You can redistribute it and/or modify it
// under the terms of the WTFPL, Version 2
// For more information see LICENSE.txt or http://www.wtfpl.net/
//
// For more information, the home page:
// http://pieroxy.net/blog/pages/color-finder/index.html
//
// Detection of the most prominent color in an image
// version 1.1.1

// C# Porting by Andrea Del Signore

using System;
using System.Drawing;
using System.Collections.Generic;

namespace GoodMood.Utility
{
	public class ColorFinder
	{
		private Func<int, int, int, double> callback = null;

        public readonly static Func<int, int, int, double> FavorHueCallback = ColorFinder.FavorHue;
        public readonly static Func<int, int, int, double> FavorBrightCallback = ColorFinder.FavorBright;
        public readonly static Func<int, int, int, double> FavorBrighterCallback = ColorFinder.FavorBrighter;
        public readonly static Func<int, int, int, double> FavorBrightExcludeWhiteCallback = ColorFinder.FavorBrightExcludeWhite;

        public readonly static Func<int, int, int, double> FavorDarkCallback = ColorFinder.FavorDark;
        public readonly static Func<int, int, int, double> FavorDarkerCallback = ColorFinder.FavorDarker;
        public readonly static Func<int, int, int, double> FavorDarkExcludeBlackCallback = ColorFinder.FavorDarkExcludeBlack;

        public readonly static Func<int, int, int, double> ExcludeWhiteCallback = ColorFinder.ExcludeWhite;
        public readonly static Func<int, int, int, double> ExcludeBlackCallback = ColorFinder.ExcludeBlack;
        public readonly static Func<int, int, int, double> ExcludeWhiteAndBlackCallback = ColorFinder.ExcludeWhiteAndBlack;
        


        public ColorFinder(Func<int, int, int, double> callback = null)
        {
            this.callback = callback;
        }

        public Color GetMostProminentColor(Bitmap image, int offset = 0, int heigth = -1)
        {
            RgbColor rgb = null;

            if (this.callback == null)
            {
                this.callback = this.DefaultCallback;
            }
            var data = this.GetImageData(image, offset, heigth);
            rgb = this.GetMostProminentRGBImpl(data, 6, rgb, this.callback);
            rgb = this.GetMostProminentRGBImpl(data, 4, rgb, this.callback);
            rgb = this.GetMostProminentRGBImpl(data, 2, rgb, this.callback);
            rgb = this.GetMostProminentRGBImpl(data, 0, rgb, this.callback);
            return rgb.Color;
        }


        private static double FavorHue(int r, int g, int b)
        {
            return (Math.Abs(r - g) * Math.Abs(r - g) + Math.Abs(r - b) * Math.Abs(r - b) + Math.Abs(g - b) * Math.Abs(g - b)) / 65535 * 50 + 1;
        }

        private static double ExcludeWhite(int r, int g, int b)
        {
            return (r > 245 && g > 245 && b > 245) ? 0 : 1;
        }

        private static double ExcludeBlack(int r, int g, int b)
        {
            return (r < 10 && g < 10 && b < 10) ? 0 : 1;
        }

        private static double ExcludeWhiteAndBlack(int r, int g, int b)
        {
            return (r > 225 && g > 225 && b > 225) || (r < 30 && g < 30 && b < 30) ? 0 : 1;
        }

        private static double FavorBright(int r, int g, int b)
        {
            if (r > 210 && g > 210 && b > 210) return 0;
            return (r * r + g * g + b * b) / 65535 * 20 + 1;
        }

        private static double FavorBrighter(int r, int g, int b)
        {
            return r + g + b + 1;
        }

        private static double FavorBrightExcludeWhite(int r, int g, int b)
        {
            if (r > 235 && g > 235 && b > 235) return 0;
            return (r * r + g * g + b * b) / 65535 * 20 + 1;
        }

        private static double FavorDark(int r, int g, int b)
        {
            if (r < 45 && g < 45 && b < 45) return 0;
            return 768 - r - g - b + 1;
        }

        private static double FavorDarker(int r, int g, int b)
        {
            return 768 - r - g - b + 1;
        }

        private static double FavorDarkExcludeBlack(int r, int g, int b)
        {
            if (r < 15 && g < 15 && b < 15) return 0;
            return 768 - r - g - b + 1;
        }

		private class RgbColor
		{
            public Color Color;
			public double Weight;
			public int Count;
			public int Degrade;
		}

		private double DefaultCallback (int r, int g, int b)
		{
			return 1;
		}
		
		private RgbColor[] GetImageData(Bitmap image, int offset, int height) 
		{
			Dictionary<string, RgbColor> result = new Dictionary<string,RgbColor>();

			if (height == -1)
				height = image.Height;

			if (image == null) {
				return new RgbColor[0];
			}

			var width = image.Width;
			var length = height * width;

			int factor = (int)Math.Max(1, Math.Round((double)length / 1000));
			int start = offset * width;
			int end = start + length;
			for(int i = start; i < end; i+= factor)
			{
				int y = i / width;
				int x = (i - (y * width));
				Color pixel = image.GetPixel (x, y);

				if (pixel.A > 32) {
					var key = string.Format("{0},{1},{2}", (pixel.R), (pixel.G), (pixel.B));
					if (!result.ContainsKey(key)) {
						var rgb = new RgbColor () {Color = Color.FromArgb(0, pixel.R, pixel.G, pixel.B), Count = 1};
                        rgb.Weight = this.callback(rgb.Color.R, rgb.Color.G, rgb.Color.B);
						if (rgb.Weight <= 0) 
							rgb.Weight = 1e-10;
						result.Add(key, rgb);
					} else {
						result[key].Count++;
					}
				}
			}

			return new List<RgbColor>(result.Values).ToArray();
		}

		private bool DoesRgbMatch (RgbColor rgb, int r, int g, int b) {
			if (rgb == null) 
				return true;

			r = r >> rgb.Degrade;
			g = g >> rgb.Degrade;
			b = b >> rgb.Degrade;

            return rgb.Color.R == r && rgb.Color.G == g && rgb.Color.B == b;
		}

		private RgbColor GetMostProminentRGBImpl (RgbColor[] pixels, int degrade, RgbColor rgbMatch, Func<int, int, int, double> colorFactorCallback) 
		{
            var rgb = new RgbColor() { Color = Color.FromArgb(0, 0, 0), Count = 0, Degrade = degrade };

			var db = new Dictionary<string, int> ();
			string pixelGroupKey;
			var count = 0;

			foreach(var pixel in pixels) {
				int totalWeight = (int)Math.Round(pixel.Weight * pixel.Count);
				++count;
                if (this.DoesRgbMatch(rgbMatch, pixel.Color.R, pixel.Color.G, pixel.Color.B))
                {
                    pixelGroupKey = string.Format("{0},{1},{2}", (pixel.Color.R >> degrade), (pixel.Color.G >> degrade), (pixel.Color.B >> degrade));
					if (db.ContainsKey(pixelGroupKey))
						db[pixelGroupKey] += totalWeight;
					else
					{
						db.Add(pixelGroupKey, totalWeight);
					}
				}
			}

			foreach (var i in db) {
				var data = i.Key.Split(',');
				var r = data[0];
				var g = data[1];
				var b = data[2];
				count = i.Value;

				if (count > rgb.Count) {
					rgb.Count = count;
                    rgb.Color = Color.FromArgb(int.Parse(r), int.Parse(g), int.Parse(b));
				}
			}

			return rgb;
		}


	
	}
}

