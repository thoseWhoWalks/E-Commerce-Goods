namespace GoodsStore.ModelApi
{
	public class ResponseModel<TModel>:ResponseBase
	{
		public TModel Item { get; set; }
	}
}
