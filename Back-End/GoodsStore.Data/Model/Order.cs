using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodsStore.Data
{
	public class Order
	{
		[Key]
		public Guid Id { get; set; }
		public string Anotation { get; set; }
		[ForeignKey(nameof(Users))]
		public Guid UserId { get; set; } 
		[ForeignKey(nameof(Products))]
		public Guid ProductId { get; set; }
		public bool IsDeleted { get; set; }

		public virtual ICollection<User> Users { get; set; } = new List<User>();
	 
		public virtual ICollection<Product> Products { get; set; } = new List<Product>();  
	}
}
