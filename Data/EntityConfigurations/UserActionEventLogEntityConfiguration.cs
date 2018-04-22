using Lshp.BaseWebApi.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lshp.BaseWebApi.Data.EntityConfigurations
{
    /// <summary>
    /// UserActionEventLog table configuration 
    /// </summary>
    public class UserActionEventLogEntityConfiguration : IEntityTypeConfiguration<UserActionEventLog>
    {
        /// <summary>
        /// Table configuration 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<UserActionEventLog> builder)
        {
            builder.ToTable("UserActionEventLog");
            builder.Property("ServerName").HasMaxLength(200);
        }
    }
}