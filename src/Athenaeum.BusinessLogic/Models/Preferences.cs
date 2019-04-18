namespace Kritikos.Athenaeum.Web.Models
{
	using System;
	using System.Collections.Generic;

	public partial class Preferences
	{
		public long Id { get; set; }

		public string Key { get; set; }

		public string Val { get; set; }
	}
}
