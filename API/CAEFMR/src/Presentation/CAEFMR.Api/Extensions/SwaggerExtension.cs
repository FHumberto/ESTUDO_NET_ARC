
using Asp.Versioning;
using Asp.Versioning.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace CAEFMR.Api.Extensions;

public static class SwaggerExtension
{
    public static IApplicationBuilder UseSwaggerWithVersioning(this IApplicationBuilder app)
    {
        IServiceProvider services = app.ApplicationServices;
        var provider = services.GetRequiredService<IApiVersionDescriptionProvider>();

        app.UseSwagger();

        app.UseSwaggerUI(
            options =>
            {
                foreach (var description in provider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint(
                        $"/swagger/{description.GroupName}/swagger.json",
                        description.GroupName.ToUpperInvariant());
                }
            });

        return app;
    }

    public static IServiceCollection AddSwaggerWithVersioning(this IServiceCollection services)
    {
        #region CONFIGURAÇÃO

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

        #region AUTORIZAÇÃO

        services.AddSwaggerGen(
            setup =>
            {
                setup.AddSecurityDefinition(
                    "Bearer",
                    new OpenApiSecurityScheme
                    {
                        Name = "Authorization",
                        In = ParameterLocation.Header,
                        Type = SecuritySchemeType.ApiKey,
                        Scheme = "Bearer",
                        BearerFormat = "JWT",
                        Description =
                            "Input your Bearer token in this format - Bearer {your token here} to access this API",
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

        #region INJEÇÃO

        services.ConfigureOptions<ConfigureSwaggerOptions>();
        
        #endregion

        return services;
    }

    public class ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) : IConfigureNamedOptions<SwaggerGenOptions>
    {
        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in provider.ApiVersionDescriptions)
            {
                OpenApiInfo? info = new()
                {
                    Title = Assembly.GetCallingAssembly().GetName().Name,
                    Version = description.ApiVersion.ToString()
                };

                if (description.IsDeprecated)
                    info.Description += "Esta Versão da API está deprecated.";

                options.SwaggerDoc(description.GroupName, info);
            }
        }

        public void Configure(string? name, SwaggerGenOptions options) => Configure(options);
    }
}
