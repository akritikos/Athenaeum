namespace Kritikos.Athenaeum.Web.Models
{
	using System;
	using System.Collections.Generic;

	public partial class Books
	{
		public long Id { get; set; }

		public string Title { get; set; }

		public string Sort { get; set; }

		public string Timestamp { get; set; }

		public string Pubdate { get; set; }

		public double SeriesIndex { get; set; }

		public string AuthorSort { get; set; }

		public string Isbn { get; set; }

		public string Lccn { get; set; }

		public string Path { get; set; }

		public long Flags { get; set; }

		public string Uuid { get; set; }

		public string HasCover { get; set; }

		public string LastModified { get; set; }
	}
}
