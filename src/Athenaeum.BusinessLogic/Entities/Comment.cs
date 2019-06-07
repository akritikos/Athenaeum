namespace Kritikos.Athenaeum.BusinessLogic.Entities
{
	public class Comment
	{
		public long Id { get; set; }

		public virtual Book Book { get; set; }

		public string Text { get; set; }
	}
}
