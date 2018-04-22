using Lshp.BaseWebApi.Data.Entity;
using Lshp.BaseWebApi.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Lshp.BaseWebApi.Data.Context
{
    /// <summary>
    /// RepositoryContext
    /// </summary>
    public class RepositoryContext : DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options"></param>
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }

        #region Users
        /// <summary>
        /// Register/set Users
        /// </summary>
        public DbSet<Users> Users { get; set; }

        #endregion Users

        #region Resource
        /// <summary>
        /// Register/set Resource
        /// </summary>
        public DbSet<Resource> Resource { get; set; }

        #endregion Resource

        #region ShareResource
        /// <summary>
        /// Register/set ShareResource
        /// </summary>
        public DbSet<ShareResource> ShareResource { get; set; }

        #endregion ShareResource

        #region Access
        /// <summary>
        /// Register/set Access
        /// </summary>
        public DbSet<Acccess> Acccess { get; set; }

        #endregion Acccess

        #region Usereventlog
        /// <summary>
        /// Register/set UserActionEventLog
        /// </summary>
        public DbSet<UserActionEventLog> UserActionEventLogs { get; set; }

        #endregion Usereventlog

        #region Localizations
        /// <summary>
        /// Register/Set UserActionEventLog
        /// </summary>
        public DbSet<Localization> Localizations { get; set; }

        #endregion Localizations

        #region Status
        /// <summary>
        /// set Status
        /// </summary>
        public DbSet<Status> Status { get; set; }

        #endregion Status

        #region Email
        /// <summary>
        /// set JsonMessages
        /// </summary>
        public DbSet<JsonMessage> JsonMessages { get; set; }
        /// <summary>
        /// set Messages
        /// </summary>
        public DbSet<Message> Messages { get; set; }
        /// <summary>
        /// set Templates
        /// </summary>
        public DbSet<Template> Templates { get; set; }

        #endregion Email

        /// <summary>
        /// register entity configuration while creating the model to fire the validation
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UsersEntityConfiguration());
            builder.ApplyConfiguration(new ResourceEntityConfiguration());
            builder.ApplyConfiguration(new ShareResourceEntityConfiguration());
            builder.ApplyConfiguration(new AccessEntityConfiguration());
            builder.ApplyConfiguration(new MessagesEntityConfiguration());
            builder.ApplyConfiguration(new TemplateEntityConfiguration());
            builder.ApplyConfiguration(new UserActionEventLogEntityConfiguration());
            builder.ApplyConfiguration(new StatusEntityConfiguration());
            builder.ApplyConfiguration(new LocalizationEntityConfiguration());
            builder.ApplyConfiguration(new JsonMessageEntityConfiguration());
            builder.ApplyConfiguration(new MessageTypeConfiguration());
        }
    }

    /// <summary>
    /// This will be used for generating the migration scripts
    /// </summary>
    public class RepositoryContextDesignFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public RepositoryContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseMySQL(Core.Util.ConfigurationManager.GetInstance().GetConfig().ConnectionStrings.DefaultConnection);

            return new RepositoryContext(optionsBuilder.Options);
        }
    }
}