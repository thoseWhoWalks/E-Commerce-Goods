using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GoodsStore.Data
{
	public class Product
	{
		[Key]
		public Guid Id { get; set; }
		[Required, MaxLength(30)]
		public string Title { get; set; }
		[Required, MaxLength(30)]
		public string Description { get; set; }
		[Required]
		public int Price { get; set; }
		public bool IsDeleted { get; set; }
		 
		public Order Order { get; set; }
	}
}
