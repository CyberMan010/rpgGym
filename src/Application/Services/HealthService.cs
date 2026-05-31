using Application.ServiceRegistration;

namespace Application.Services;

[ServiceRegistration]
public class HealthService
{
    public string GetStatus() => "Healthy";
}
