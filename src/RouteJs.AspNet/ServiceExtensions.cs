﻿using Microsoft.Framework.DependencyInjection;

namespace RouteJs.AspNet
{
	/// <summary>
	/// RouteJs extensions to <see cref="IServiceCollection"/>.
	/// </summary>
    public static class ServiceExtensions
    {
		/// <summary>
		/// Configurees RouteJs for this website.
		/// </summary>
		/// <param name="services">Service collection to register routes in</param>
		/// <returns>The service collection</returns>
	    public static IServiceCollection AddRouteJs(this IServiceCollection services)
	    {
		    services.AddSingleton<IRouteFetcher, TemplateRouteFetcher>();
		    services.AddSingleton<IRouteFetcher, AttributeRouteFetcher>();
		    return services;
	    }
    }
}