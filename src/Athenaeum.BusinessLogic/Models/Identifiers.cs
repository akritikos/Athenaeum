namespace Kritikos.Athenaeum.Web.Models
{
	using System;
	using System.Collections.Generic;

	public partial class Identifiers
	{
		public long Id { get; set; }

		public long Book { get; set; }

		public string Type { get; set; }

		public string Val { get; set; }
	}
}
