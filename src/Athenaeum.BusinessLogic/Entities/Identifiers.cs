namespace Kritikos.Athenaeum.BusinessLogic.Models
{
	public partial class Identifier
	{
		public long Id { get; set; }

		public virtual Book Book { get; set; }

		public string Type { get; set; }

		public string Val { get; set; }
	}
}
