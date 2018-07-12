using GoodsStore.Data;
using GoodsStore.Services;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace GoodsStore
{
	public class WebApiApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AutoMapperConfig.Configure();
			AutofacConfig.Configure(GlobalConfiguration.Configuration);

			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register); 
		}

		/*protected void Application_BeginRequest()
		{
			 
			var origin = HttpContext.Current.Request.Headers["Origin"];
			if (origin != null)
			{
				HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", origin);
				HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET,POST");
			}
		}*/
	}
}
