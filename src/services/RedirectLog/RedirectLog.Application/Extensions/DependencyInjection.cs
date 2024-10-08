﻿using System.Reflection;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace RedirectLog.Application.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(x => { x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()); });

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ExceptionBehaviour<,>));

        return services;
    }
}