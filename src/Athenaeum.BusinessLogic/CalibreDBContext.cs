using System;
using System.Collections.Generic;
using System.Text;
using Kritikos.Athenaeum.BusinessLogic.Models;
using Microsoft.EntityFrameworkCore;

namespace Kritikos.Athenaeum.BusinessLogic
{
	public class CalibreDBContext : DbContext
	{
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Authors>()
				.ToTable("authors");
			modelBuilder.Entity<Books>()
				.ToTable("books")
				.Property(b => b.Id)
				.IsRequired();
			modelBuilder.Entity<BooksAuthorsLink>()
				.ToTable("books_authors_link");
			modelBuilder.Entity<BooksLanguagesLink>()
				.ToTable("books_languages_link");
			modelBuilder.Entity<BooksPluginData>()
				.ToTable("books_plugin_data");
			modelBuilder.Entity<BooksPublishersLink>()
				.ToTable("books_publishers_link");
			modelBuilder.Entity<BooksRatingsLink>()
				.ToTable("books_ratings_link");
			modelBuilder.Entity<BooksSeriesLink>()
				.ToTable("books_series_link");
			modelBuilder.Entity<BooksTagsLink>()
				.ToTable("books_tags_link");
			modelBuilder.Entity<Comments>()
				.ToTable("comments");
			modelBuilder.Entity<ConversionOptions>()
				.ToTable("conversion_options");
			modelBuilder.Entity<CustomColumns>()
				.ToTable("custom_columns");
			modelBuilder.Entity<Data>()
				.ToTable("data");
			modelBuilder.Entity<Feeds>()
				.ToTable("feeds");
			modelBuilder.Entity<Identifiers>()
				.ToTable("identifiers");
			modelBuilder.Entity<Languages>()
				.ToTable("languages");
			modelBuilder.Entity<LastReadPositions>()
				.ToTable("last_read_positions");
			modelBuilder.Entity<LibraryId>()
				.ToTable("library_id");
			modelBuilder.Entity<MetadataDirtied>()
				.ToTable("metadata_dirtied");
			modelBuilder.Entity<Preferences>()
				.ToTable("preferences");
			modelBuilder.Entity<Publishers>()
				.ToTable("publishers");
			modelBuilder.Entity<Ratings>()
				.ToTable("ratings");
			modelBuilder.Entity<Series>()
				.ToTable("series");
			modelBuilder.Entity<Tags>()
				.ToTable("tags");
		}
	}
}
