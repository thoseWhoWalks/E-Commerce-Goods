using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodsStore.Data
{
	public class User
	{
		[Key]
		public Guid	Id { get; set; }
		[Required,MaxLength(50)]
		public string FirstName { get; set; }
		[Required, MaxLength(50)]
		public string LastName { get; set; } 
		public Gender Gender { get; set; }
		[Required]
		public string HashPassword { get; set; }
		[Required, MaxLength(128)]
		[Index(IsUnique = true)]
		public string Email { get; set; }
		public bool IsDeleted { get; set; }
		 
		public virtual Order Order { get; set; }

	}

	public enum Gender
	{
		Male = 0,
		Female = 1
	}
}
