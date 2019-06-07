namespace Kritikos.Athenaeum.BusinessLogic.Entities
{
	using System;

	public class Book
	{
		public long Id { get; set; }

		public string Title { get; set; }

		public string Sort { get; set; }

		public DateTimeOffset Timestamp { get; set; }

		public DateTimeOffset Pubdate { get; set; }

		public double SeriesIndex { get; set; }

		public string AuthorSort { get; set; }

		public string Isbn { get; set; }

		public string Lccn { get; set; }

		public string Path { get; set; }

		public long Flags { get; set; }

		public string Uuid { get; set; }

		public bool HasCover { get; set; }

		public DateTimeOffset LastModified { get; set; }
	}
}
