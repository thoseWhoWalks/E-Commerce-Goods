using GoodsStore.ModelApi;
using GoodsStore.Services;
using System;
using System.Linq;
using System.Web.Http;

namespace GoodsStore.Controllers
{
	[Authorize]
	[VersionRoute("order")]
	public class OrderController : ControllerBase<OrderModelApi, Guid>
	{
		private OrderService _service;

		public OrderController(OrderService _injectedService) : base(_injectedService)
		{
			_service = _injectedService;
		}

		[HttpGet]
		[Route("getOrders")]
		public ResponseListModel<OrderModelApi> GetOrdersByUser([FromUri]Guid Id)
		{

			var response = new ResponseListModel<OrderModelApi>();
			

			//if (User.Identity.IsAuthenticated)
			{
				response.Items = _service.GetOrdersByUser(Id).ToList();
			}
			//else
				//response.AddError("You should be authorised to see this tab");

			return response;
		}
	}
}