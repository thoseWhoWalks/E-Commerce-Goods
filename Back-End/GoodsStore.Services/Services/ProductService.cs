using AutoMapper;
using GoodsStore.Data;
using GoodsStore.ModelApi;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoodsStore.Services
{
	public class ProductService : ModelServiceBase<ProductModelApi, Guid>
	{
		public ProductService(GoodsStoreContext goodsStoreContext) : base(goodsStoreContext)
		{
		}

		public override ProductModelApi Get(Guid id)
		{
			return AutoMapperConfig.Mapper.Map<ProductModelApi>(_goodsStoreContext.Products.FirstOrDefault(p => p.Id == id));
		}

		public override ICollection<ProductModelApi> GetAll()
		{
			var res = _goodsStoreContext.Products.ToList();

			return AutoMapperConfig.Mapper.Map<List<ProductModelApi>>(res);
		}

		public override ProductModelApi Update(ProductModelApi model)
		{
			var res = _goodsStoreContext.Products.FirstOrDefault(p => p.Id == model.Id);

			res.Description = model.Description;
			res.Price = model.Price;
			res.Title = model.Title;

			_goodsStoreContext.SaveChanges();

			return Get(res.Id);
		}

		public override ProductModelApi Create(ProductModelApi model)
		{
			model.Id = Guid.NewGuid();

			var newUser = AutoMapperConfig.Mapper.Map<Product>(model);
			
			_goodsStoreContext.Products.Add(newUser);
			
			_goodsStoreContext.SaveChanges();

			return Get(newUser.Id);
		}

		public override bool Delete(Guid Id)
		{
			var res = _goodsStoreContext.Products.FirstOrDefault(p => p.Id == Id);

			res.IsDeleted = true;

			_goodsStoreContext.SaveChanges();

			var IsSucces = Get(res.Id);

			return IsSucces == null ? false : true;
		}
	}
}
