using System.Data.Entity;

namespace GoodsStore.Data
{
	public class GoodsStoreContext : DbContext
	{
		 
		public GoodsStoreContext() : base("GoodsStoreConnectionString")
		{
			
			//Database.SetInitializer<GoodsStoreContext>(new GoodsStoreContextInit());
			//this.Database.Initialize(true);
		}

		public DbSet<User> Users {get;set;}
		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; } 
	}
}
