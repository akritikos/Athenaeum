namespace Kritikos.Athenaeum.BusinessLogic.Models
{
	public class BooksSeries
	{
		public long Id { get; set; }

		public virtual Book Book { get; set; }

		public virtual Series Series { get; set; }
	}
}
