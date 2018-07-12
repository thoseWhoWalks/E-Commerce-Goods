using System;

namespace GoodsStore.ModelApi
{
	public class OrderModelApi
	{
		public Guid Id { get; set; }
		public string Anotation { get; set; }
		public Guid UserId { get; set; }
		public Guid ProductId { get; set; }
		public bool IsDeleted { get; set; }
	}
}
