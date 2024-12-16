﻿using System.Reflection;

using Microsoft.Extensions.DependencyInjection;

namespace CA_CQRS_MR.Application;

public static class LayerRegistration
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        return services;
    }
}