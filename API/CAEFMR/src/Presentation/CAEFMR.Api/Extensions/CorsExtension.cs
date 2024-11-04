namespace CAEFMR.Api.Extensions;

public static class CorsExtension
{
    /// <summary>
    /// Adiciona as políticas de CORS configuradas à coleção de serviços da aplicação.
    /// </summary>
    /// <param name="services">A coleção de serviços da aplicação.</param>
    /// <returns>A coleção de serviços da aplicação com a política CORS adicionada.</returns>
    public static IServiceCollection AddCorsPolicies(this IServiceCollection services)
        => services.AddCors(x
            => x.AddPolicy("Any",
                b =>
                {
                    b.AllowAnyOrigin();
                    b.AllowAnyHeader();
                    b.AllowAnyMethod();
                }
            )
        );

    /// <summary>
    /// Aplica as políticas de CORS configuradas à aplicação.
    /// </summary>
    /// <param name="app">O construtor da aplicação.</param>
    /// <returns>O construtor da aplicação com a política CORS aplicada.</returns>
    public static IApplicationBuilder UseCorsPolicies(this IApplicationBuilder app)
        => app.UseCors("Any");
}
