namespace Kritikos.Athenaeum.BusinessLogic.Models
{
	public class BooksLanguages
	{
		public long Id { get; set; }

		public virtual Book Book { get; set; }

		public virtual Language LangCode { get; set; }

		public long ItemOrder { get; set; }
	}
}
