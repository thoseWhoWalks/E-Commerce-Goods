using AutoMapper;
using GoodsStore.Data;
using GoodsStore.ModelApi;

namespace GoodsStore.Services
{
	public static class AutoMapperConfig
	{
		public static IMapper Mapper;
		
		public static void Configure()
		{
			var config = new MapperConfiguration(cfg =>
			{
				#region Users
				cfg.CreateMap<User, UserModelApi>();
				cfg.CreateMap<UserModelApi, User>();
				#endregion

				#region Product
				cfg.CreateMap<Product, ProductModelApi>();
				cfg.CreateMap<ProductModelApi, Product>();
				#endregion

				#region Order
				cfg.CreateMap<Order, OrderModelApi>();
				cfg.CreateMap<OrderModelApi, Order>();
				#endregion
				
			});

			Mapper = config.CreateMapper();
		}
	}
}
