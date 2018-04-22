using Lshp.BaseWebApi.Data.Context;
using Lshp.BaseWebApi.Data.Repository;
using Lshp.BaseWebApi.Data.Repository.Interface;
using Lshp.BaseWebApi.Service.Logger;
using Lshp.Core.Util.ConfigManager;
using Lshp.BaseWebApi.Service.Localizations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Lshp.BaseWebApi.Data.Entity;
using Lshp.BaseWebApi.Service.Resources;
using Lshp.BaseWebApi.Service.ShareResources;
using Lshp.BaseWebApi.Service.User;
// using Lshp.BaseWebApi.Service.User;

namespace Lshp.BaseWebApi.Extensions
{
    /// <summary>
    /// Servicecollection extensions for registering services on startup
    /// </summary>
    public static class ServiceCollectionExtensions
    {

        /// <summary>
        ///  Configure service with MariaDB or MYSQL database
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configEntry"></param>
        /// <returns></returns>
        public static IServiceCollection CustomMySql(this IServiceCollection services, ConfigEntry configEntry)
        {
            services.AddDbContext<RepositoryContext>(o => o.UseMySQL(configEntry.ConnectionStrings.DefaultConnection));
            //builder.AddConfigurationStore(options =>
            //{
            //    options.ConfigureDbContext = config => config.UseMySQL(configEntry.ConnectionStrings.DefaultConnection);
            //});
            // this adds the operational data from DB (codes, tokens, consents)
            
            return services;
        }

        /// <summary>
        /// Configure service with sqlserver database
        /// </summary>
        /// <param name="service"></param>
        /// <param name="configEntry"></param>
        /// <returns></returns>
        public static IServiceCollection CustomSqlServer(this IServiceCollection service, ConfigEntry configEntry)
        {
            service.AddDbContext<RepositoryContext>(o => o.UseSqlServer(configEntry.ConnectionStrings.DefaultConnection));
            //builder.AddConfigurationStore(options =>
            //{
            //    options.ConfigureDbContext = config => config.UseSqlServer(configEntry.ConnectionStrings.DefaultConnection);
            //});
            // this adds the operational data from DB (codes, tokens, consents)
           
            return service;
        }

        /// <summary>
        /// Configure service with SQLLIte database
        /// </summary>
        /// <param name="service"></param>
        /// <param name="configEntry"></param>
        /// <returns></returns>
        public static IServiceCollection CustomSqllite(this IServiceCollection service, ConfigEntry configEntry)
        {
           service.AddDbContext<RepositoryContext>(o => o.UseSqlite(configEntry.ConnectionStrings.DefaultConnection));
            ////builder.AddConfigurationStore(options =>
            ////{
            ////    options.ConfigureDbContext = config => config.UseSqlite(configEntry.ConnectionStrings.DefaultConnection);
            ////});
            // this adds the operational data from DB (codes, tokens, consents)
            
             
            return service;
        }

        /// <summary>
        /// register all repository
        /// </summary>
        /// <param name="serviceCollection"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterAllRepository(this IServiceCollection serviceCollection)
        { 
            serviceCollection.AddSingleton<IUserRepository,UserRepository>();
            serviceCollection.AddSingleton<IResourceRepository,ResourceRepository>();
            serviceCollection.AddSingleton<IShareResourceRepository,ShareResourceRepository>();
            serviceCollection.AddSingleton<IAccessRepository,AccessRepository>();
            serviceCollection.AddSingleton<IJsonMessageRepository, JsonMessageRepository>();
            serviceCollection.AddSingleton<IMessageRepository, MessageRepository>(); 
            serviceCollection.AddSingleton<IStatusRepository, StatusRepository>();
            serviceCollection.AddSingleton<ITemplateRepository, TemplateRepository>();
            serviceCollection.AddSingleton<IUserActionEventLogRepository, UserActionEventLogRepository>(); 
            serviceCollection.AddSingleton<ILocalizationRepository, LocalizationRepository>(); 
            serviceCollection.AddSingleton<IMessageTypeRepository, MessageTypeRepository>();

        
            return serviceCollection;
        }

        /// <summary>
        /// Register Singletonservices
        /// </summary>
        /// <param name="serviceCollection"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterSingletonServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IStringLocalizerFactory, LocalizationService>();

            serviceCollection.AddSingleton<ILogger, SQLLogger>(); 
            serviceCollection.AddSingleton<IResource, ResourceService>();
            serviceCollection.AddSingleton<IUser, UserService>();
             serviceCollection.AddSingleton<IShareResource, ShareResources>();
            ////serviceCollection.AddSingleton<IEmailSender, EmailSender>();

            return serviceCollection;
        } 
    }
}