using Lshp.BaseWebApi.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Lshp.BaseWebApi.Data.EntityConfigurations
{
    /// <summary>
    /// Configure Resource table
    /// </summary>
    public class ResourceEntityConfiguration:IEntityTypeConfiguration<Resource>
    {
        /// <summary>
        /// configure the table and it's properity
        /// </summary>
        /// <param name="entity"></param>
        public void Configure(EntityTypeBuilder<Resource> entity)
        {
            
            entity.ToTable("Resource");
            entity.HasKey(r => r.ResourceID);
        }
    }
}