namespace Kritikos.Athenaeum.Web.Models
{
	using System;
	using System.Collections.Generic;

	public partial class BooksAuthorsLink
	{
		public long Id { get; set; }

		public long Book { get; set; }

		public long Author { get; set; }
	}
}
