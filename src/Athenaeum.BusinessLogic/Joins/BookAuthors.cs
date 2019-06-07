namespace Kritikos.Athenaeum.BusinessLogic.Models
{
	public class BookAuthors
	{
		public long Id { get; set; }

		public virtual Book Book { get; set; }

		public virtual Author Author { get; set; }
	}
}
