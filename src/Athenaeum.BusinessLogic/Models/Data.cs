namespace Kritikos.Athenaeum.BusinessLogic.Models
{
	public partial class Data
	{
		public long Id { get; set; }

		public long Book { get; set; }

		public string Format { get; set; }

		public long UncompressedSize { get; set; }

		public string Name { get; set; }
	}
}
