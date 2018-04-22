using Lshp.BaseWebApi.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lshp.BaseWebApi.Data.EntityConfigurations
{
    /// <summary>
    /// Status table configuration
    /// </summary>
    public class StatusEntityConfiguration : IEntityTypeConfiguration<Status>
    {
        /// <summary>
        /// configure the table and it's properity
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("Status");
        }
    }
}