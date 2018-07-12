using System.Collections.Generic;

namespace GoodsStore.ModelApi
{
	public class ResponseListModel<TModel>:ResponseBase
	{
		public List<TModel> Items { get; set; }
	}
}
