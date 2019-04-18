namespace Kritikos.Athenaeum.Web.Models
{
	using System;
	using System.Collections.Generic;

	public partial class BooksPluginData
	{
		public long Id { get; set; }

		public long Book { get; set; }

		public string Name { get; set; }

		public string Val { get; set; }
	}
}
