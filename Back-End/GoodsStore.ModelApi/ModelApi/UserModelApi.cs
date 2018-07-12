using GoodsStore.Data;
using System;

namespace GoodsStore.ModelApi
{
	public class UserModelApi
	{
		public Guid Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; } 
		public Gender Gender { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public bool IsDeleted { get; set; }
	}
}
