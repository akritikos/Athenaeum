namespace Kritikos.Athenaeum.BusinessLogic.Entities
{
	public class BookData
	{
		public long Id { get; set; }

		public virtual Book Book { get; set; }

		public string Format { get; set; }

		public long UncompressedSize { get; set; }

		public string Name { get; set; }
	}
}
