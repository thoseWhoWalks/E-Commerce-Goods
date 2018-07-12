using System;

namespace GoodsStore.ModelApi
{
	public class ProductModelApi
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int Price { get; set; }
		public bool IsDeleted { get; set; }
	}
}
