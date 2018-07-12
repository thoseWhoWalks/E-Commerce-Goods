using GoodsStore.Data;

namespace GoodsStore.Services
{
	public class ServiceBase
	{
		protected readonly GoodsStoreContext _goodsStoreContext;

		public ServiceBase(GoodsStoreContext goodsStoreContext)
		{
			_goodsStoreContext = goodsStoreContext;
		}
	}
}
