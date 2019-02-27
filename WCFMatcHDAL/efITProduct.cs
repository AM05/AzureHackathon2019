namespace WCFMatcHDAL
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class efITProduct : DbContext
	{
		public efITProduct()
			: base("name=CONNefITProduct")
		{
		}

		public virtual DbSet<Wave_Plan> Wave_Plan { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
