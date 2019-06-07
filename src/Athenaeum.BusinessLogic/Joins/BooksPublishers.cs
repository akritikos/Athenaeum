namespace Kritikos.Athenaeum.BusinessLogic.Joins
{
	using Kritikos.Athenaeum.BusinessLogic.Entities;

	public class BooksPublishers
	{
		public long Id { get; set; }

		public virtual Book Book { get; set; }

		public virtual Publisher Publisher { get; set; }
	}
}
