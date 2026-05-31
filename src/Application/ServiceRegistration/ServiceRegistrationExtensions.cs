using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application.ServiceRegistration;

/// <summary>
/// Extension methods for automatic service registration.
/// </summary>
public static class ServiceRegistrationExtensions
{
    /// <summary>
    /// Automatically registers services from the specified assembly that are marked with ServiceRegistrationAttribute.
    /// </summary>
    /// <param name="services">The service collection to register services in.</param>
    /// <param name="assembly">The assembly to scan for services marked with ServiceRegistrationAttribute.</param>
    /// <returns>The service collection for chaining.</returns>
    public static IServiceCollection AddAutoRegisteredServices(this IServiceCollection services, Assembly assembly)
    {
        var typesWithAttribute = assembly.GetTypes()
            .Where(t => t.GetCustomAttribute<ServiceRegistrationAttribute>() != null);

        foreach (var type in typesWithAttribute)
        {
            var attribute = type.GetCustomAttribute<ServiceRegistrationAttribute>();
            if (attribute == null) continue;

            var lifetime = attribute.Lifetime switch
            {
                global::Application.ServiceRegistration.ServiceLifetime.Singleton => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton,
                global::Application.ServiceRegistration.ServiceLifetime.Scoped => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped,
                global::Application.ServiceRegistration.ServiceLifetime.Transient => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient,
                _ => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton
            };

            services.Add(new ServiceDescriptor(type, type, lifetime));
        }

        return services;
    }

    /// <summary>
    /// Automatically registers services from multiple assemblies that are marked with ServiceRegistrationAttribute.
    /// </summary>
    /// <param name="services">The service collection to register services in.</param>
    /// <param name="assemblies">The assemblies to scan for services marked with ServiceRegistrationAttribute.</param>
    /// <returns>The service collection for chaining.</returns>
    public static IServiceCollection AddAutoRegisteredServices(this IServiceCollection services, params Assembly[] assemblies)
    {
        foreach (var assembly in assemblies)
        {
            services.AddAutoRegisteredServices(assembly);
        }

        return services;
    }
}
