using System;
using Data.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;
using System.Reflection;
using System.IO;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Service.Interface;
using Service.Repository;

namespace MyTeam.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<DataContext>(
                context => context.UseSqlServer(Configuration.GetConnectionString("StringConexao")));

            services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
           

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IRepository, Repository>();
            services.AddScoped<ICrud, CrudRepository>();
            services.AddScoped<IGame, GameRepository>();
            services.AddScoped<ITeam, TeamRepository>();
            services.AddScoped<IPlayer, PlayerRepository>();
            services.AddScoped<IUser, UserRepository>();
            services.AddScoped<IPlayerApp, PlayerAppRepository>();





            // Configuracao de Versionamento da API
            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;

            })
            .AddApiVersioning(opcao =>
            {
                opcao.AssumeDefaultVersionWhenUnspecified = true;
                opcao.DefaultApiVersion = new ApiVersion(1, 0);
                opcao.ReportApiVersions = true;
            }
            );

            var apiProviderDescription = services.BuildServiceProvider()
                                                  .GetService<IApiVersionDescriptionProvider>();
            

            // COnfiguaração das propriedades do Swagger
            services.AddSwaggerGen(options => {



                foreach (var descricao in apiProviderDescription.ApiVersionDescriptions)
                {
                    options.SwaggerDoc(descricao.GroupName, new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Title = "MyTeam API",
                        Version = descricao.ApiVersion.ToString(),
                        TermsOfService = new Uri("https://www.instagram.com/maykoncole/"),
                        Description = "WEB API crida para utilização do aplicativo mobile My Team",

                        License = new Microsoft.OpenApi.Models.OpenApiLicense
                        {
                            Name = "MyTeam - Licença",
                            Url = new Uri("https://github.com/MaykonCole")
                        },
                        Contact = new Microsoft.OpenApi.Models.OpenApiContact
                        {
                            Name = "Maykon Emanuel Cardoso Rocha",
                            Email = "maykontaio@hotmail.com",
                            Url = new Uri("https://twitter.com/Maykon_Cole")
                        }

                    }

                );
                }

                var xmlComentario = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlCaminho = Path.Combine(AppContext.BaseDirectory, xmlComentario);

                options.IncludeXmlComments(xmlCaminho);

            });


            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider apiVersionProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseSwagger().UseSwaggerUI(options =>
            {
                foreach (var descricao in apiVersionProvider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint($"/swagger/{descricao.GroupName}/swagger.json",
                         descricao.GroupName.ToUpperInvariant());
                }
                
                options.RoutePrefix = "";
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
