using CrawlEC.Online.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrawlEC.Online.SiteCrawlers
{
    public class ItBookStore
    {
        CrawlerContext context = new CrawlerContext();

        public string StartUrl = "https://itbook.store/books/free";
        public string SubUrl = "https://itbook.store/books/free?page={0}";
        public int AmountOfPage = 4;
        private int pageCount = 0;
        
        public int StartCrawl()
        {
            // Get total page of ItBookStore
            var web = new HtmlWeb();
            var htmlDoc = web.Load(StartUrl);
            for (int page = 0; page < AmountOfPage; page++)
            {
                var pageUrl = string.Format(SubUrl, page);
                htmlDoc = web.Load(pageUrl);
                var urlsItemInPage = htmlDoc.DocumentNode.SelectNodes(@"//div[@class='container'][3]/div/div/div/div/p/a/@href");
                foreach (var url in urlsItemInPage)
                {
                    var itemDoc = web.Load(url.Attributes[0].Value); // Detail Url
                    var itemName = web.Load(url.Attributes[1].Value); // Book title
                    TbEbook book = new TbEbook();
                    // Image: //div[@class='row']/div/div/img/@src
                    // Url Book: //div[@class='row']/div/div/a/@href
                    // Free book: //div[@class='row']/div/table/tbody/tr[1]/td[2]
                    // Rating: //div[@class='row']/div/table/tbody/tr[2]/td[2]
                }
            }

            return 0;
        }

    }
}
