namespace Kritikos.Athenaeum.Web.Models
{
	using System;
	using System.Collections.Generic;

	public partial class Authors
	{
		public long Id { get; set; }

		public string Name { get; set; }

		public string Sort { get; set; }

		public string Link { get; set; }
	}
}
