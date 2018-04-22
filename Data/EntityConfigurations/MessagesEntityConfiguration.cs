using Lshp.BaseWebApi.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lshp.BaseWebApi.Data.EntityConfigurations
{
    /// <summary>
    /// Configure Message table
    /// </summary>
    public class MessagesEntityConfiguration : IEntityTypeConfiguration<Message>
    {
        /// <summary>
        /// configure the table and it's properity
        /// </summary>
        /// <param name="entity"></param>
        public void Configure(EntityTypeBuilder<Message> entity)
        {
            entity.ToTable("messages");
        }
    }
}