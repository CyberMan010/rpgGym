namespace Application.ServiceRegistration;

/// <summary>
/// Marks a class for automatic service registration in the dependency injection container.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class ServiceRegistrationAttribute : Attribute
{
    /// <summary>
    /// Gets the lifetime of the service registration.
    /// </summary>
    public ServiceLifetime Lifetime { get; }

    /// <summary>
    /// Initializes a new instance of the ServiceRegistrationAttribute class.
    /// </summary>
    /// <param name="lifetime">The lifetime of the service. Defaults to Singleton.</param>
    public ServiceRegistrationAttribute(ServiceLifetime lifetime = ServiceLifetime.Singleton)
    {
        Lifetime = lifetime;
    }
}

/// <summary>
/// Defines the lifetime of a service registration.
/// </summary>
public enum ServiceLifetime
{
    Singleton,
    Scoped,
    Transient
}
