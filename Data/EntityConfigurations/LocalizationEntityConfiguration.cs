using Lshp.BaseWebApi.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lshp.BaseWebApi.Data.EntityConfigurations
{
    /// <summary>
    /// Configure Localization table
    /// </summary>
    public class LocalizationEntityConfiguration : IEntityTypeConfiguration<Localization>
    {
        /// <summary>
        /// configure the table and it's properity
        /// </summary>
        /// <param name="entity"></param>
        public void Configure(EntityTypeBuilder<Localization> entity)
        {
            entity.ToTable("Localization");
            entity.ToTable("ULocalization");
            entity.ToTable("CLocalization");
        }
    }
}