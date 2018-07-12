using AutoMapper;
using GoodsStore.Data;
using GoodsStore.ModelApi;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoodsStore.Services
{
	public class OrderService : ModelServiceBase<OrderModelApi, Guid>
	{
		public OrderService(GoodsStoreContext goodsStoreContext) : base(goodsStoreContext)
		{
		}

		public override OrderModelApi Get(Guid id)
		{
			return AutoMapperConfig.Mapper.Map<OrderModelApi>(_goodsStoreContext.Orders.FirstOrDefault(o => o.Id == id));
		}

		public override ICollection<OrderModelApi> GetAll()
		{
			return AutoMapperConfig.Mapper.Map<List<OrderModelApi>>(_goodsStoreContext.Orders);
		}

		public override OrderModelApi Update(OrderModelApi model)
		{
			var res = _goodsStoreContext.Orders.FirstOrDefault(o => o.Id == model.Id);

			res.Anotation = model.Anotation;
			res.ProductId = model.ProductId;
			res.UserId = model.UserId;
			res.IsDeleted = model.IsDeleted;

			_goodsStoreContext.SaveChanges();

			return Get(res.Id);
		}

		public override OrderModelApi Create(OrderModelApi model)
		{
			var res = AutoMapperConfig.Mapper.Map<Order>(model);

			res.Id = Guid.NewGuid();

			_goodsStoreContext.Orders.Add(res);

			_goodsStoreContext.SaveChanges();

			return Get(res.Id);
		}

		public override bool Delete(Guid Id)
		{
			var res = _goodsStoreContext.Orders.FirstOrDefault(o => o.Id == Id);

			res.IsDeleted = true;

			_goodsStoreContext.SaveChanges();

			var IsSucces = Get(res.Id);

			return IsSucces == null ? false : true;
		}

		public ICollection<OrderModelApi> GetOrdersByUser(Guid Id)
		{

			var orders = _goodsStoreContext.Orders.Where(o => o.UserId == Id).ToList();

			return AutoMapperConfig.Mapper.Map<List<OrderModelApi>>(orders);
		}
	}
}
