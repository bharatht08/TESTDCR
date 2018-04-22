using Lshp.BaseWebApi.Data.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Lshp.BaseWebApi.Extensions
{
    /// <summary>
    /// This class is being used to execute the migration scripts  on startup
    /// </summary>
    public class DatabaseMigrationInitialize
    {
        /// <summary>
        /// this method will execute all the migration scripts
        /// </summary>
        /// <param name="app"></param>
        public static void InitializeDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetRequiredService<RepositoryContext>().Database.Migrate();
            }
        }
    }
	 public static void InitializeDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetRequiredService<RepositoryContext>().Database.Migrate();
            }
        }
    }
	 public static void InitializeDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetRequiredService<RepositoryContext>().Database.Migrate();
            }
        }
    }
}