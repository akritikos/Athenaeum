namespace Kritikos.Athenaeum.BusinessLogic.Joins
{
	using Kritikos.Athenaeum.BusinessLogic.Entities;

	public class BooksLanguages
	{
		public long Id { get; set; }

		public virtual Book Book { get; set; }

		public virtual Language LangCode { get; set; }

		public long ItemOrder { get; set; }
	}
}
