using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodMood.Extensions
{
    public static class GraphicsExtension
    {
        public static void DrawShadow(this Graphics graphics, Rectangle r)
        {
            var p = new GraphicsPath();

            p.AddRectangle(r);
            DrawShadow(graphics, p);
        }

        public static void DrawShadow(this Graphics graphics, GraphicsPath path)
        {
            using (PathGradientBrush brush = new PathGradientBrush(path))
            {
                // set the wrapmode so that the colors will layer themselves
                // from the outer edge in
                brush.WrapMode = WrapMode.Clamp;

                // Create a color blend to manage our colors and positions and
                // since we need 3 colors set the default length to 3
                ColorBlend colorBlend = new ColorBlend(3);

                // here is the important part of the shadow making process, remember
                // the clamp mode on the colorblend object layers the colors from
                // the outside to the center so we want our transparent color first
                // followed by the actual shadow color. Set the shadow color to a 
                // slightly transparent DimGray, I find that it works best.|
                colorBlend.Colors = new Color[]{Color.Transparent, 
						Color.FromArgb(180, Color.Black), 
						Color.FromArgb(180, Color.Black)};

                // our color blend will control the distance of each color layer
                // we want to set our transparent color to 0 indicating that the 
                // transparent color should be the outer most color drawn, then
                // our Dimgray color at about 10% of the distance from the edge
                colorBlend.Positions = new float[] { 0f, .1f, 1f };

                // assign the color blend to the pathgradientbrush
                brush.InterpolationColors = colorBlend;

                // fill the shadow with our pathgradientbrush
                graphics.FillPath(brush, path);
            }
        }
    }
}
