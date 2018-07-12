using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System.Web.Http;
using GoodsStore.Data;
using System.Web.Mvc;
using GoodsStore.Services;

namespace GoodsStore
{
	public static class AutofacConfig
	{
		public static void Configure(HttpConfiguration config)
		{
			var builder = new ContainerBuilder();
			builder.RegisterApiControllers(typeof(WebApiApplication).Assembly);

			builder.RegisterType<GoodsStoreContext>().InstancePerLifetimeScope().AsSelf();

			builder.RegisterType<ProductService>().AsSelf();
			builder.RegisterType<UserService>().AsSelf();
			builder.RegisterType<OrderService>().AsSelf();

			var container = builder.Build();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
			config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
		}

	}
}