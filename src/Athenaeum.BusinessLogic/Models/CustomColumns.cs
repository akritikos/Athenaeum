namespace Kritikos.Athenaeum.Web.Models
{
	using System;
	using System.Collections.Generic;

	public partial class CustomColumns
	{
		public long Id { get; set; }

		public string Label { get; set; }

		public string Name { get; set; }

		public string Datatype { get; set; }

		public string MarkForDelete { get; set; }

		public string Editable { get; set; }

		public string Display { get; set; }

		public string IsMultiple { get; set; }

		public string Normalized { get; set; }
	}
}
