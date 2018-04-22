using Lshp.BaseWebApi.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lshp.BaseWebApi.Data.EntityConfigurations
{
    /// <summary>
    /// 
    /// </summary>
    public class TemplateEntityConfiguration : IEntityTypeConfiguration<Template>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Template> builder)
        {
            builder.ToTable("template");
        }
    }
}