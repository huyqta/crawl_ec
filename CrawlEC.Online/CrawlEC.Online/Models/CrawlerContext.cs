using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CrawlEC.Online.Models
{
    public partial class CrawlerContext : DbContext
    {
        public CrawlerContext()
        {
        }

        public CrawlerContext(DbContextOptions<CrawlerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbEbook> TbEbook { get; set; }
        public virtual DbSet<TbMovie> TbMovie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Server=128.199.183.242;User Id=huyqta;Password=huyqta;Database=crawl_ec");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<TbEbook>(entity =>
            {
                entity.ToTable("tb_ebook", "crawl_ec");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Categories)
                    .HasColumnName("categories")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DownloadUrl)
                    .HasColumnName("download_url")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasColumnName("format")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("image_url")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.IsFree)
                    .HasColumnName("is_free")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Isbn10)
                    .HasColumnName("isbn10")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Isbn13)
                    .HasColumnName("isbn13")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Language)
                    .HasColumnName("language")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Pages)
                    .HasColumnName("pages")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.PublishedDate).HasColumnName("published_date");

                entity.Property(e => e.Publisher)
                    .HasColumnName("publisher")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Tags)
                    .HasColumnName("tags")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbMovie>(entity =>
            {
                entity.ToTable("tb_movie", "crawl_ec");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("category_id_2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActorTag)
                    .HasColumnName("actor_tag")
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("\"\"");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryTag)
                    .HasColumnName("category_tag")
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("\"\"");

                entity.Property(e => e.CountLike)
                    .HasColumnName("count_like")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("95");

                entity.Property(e => e.CountView)
                    .HasColumnName("count_view")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("97");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleDrive)
                    .HasColumnName("google_drive")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("image_url")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ImdbId)
                    .HasColumnName("imdb_id")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MovieName)
                    .IsRequired()
                    .HasColumnName("movie_name")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MovieTag)
                    .HasColumnName("movie_tag")
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("\"\"");

                entity.Property(e => e.MovieType)
                    .HasColumnName("movie_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PosterUrl)
                    .HasColumnName("poster_url")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseDate).HasColumnName("release_date");

                entity.Property(e => e.StudioTag)
                    .HasColumnName("studio_tag")
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("\"\"");

                entity.Property(e => e.Trailer)
                    .HasColumnName("trailer")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });
        }
    }
}
