using Application.ServiceRegistration;

namespace Infrastructure.Persistence;

[ServiceRegistration]
public class InMemoryDatabase
{
    private readonly List<string> _data = new();

    public void Add(string item) => _data.Add(item);
    public IEnumerable<string> GetAll() => _data.AsReadOnly();
}
