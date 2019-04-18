namespace Kritikos.Athenaeum.Web.Models
{
	using System;
	using System.Collections.Generic;

	public partial class ConversionOptions
	{
		public long Id { get; set; }

		public string Format { get; set; }

		public long? Book { get; set; }

		public byte[] Data { get; set; }
	}
}
