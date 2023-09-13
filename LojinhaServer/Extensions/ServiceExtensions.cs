using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojinhaServer.Models;
using LojinhaServer.Repositories;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LojinhaServer.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection service){
            service.AddCors(Opt =>{
                Opt.AddPolicy("CorsPolicy",builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()); 
            });
        }
        public static void ConfigureMongoDBSettings(this IServiceCollection services,
        IConfiguration config)
        {
            services.Configure<MongoDbSettings>(
                config.GetSection("MongoDBSettings")
            );
            services.AddSingleton<IMongoDatabase>(opt =>{
                var settings = config.GetSection("MongoDBSettings").Get<MongoDbSettings>();
                var client = new MongoClient(settings.conectionString);
                return client.GetDatabase(settings.DatabaseName);
            });
        }

        public static void ConfigureProductRepository(this IServiceCollection services)
        {
            services.AddSingleton<IProductRepository, ProductRepository>();
        }
    }
}