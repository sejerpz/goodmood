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

namespace GoodMood.Photo
{
    class NationalGeographicPhotoUri : PhotoUri
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
            try
            {
                var siteUri = new Uri(webUri);
                var client = new WebClient();
                string html;
                byte[] data = await client.DownloadDataTaskAsync(siteUri);

                using (var storage = new MemoryStream(data))
                using (var reader = new StreamReader(storage))
                {
                    html = reader.ReadToEnd();
                }

                var doc = new HtmlDocument();
                doc.LoadHtml(html);

                var meta = doc.DocumentNode.Descendants("meta").FirstOrDefault(m =>
                      m.Attributes.Contains("property") 
                      && m.Attributes.Contains("content") 
                      && (string.Compare(m.Attributes["property"].Value, "og:image", true) == 0 || string.Compare(m.Attributes["property"].Value, "twitter:image:src", true) == 0)
                );

                if (meta != null)
                {
                    var newUri = new Uri(siteUri, meta.Attributes["content"].Value);
                    this.PhotoAddress = newUri.AbsoluteUri;
                }
               
                meta = doc.DocumentNode.Descendants("meta").FirstOrDefault(m =>
                      m.Attributes.Contains("name") && m.Attributes.Contains("content") && string.Compare(m.Attributes["name"].Value, "twitter:description", true) == 0
                );
                if (meta != null)
                {
                    this.PhotoDescription = meta.Attributes["content"].Value;
                }

                if (this.PhotoAddress == null)
                {
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
            }
            catch
            {
                throw;
            }
        }
    }

}
