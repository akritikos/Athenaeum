namespace Kritikos.Athenaeum.Web.Models
{
	using System;
	using System.Collections.Generic;

	public partial class Comments
	{
		public long Id { get; set; }

		public long Book { get; set; }

		public string Text { get; set; }
	}
}
