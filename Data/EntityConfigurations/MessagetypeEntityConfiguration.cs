using Lshp.BaseWebApi.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lshp.BaseWebApi.Data.EntityConfigurations
{
    /// <summary>
    /// Configure Message table 
    /// </summary>
    public class MessageTypeConfiguration : IEntityTypeConfiguration<MessageType>
    {
        /// <summary>
        /// configure the table and it's properity
        /// </summary>
        /// <param name="entity"></param>
        public void Configure(EntityTypeBuilder<MessageType> entity)
        {
            entity.ToTable("messagetype"); 

            entity.Property(e => e.Id)
            .HasColumnName("Id");

            entity.Property(e => e.Code)
            .HasColumnName("Code"); 

            entity.Property(e => e.Type)
            .HasColumnName("Type");
        }
    }
}