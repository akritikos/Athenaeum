namespace Kritikos.Athenaeum.BusinessLogic.Joins
{
	using Kritikos.Athenaeum.BusinessLogic.Entities;

	public partial class BooksTags
	{
		public long Id { get; set; }

		public virtual Book Book { get; set; }

		public virtual Tag Tag { get; set; }
	}
}
