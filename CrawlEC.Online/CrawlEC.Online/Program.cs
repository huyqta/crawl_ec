using CrawlEC.Online.SiteCrawlers;
using System;

namespace CrawlEC.Online
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ItBookStore st = new ItBookStore();
            st.StartCrawl();
        }
    }
}
