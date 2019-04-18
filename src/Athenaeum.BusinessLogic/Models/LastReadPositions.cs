namespace Kritikos.Athenaeum.Web.Models
{
	using System;
	using System.Collections.Generic;

	public partial class LastReadPositions
	{
		public long Id { get; set; }

		public long Book { get; set; }

		public string Format { get; set; }

		public string User { get; set; }

		public string Device { get; set; }

		public string Cfi { get; set; }

		public double Epoch { get; set; }

		public double PosFrac { get; set; }
	}
}
