using Asp.Versioning;
using Asp.Versioning.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace CAEFMR.Api.Extensions;

public static class SwaggerExtension
{
    /// <summary>
    /// Aplica a interface do Swagger configurada.
    /// </summary>
    /// <param name="app">O construtor da aplicação.</param>
    /// <returns>O construtor da aplicação com o Swagger configurado.</returns>
    public static IApplicationBuilder UseSwaggerWithVersioning(this IApplicationBuilder app)
    {
        IServiceProvider services = app.ApplicationServices;
        IApiVersionDescriptionProvider provider = services.GetRequiredService<IApiVersionDescriptionProvider>();

        app.UseSwagger();

        app.UseSwaggerUI(
            options =>
            {
                foreach (ApiVersionDescription description in provider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint(
                        $"/swagger/{description.GroupName}/swagger.json",
                        description.GroupName.ToUpperInvariant());
                }
            });

        return app;
    }

    /// <summary>
    /// Adiciona as configurações do Swagger com versionamento à coleção de serviços da aplicação.
    /// </summary>
    /// <param name="services">A coleção de serviços da aplicação.</param>
    /// <returns>A coleção de serviços da aplicação com as configurações do Swagger.</returns>
    public static IServiceCollection AddSwaggerWithVersioning(this IServiceCollection services)
    {
        #region ===[ ROTAS ]==========================================================================================

        services.AddApiVersioning(
            setup =>
            {
                setup.DefaultApiVersion = new ApiVersion(1, 0);
                setup.AssumeDefaultVersionWhenUnspecified = true;
                setup.ReportApiVersions = true;
            })
            .AddMvc()
            .AddApiExplorer(
                setup =>
                {
                    setup.GroupNameFormat = "'v'VVV";
                    setup.SubstituteApiVersionInUrl = true;
                });

        #endregion

        #region ===[ AUTORIZAÇÃO ]====================================================================================

        services.AddSwaggerGen(
            setup =>
            {
                setup.AddSecurityDefinition(
                    "Bearer",
                    new OpenApiSecurityScheme
                    {
                        Name = "Authorization",
                        In = ParameterLocation.Header,
                        Type = SecuritySchemeType.Http,
                        Scheme = "Bearer",
                        BearerFormat = "JWT",
                        Description =
                             "Insira **Apenas** o **Token** válido, sem o prefixo **'Bearer'**.",
                    });
                setup.AddSecurityRequirement(
                    new OpenApiSecurityRequirement
                    {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer", },
                            Scheme = "Bearer",
                            Name = "Bearer",
                            In = ParameterLocation.Header,
                        },
                        new List<string>()
                    },
                    });
                setup.EnableAnnotations();
            });

        #endregion

        #region ===[ CONFIGURAÇÃO ]===================================================================================

        services.ConfigureOptions<ConfigureSwaggerOptions>();

        #endregion

        return services;
    }

    public class ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) : IConfigureNamedOptions<SwaggerGenOptions>
    {
        public void Configure(SwaggerGenOptions options)
        {
            foreach (ApiVersionDescription description in provider.ApiVersionDescriptions)
            {
                OpenApiInfo info = new()
                {
                    Title = Assembly.GetCallingAssembly().GetName().Name,
                    Version = description.ApiVersion.ToString()
                };

                if (description.IsDeprecated)
                {
                    info.Description += "Esta Versão da API está deprecated.";
                }

                options.SwaggerDoc(description.GroupName, info);
            }
        }

        public void Configure(string? name, SwaggerGenOptions options) => Configure(options);
    }
}
