using GoodsStore.ModelApi;
using GoodsStore.Services;
using System;
using System.Web.Http;
using System.Web.Security;

namespace GoodsStore.Controllers
{
	[VersionRoute("user")]
	public class UserController : ControllerBase<UserModelApi, Guid>
	{
		private readonly UserService _service;

		public UserController(UserService _injectedService) : base(_injectedService)
		{
			_service = _injectedService;
		}

		[Route("signIn")]
		[HttpPost]
		public ResponseModel<UserModelApi> SignIn(UserModelApi model)
		{ 
			var response = new ResponseModel<UserModelApi>();

			var res = _service.VerifyUser(model.Email, model.Password);

			if (res!=null)
			{
				response.Item = res;
				FormsAuthentication.SetAuthCookie(model.Email, true);
			}
			else 
				response.AddError("User wtih this e-mail and login abscent"); 

			return response;
		}

		[Route("signUp")]
		[HttpPost]
		public ResponseModel<UserModelApi> SignUp(UserModelApi model)
		{
			var response = new ResponseModel<UserModelApi>();

			var res = _service.Create(model);

			if (res!=null)  
				response.Item = res;  
			else 
				response.AddError("User wtih this e-mail and login already exists");
			  
			return response;
		}

		[HttpGet]
		[Route("logOut")]
		public ResponseBase LogOut()
		{
			if(User.Identity.IsAuthenticated)
				FormsAuthentication.SignOut();

			return new ResponseBase();
		}

	}
}
