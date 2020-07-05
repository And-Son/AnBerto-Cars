using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnBertoCars.Servico;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using AnBertoCars.Dominio.Interfaces;
using AnBertoCars.Dominio.Interfaces.Servico;
using AnBertoCars.Dominio.Interfaces.Repositorio;
using AnBertoCars.Data;
using Microsoft.AspNetCore.Authentication;
using WebApi.Helpers;

namespace AnBertoCars.WebAPI
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //configuracao autenticacao
            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            // AvaliarVendedor
            services.AddTransient<IAvaliarVendedorServico, AvaliarVendedorServico>();
            services.AddTransient<IAvaliarVendedorRepositorio, AvaliarVendedorRepositorio>();
            // DirectVendedor
            services.AddTransient<IDirectVendedorServico, DirectVendedorServico>();
            services.AddTransient<IDirectVendedorRepositorio, DirectVendedorRepositorio>();
            // Cliente
            services.AddTransient<IClienteServico, ClienteServico>();
            services.AddTransient<IClienteRepositorio, ClienteRepositorio>();
            // Endereco
            services.AddTransient<IEnderecoServico, EnderecoServico>();
            services.AddTransient<IEnderecoRepositorio, EnderecoRepositorio>();
            // EspecificacoesVeiculo
            services.AddTransient<IEspecificacoesVeiculoServico, EspecificacoesVeiculoServico>();
            services.AddTransient<IEspecificacoesVeiculoRepositorio, EspecificacoesVeiculoRepositorio>();
            // Favoritos
            services.AddTransient<IFavoritosServico, FavoritosServico>();
            services.AddTransient<IFavoritosRepositorio, FavoritosRepositorio>();
            // FotoPerfil
            services.AddTransient<IFotoPerfilServico, FotoPerfilServico>();
            services.AddTransient<IFotoPerfilRepositorio, FotoPerfilRepositorio>();
            // Grupos
            services.AddTransient<IGruposServico, GruposServico>();
            services.AddTransient<IGruposRepositorio, GruposRepositorio>();
            // PublicarAnuncio
            services.AddTransient<IPublicarAnuncioServico, PublicarAnuncioServico>();
            services.AddTransient<IPublicarAnuncioRepositorio, PublicarAnuncioRepositorio>();
            // Telefone
            services.AddTransient<ITelefoneServico, TelefoneServico>();
            services.AddTransient<ITelefoneRepositorio, TelefoneRepositorio>();


            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:8101/",
                                                          "http://localhost:8101",
                                                          "https://localhost:8101/",
                                                          "https://localhost:8101",
                                                          "http://localhost:8100/",
                                                          "http://localhost:8100",
                                                          "https://localhost:8100/",
                                                          "https://localhost:8100")
                                      .AllowAnyHeader()
                                      .AllowAnyMethod();
                                  });
            });
            services.AddControllers();
            services.AddSwaggerGen(c => {

                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "AndBerto",
                        Version = "v1",
                        Description = "Aplicação venda de carros",
                        Contact = new OpenApiContact
                        {
                            Name = "Humberto Júnior",
                            Url = new Uri("https://github.com/tiroberto")
                        }
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Ativando middlewares para uso do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "AndBerto");
            });

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
