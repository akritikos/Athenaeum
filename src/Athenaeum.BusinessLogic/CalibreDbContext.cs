namespace Kritikos.Athenaeum.BusinessLogic.Models
{
	using Kritikos.Athenaeum.BusinessLogic.Entities;
	using Kritikos.Athenaeum.BusinessLogic.Joins;
	using Microsoft.EntityFrameworkCore;

	public partial class CalibreDbContext : DbContext
	{
		public CalibreDbContext()
		{
		}

		public CalibreDbContext(DbContextOptions<CalibreDbContext> options)
			: base(options)
		{
		}

		public virtual DbSet<Author> Authors { get; set; }

		public virtual DbSet<Book> Books { get; set; }

		public virtual DbSet<BookAuthors> BookAuthors { get; set; }

		public virtual DbSet<BooksLanguages> BookLanguages { get; set; }

		public virtual DbSet<BooksPublishers> BookPublishers { get; set; }

		public virtual DbSet<BooksRatings> BookRatings { get; set; }

		public virtual DbSet<BooksSeries> BookSeries { get; set; }

		public virtual DbSet<BookMetaSeries> BookMetaSeries { get; set; }

		public virtual DbSet<MetaSeries> MetaSeries { get; set; }

		public virtual DbSet<BooksTags> BooksTags { get; set; }

		public virtual DbSet<Comment> Comments { get; set; }

		public virtual DbSet<BookData> BookData { get; set; }

		public virtual DbSet<Identifier> Identifiers { get; set; }

		public virtual DbSet<Language> Languages { get; set; }

		public virtual DbSet<Publisher> Publishers { get; set; }

		public virtual DbSet<Rating> Ratings { get; set; }

		public virtual DbSet<Series> Series { get; set; }

		public virtual DbSet<Tag> Tags { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlite("Data Source=C:\\Users\\Satellite\\Desktop\\metadata.db");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

			modelBuilder.Entity<Author>(entity =>
			{
				entity.ToTable("authors");

				entity.HasIndex(e => e.Name)
					.IsUnique();

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity.Property(e => e.Link)
					.IsRequired()
					.HasColumnName("link")
					.HasDefaultValueSql("\"\"");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name");

				entity.Property(e => e.Sort).HasColumnName("sort");
			});

			modelBuilder.Entity<Book>(entity =>
			{
				entity.ToTable("books");

				entity.HasIndex(e => e.AuthorSort)
					.HasName("authors_idx");

				entity.HasIndex(e => e.Sort)
					.HasName("books_idx");

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity.Property(e => e.AuthorSort).HasColumnName("author_sort");

				entity.Property(e => e.Flags)
					.HasColumnName("flags")
					.HasDefaultValueSql("1");

				entity.Property(e => e.HasCover)
					.HasColumnName("has_cover")
					.HasColumnType("BOOL")
					.HasDefaultValueSql("0");

				entity.Property(e => e.Isbn)
					.HasColumnName("isbn")
					.HasDefaultValueSql("\"\"");

				entity.Property(e => e.LastModified)
					.IsRequired()
					.HasColumnName("last_modified")
					.HasColumnType("TIMESTAMP")
					.HasDefaultValueSql("\"2000-01-01 00:00:00+00:00\"");

				entity.Property(e => e.Lccn)
					.HasColumnName("lccn")
					.HasDefaultValueSql("\"\"");

				entity.Property(e => e.Path)
					.IsRequired()
					.HasColumnName("path")
					.HasDefaultValueSql("\"\"");

				entity.Property(e => e.Pubdate)
					.HasColumnName("pubdate")
					.HasColumnType("TIMESTAMP")
					.HasDefaultValueSql("CURRENT_TIMESTAMP");

				entity.Property(e => e.SeriesIndex)
					.HasColumnName("series_index")
					.HasDefaultValueSql("1.0");

				entity.Property(e => e.Sort).HasColumnName("sort");

				entity.Property(e => e.Timestamp)
					.HasColumnName("timestamp")
					.HasColumnType("TIMESTAMP")
					.HasDefaultValueSql("CURRENT_TIMESTAMP");

				entity.Property(e => e.Title)
					.IsRequired()
					.HasColumnName("title")
					.HasDefaultValueSql("'Unknown'");

				entity.Property(e => e.Uuid).HasColumnName("uuid");
			});

			modelBuilder.Entity<BookAuthors>(entity =>
			{
				entity.ToTable("books_authors_link");

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity
					.HasOne(e => e.Author)
					.WithMany()
					.HasForeignKey("author");

				entity.HasOne(e => e.Book)
				.WithMany()
				.HasForeignKey("book");
			});

			modelBuilder.Entity<BooksLanguages>(entity =>
			{
				entity.ToTable("books_languages_link");

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity.HasOne(x => x.Book)
				.WithMany()
				.HasForeignKey("book");

				entity
				.HasOne(x => x.LangCode)
				.WithMany()
				.HasForeignKey("lang_code");

				entity.Property(e => e.ItemOrder).HasColumnName("item_order");
			});

			modelBuilder.Entity<BooksPublishers>(entity =>
			{
				entity.ToTable("books_publishers_link");

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity.HasOne(e => e.Book)
				.WithMany()
				.HasForeignKey("book");

				entity.HasOne(e => e.Publisher)
				.WithMany()
				.HasForeignKey("publisher");
			});

			modelBuilder.Entity<BooksRatings>(entity =>
			{
				entity.ToTable("books_ratings_link");

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity.HasOne(x => x.Book)
				.WithMany()
				.HasForeignKey("book");

				entity.HasOne(x => x.Rating)
				.WithMany()
				.HasForeignKey("rating");
			});

			modelBuilder.Entity<BooksSeries>(entity =>
			{
				entity.ToTable("books_series_link");

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity.HasOne(e => e.Book)
				.WithMany()
				.HasForeignKey("book");

				entity.HasOne(e => e.Series)
				.WithMany()
				.HasForeignKey("series");
			});

			modelBuilder.Entity<BookMetaSeries>(entity =>
			{
				entity.ToTable("books_custom_column_1_link");

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity.HasOne(e => e.Book)
				.WithMany()
				.HasForeignKey("book");

				entity.HasOne(e => e.MetaSeries)
				.WithMany()
				.HasForeignKey("value");

				entity.Property(e => e.MetaSeriesIndex)
					.HasColumnName("extra")
					.HasDefaultValueSql("1.0");
			});

			modelBuilder.Entity<BooksTags>(entity =>
			{
				entity.ToTable("books_tags_link");

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity.HasOne(e => e.Book)
				.WithMany()
				.HasForeignKey("book");

				entity.HasOne(e => e.Tag)
				.WithMany()
				.HasForeignKey("tag");
			});

			modelBuilder.Entity<Comment>(entity =>
			{
				entity.ToTable("comments");

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity.Property(e => e.Text)
					.IsRequired()
					.HasColumnName("text");

				entity.HasOne(e => e.Book)
				.WithMany()
				.HasForeignKey("book");
			});

			modelBuilder.Entity<BookData>(entity =>
			{
				entity.ToTable("data");

				entity.HasIndex(e => e.Format)
					.HasName("formats_idx");

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity.Property(e => e.Format)
					.IsRequired()
					.HasColumnName("format");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name");

				entity.HasOne(e => e.Book)
				.WithMany()
				.HasForeignKey("book");

				entity.Property(e => e.UncompressedSize).HasColumnName("uncompressed_size");
			});

			modelBuilder.Entity<Identifier>(entity =>
			{
				entity.ToTable("identifiers");

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity.Property(e => e.Type)
					.IsRequired()
					.HasColumnName("type")
					.HasDefaultValueSql("\"isbn\"");

				entity.Property(e => e.Val)
					.IsRequired()
					.HasColumnName("val");

				entity.HasOne(x => x.Book)
				.WithMany()
				.HasForeignKey("book");
			});

			modelBuilder.Entity<Language>(entity =>
			{
				entity.ToTable("languages");

				entity.HasIndex(e => e.LangCode)
					.HasName("languages_idx");

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity.Property(e => e.LangCode)
					.IsRequired()
					.HasColumnName("lang_code");
			});

			modelBuilder.Entity<Publisher>(entity =>
			{
				entity.ToTable("publishers");

				entity.HasIndex(e => e.Name)
					.HasName("publishers_idx");

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name");

				entity.Property(e => e.Sort).HasColumnName("sort");
			});

			modelBuilder.Entity<Rating>(entity =>
			{
				entity.ToTable("ratings");

				entity.HasIndex(e => e.Value)
					.IsUnique();

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity.Property(e => e.Value).HasColumnName("rating");
			});

			modelBuilder.Entity<Series>(entity =>
			{
				entity.ToTable("series");

				entity.HasIndex(e => e.Name)
					.HasName("series_idx");

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name");

				entity.Property(e => e.Sort).HasColumnName("sort");
			});

			modelBuilder.Entity<MetaSeries>(entity =>
			{
				entity.ToTable("custom_column_1");

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("value");
			});

			modelBuilder.Entity<Tag>(entity =>
			{
				entity.ToTable("tags");

				entity.HasIndex(e => e.Name)
					.HasName("tags_idx");

				entity.Property(e => e.Id)
					.HasColumnName("id")
					.ValueGeneratedNever();

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name");
			});
		}
	}
}
