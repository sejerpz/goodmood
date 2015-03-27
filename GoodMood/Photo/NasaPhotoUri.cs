using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace GoodMood.Photo
{
    class NasaPhotoUri : PhotoUri
    {
        private const string webUri = @"http://www.nasa.gov/rss/dyn/image_of_the_day.rss";

        public override string ProviderDescription
        {
            get { return "NASA Image of the Day"; }
        }

        public override async Task Update()
        {
            try
            {
                var siteUri = new Uri(webUri);
                var client = new WebClient();
                client.Headers["Accept-Charset"] = "utf-8";
                client.Encoding = Encoding.UTF8;

                string dataFeed = await client.DownloadStringTaskAsync(siteUri);                

                var xdoc = XDocument.Parse(dataFeed);
                
                var xelem = xdoc.Descendants("item").FirstOrDefault();

                if (xelem != null)
                {
                    this.PhotoDescription = xelem.Element("title").Value;
                    this.PhotoAddress = xelem.Element("enclosure").Attribute("url").Value;
                    this.WebSiteAddress = xelem.Element("link").Value;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
