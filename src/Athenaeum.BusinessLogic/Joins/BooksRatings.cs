namespace Kritikos.Athenaeum.BusinessLogic.Joins
{
	using Kritikos.Athenaeum.BusinessLogic.Entities;

	public class BooksRatings
	{
		public long Id { get; set; }

		public virtual Book Book { get; set; }

		public virtual Rating Rating { get; set; }
	}
}
