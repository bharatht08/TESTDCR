using Lshp.BaseWebApi.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Lshp.BaseWebApi.Data.EntityConfigurations
{
    /// <summary>
    /// Configure Access table
    /// </summary>
    public class AccessEntityConfiguration:IEntityTypeConfiguration<Acccess>
    {
        /// <summary>
        /// configure the table and it's properity
        /// </summary>
        /// <param name="entity"></param>
        public void Configure(EntityTypeBuilder<Acccess> entity)
        {
            entity.ToTable("Access");
            entity.ToTable("PAccess");
            entity.ToTable("QAccess");
            entity.ToTable("CAccess");
            //Primary key 
            entity.HasKey("LAccessID");
        }
    }
}