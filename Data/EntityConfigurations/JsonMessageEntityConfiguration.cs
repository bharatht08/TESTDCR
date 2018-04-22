using Lshp.BaseWebApi.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lshp.BaseWebApi.Data.EntityConfigurations
{
    /// <summary>
    /// Configure JsonMessage table
    /// </summary>
    public class JsonMessageEntityConfiguration : IEntityTypeConfiguration<JsonMessage>
    {
        /// <summary>
        /// configure the table and it's properity
        /// </summary>
        /// <param name="entity"></param>
        public void Configure(EntityTypeBuilder<JsonMessage> entity)
        {
            entity.ToTable("jsonmessage");
            entity.ToTable("Tjsonmessage");
            entity.ToTable("Ljsonmessage");
        }
    }
}