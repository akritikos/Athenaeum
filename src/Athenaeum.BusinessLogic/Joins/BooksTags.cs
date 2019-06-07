namespace Kritikos.Athenaeum.BusinessLogic.Models
{
	public partial class BooksTags
	{
		public long Id { get; set; }

		public virtual Book Book { get; set; }

		public virtual Tag Tag { get; set; }
	}
}
