namespace API.Extensions;

public static class ApplicationBuilderExtensions
{
    public static WebApplication UseApplicationMiddlewares(
        this WebApplication app)
    {

        app.UseHttpsRedirection();


        app.UseAuthentication();

        app.UseAuthorization();


        app.MapControllers();


        return app;
    }
}