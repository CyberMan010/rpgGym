namespace Application.IService.Shared
{
    public interface IJwtService
    {
        string GenerateToken(Guid userId, string email);
    }
}
