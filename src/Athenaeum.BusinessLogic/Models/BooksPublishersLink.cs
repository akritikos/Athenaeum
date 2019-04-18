namespace Kritikos.Athenaeum.Web.Models
{
	using System;
	using System.Collections.Generic;

	public partial class BooksPublishersLink
	{
		public long Id { get; set; }

		public long Book { get; set; }

		public long Publisher { get; set; }
	}
}
