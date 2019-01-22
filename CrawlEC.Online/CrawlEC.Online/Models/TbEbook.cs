using System;
using System.Collections.Generic;

namespace CrawlEC.Online.Models
{
    public partial class TbEbook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double? Rating { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime? PublishedDate { get; set; }
        public int? Pages { get; set; }
        public string Language { get; set; }
        public string Format { get; set; }
        public string Isbn10 { get; set; }
        public string Isbn13 { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public string Tags { get; set; }
        public string Categories { get; set; }
        public string IsFree { get; set; }
        public string DownloadUrl { get; set; }
    }
}
