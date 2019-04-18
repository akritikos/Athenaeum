namespace Kritikos.Athenaeum.Web.Models
{
	using System;
	using System.Collections.Generic;

	public partial class BooksSeriesLink
	{
		public long Id { get; set; }

		public long Book { get; set; }

		public long Series { get; set; }
	}
}
