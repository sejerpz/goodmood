/*
 * Copyright 2015 Andrea Del Signore sejerpz@gmail.com
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GoodMood.Photo
{
    class PhotoDowloader
    {
        public Image Image { get; private set; }

        public async Task Download(PhotoUri picture)
        {
            try
            {
                var client = new WebClient();
                var data = await client.DownloadDataTaskAsync(new Uri(picture.PhotoAddress));

                using (var storage = new MemoryStream(data))
                {
                    this.Image = System.Drawing.Image.FromStream(storage);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
