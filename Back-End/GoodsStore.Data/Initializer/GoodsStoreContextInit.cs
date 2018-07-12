using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Helpers;
using GoodsStore.Mock;

namespace GoodsStore.Data
{
	public class GoodsStoreContextInit: DropCreateDatabaseAlways<GoodsStoreContext>
	{
		protected override void Seed(GoodsStoreContext context)
		{
			base.Seed(context);

			for (int i = 0; i < 3; i++)
			{
				context.Users.Add(new User
				{
					Id = Guid.NewGuid(),
					Email = MockString.GetEmail(),
					FirstName = MockString.GetFirstName(),
					LastName = MockString.GetLastName(),
					HashPassword = Crypto.HashPassword(MockString.GetPassword()),
				
				});
				 
				context.SaveChanges();
			}

			for (int i = 0; i < 7; i++)
			{
				context.Products.Add(new Product
				{
					Id = Guid.NewGuid(),
					Description = MockString.GetDescription(),
					Title = MockString.GetTitle(),
					Price = MockNumber.GetNumber()
				});

				context.SaveChanges();
			}
			 
			for(int i = 0; i < 15; i++)
			{
				var order = new Order
				{
					Anotation = MockString.GetNotation()
				};

				order.Products.Add(context.Products.ToList()[MockNumber.GetNumber(0,context.Products.ToList().Count)]);
				order.Users.Add(context.Users.ToList()[MockNumber.GetNumber(0, context.Users.ToList().Count)]);

				context.Orders.Add(order); 

			}

			
		}
	}
}
