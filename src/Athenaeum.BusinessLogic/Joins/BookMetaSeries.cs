namespace Kritikos.Athenaeum.BusinessLogic.Joins
{
	using Kritikos.Athenaeum.BusinessLogic.Entities;
	using Kritikos.Athenaeum.BusinessLogic.Models;

	public class BookMetaSeries
	{
		public long Id { get; set; }

		public virtual Book Book { get; set; }

		public virtual MetaSeries MetaSeries { get; set; }

		public double MetaSeriesIndex { get; set; }
	}
}
