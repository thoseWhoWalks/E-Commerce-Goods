using GoodsStore.ModelApi;
using GoodsStore.Services;
using System;
using System.Web.Http;

namespace GoodsStore.Controllers
{
	[Authorize]
	[VersionRoute("product")]
	public class ProductController : ControllerBase<ProductModelApi, Guid>
	{
		private readonly ProductService _service;

		public ProductController(ProductService _injectedService) : base(_injectedService)
		{
			_service = _injectedService; 
		}
	}
}
