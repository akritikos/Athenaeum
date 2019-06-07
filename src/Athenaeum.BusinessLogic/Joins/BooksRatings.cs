namespace Kritikos.Athenaeum.BusinessLogic.Models
{
	public class BooksRatings
	{
		public long Id { get; set; }

		public virtual Book Book { get; set; }

		public virtual Rating Rating { get; set; }
	}
}
