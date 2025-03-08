using Microsoft.OpenApi.Models;
using System.Reflection;

namespace LivrosAPP.Service.Extensions
{
    public static class SwaggerExtensions
    {

        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "UsuarioApp - API para cadastro de livross.",
                    Description = "API desenvolvida em .Net 7 com EF Core, XUNIT, JWT e RabbitMQ",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Renato Alves Vasconcelos",
                        Email = "trunfo4608@gmail.com",
                        Url = new Uri("http://www.rav@solucoesltda.com.br")
                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                options.IncludeXmlComments(xmlPath);
            });

            return services;
        }


        public static IApplicationBuilder UseSwaggerDoc(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "LivrosApp");
            });

            return app;
        }

    }
}
