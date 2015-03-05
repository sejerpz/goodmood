/*
 * Copyright 2015 Andrea Del Signore sejerpz@gmail.com
 */

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoodMood.Utility
{
    class Wallpaper
    {
        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);


        public enum Style : int
        {
            None,
            Tiled,
            Centered,
            Stretched
        }

        public static void Set(Image wallpaper, Style style)
        {
            string tempWallPaperPath = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
            string newWallPaperPath = Path.Combine(Path.GetTempPath(), "goodmood_wallpaper.bmp");

            using (var bmp = new Bitmap(wallpaper))
            {
                bmp.Save(tempWallPaperPath, System.Drawing.Imaging.ImageFormat.Bmp);
            }

            if (style != Style.None)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

                if (style == Style.Stretched)
                {
                    key.SetValue(@"WallpaperStyle", 2.ToString());
                    key.SetValue(@"TileWallpaper", 0.ToString());
                }
                if (style == Style.Centered)
                {
                    key.SetValue(@"WallpaperStyle", 1.ToString());
                    key.SetValue(@"TileWallpaper", 0.ToString());
                }
                if (style == Style.Tiled)
                {
                    key.SetValue(@"WallpaperStyle", 1.ToString());
                    key.SetValue(@"TileWallpaper", 1.ToString());
                }
            }

            
            try
            {
                FileCopy(tempWallPaperPath, newWallPaperPath);
            }
            catch(Exception ex)
            {
                throw new Exception("Cannot move new downloaded photo to 'wallpaper.bmp' file", ex);
            }

            SystemParametersInfo(SPI_SETDESKWALLPAPER,
                0,
                newWallPaperPath,
                SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }

        private static void FileCopy(string sourceFilename, string destFilename, bool overwrite = true, int retries = 10, int delayms = 500)
        {
            while (true)
            {
                try
                {
                    File.Copy(sourceFilename, destFilename, overwrite);
                    break;
                }
                catch (IOException ex)
                {
                    if (retries <= 0)
                    {
                        throw ex;
                    }
                    else
                    {
                        Thread.Sleep(500); // 500ms
                        retries--;
                    }
                }
            }
        }
    }
}
