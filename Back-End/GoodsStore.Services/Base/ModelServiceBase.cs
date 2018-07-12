using System;
using System.Collections.Generic;
using GoodsStore.Data;

namespace GoodsStore.Services
{
	public class ModelServiceBase<TModel,TKey> : ServiceBase
	{
		public ModelServiceBase(GoodsStoreContext goodsStoreContext) : base(goodsStoreContext)
		{
		}

		public virtual TModel Get(TKey id)
		{
			throw new NotImplementedException();
		}

		public virtual ICollection<TModel> GetAll()
		{
			throw new NotImplementedException();
		}

		public virtual TModel Update(TModel model)
		{
			throw new NotImplementedException();
		} 

		public virtual TModel Create(TModel model)
		{
			throw new NotImplementedException();
		}

		public virtual bool Delete(TKey Id)
		{
			throw new NotImplementedException();
		} 

	}
}
