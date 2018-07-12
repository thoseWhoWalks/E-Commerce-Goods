using GoodsStore.ModelApi;
using GoodsStore.Services;
using System.Linq;
using System.Web.Http;

namespace GoodsStore
{
	public class ControllerBase<TModel,TKey>:ApiController
	{
		private readonly ModelServiceBase<TModel, TKey> _service;

		public ControllerBase(ModelServiceBase<TModel, TKey> _injectedService)
		{
			_service = _injectedService;
		}

		[Route("get")]
		[HttpGet]
		public ResponseModel<TModel> Get(TKey Id)
		{
			return new ResponseModel<TModel>
			{
				Item = _service.Get(Id)
			};
		}

		[Route("getAll")]
		[HttpGet]
		public ResponseListModel<TModel> GetAll()
		{
			return new ResponseListModel<TModel>
			{
				Items = _service.GetAll().ToList()
			};
		}

		[Route("create")]
		[HttpPost]
		public ResponseModel<TModel> Create(TModel model)
		{
			return new ResponseModel<TModel>
			{
				Item = _service.Create(model)
			};
		}

		[Route("update")]
		[HttpPut]
		public ResponseModel<TModel> Update(TModel model)
		{
			return new ResponseModel<TModel>
			{
				Item = _service.Update(model)
			};
		}

		[Route("delete")]
		[HttpDelete]
		public ResponseBase Delete(TKey Id)
		{
			return new ResponseBase
			{
				  Ok = _service.Delete(Id)
			};
		}
	}
}