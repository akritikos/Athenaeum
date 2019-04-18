namespace Kritikos.Athenaeum.Web.Models
{
	using System;
	using System.Collections.Generic;

	public partial class BooksLanguagesLink
	{
		public long Id { get; set; }

		public long Book { get; set; }

		public long LangCode { get; set; }

		public long ItemOrder { get; set; }
	}
}
