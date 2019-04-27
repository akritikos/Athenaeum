namespace Kritikos.Athenaeum.BusinessLogic.Models
{
	public partial class Comments
	{
		public long Id { get; set; }

		public long Book { get; set; }

		public string Text { get; set; }
	}
}
