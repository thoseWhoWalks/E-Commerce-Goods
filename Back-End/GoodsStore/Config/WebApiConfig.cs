using System.Web.Http;
using System.Web.Http.Cors;

namespace GoodsStore
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			  
			config.MapHttpAttributeRoutes(new CustomDirectRouteProvider());
			 
			 
			config.EnableCors(new EnableCorsAttribute("*", "*", "*") { SupportsCredentials = true });

			config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));
		}
	}
}
