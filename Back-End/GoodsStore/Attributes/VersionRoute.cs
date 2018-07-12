using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace GoodsStore
{
	public class VersionRoute:RoutePrefixAttribute
	{
		public VersionRoute(string route, int major = 1) : base($"api/v{major}/{route}")
		{

		}
	}
}