/*
 * Copyright 2015 Andrea Del Signore sejerpz@gmail.com
 */

using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GoodMood
{
    class NationalGeographicPoDPictureUri : PictureUri
    {
        private const string webUri = @"http://photography.nationalgeographic.com/photography/photo-of-the-day/";

        public override string WebSiteAddress
        {
            get
            {
                return webUri;
            }
        }

        public override string ProviderDescription
        {
            get { return "National Geographic"; }
        }

        public override async Task Update()
        {
            var siteUri = new Uri(webUri);
            var client = new WebClient();
            var data = await client.DownloadDataTaskAsync(siteUri);
            string html;

            using (var storage = new MemoryStream(data))
            using (var reader = new StreamReader(storage))
            {
                html = reader.ReadToEnd();
            }

            try
            {
                var doc = new HtmlDocument();
                doc.LoadHtml(html);
                var divs = doc.DocumentNode.Descendants("div").Where(d =>
                        d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("primary_photo")
                );
                foreach (var div in divs)
                {
                    var img = div.Descendants("img").FirstOrDefault();
                    if (img != null)
                    {
                        if (img.HasAttributes)
                        {
                            var newUri = new Uri(siteUri, img.Attributes["src"].Value);
                            this.PhotoAddress = newUri.AbsoluteUri;
                            if (img.Attributes["alt"] != null)
                            {
                                this.PhotoDescription = img.Attributes["alt"].Value;
                            }
                        }
                        break;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }

}
