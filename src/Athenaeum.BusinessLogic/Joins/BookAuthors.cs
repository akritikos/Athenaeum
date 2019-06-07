namespace Kritikos.Athenaeum.BusinessLogic.Joins
{
	using Kritikos.Athenaeum.BusinessLogic.Entities;

	public class BookAuthors
	{
		public long Id { get; set; }

		public virtual Book Book { get; set; }

		public virtual Author Author { get; set; }
	}
}
