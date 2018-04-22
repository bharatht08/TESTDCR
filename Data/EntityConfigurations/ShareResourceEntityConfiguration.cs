using Lshp.BaseWebApi.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lshp.BaseWebApi.Data.EntityConfigurations
{
    /// <summary>
    /// Configure ShareResource table
    /// </summary>
    public class ShareResourceEntityConfiguration:IEntityTypeConfiguration<ShareResource>
    {
        /// <summary>
        /// configure the table and it's properity
        /// </summary>
        /// <param name="entity"></param>
        public void Configure(EntityTypeBuilder<ShareResource> entity)
        {
            entity.ToTable("ShareResource");
            entity.HasKey(s => s.ShareID);
            entity.HasOne<Users>(s=>s.users).WithMany(s=>s.ShareResource).HasForeignKey(s=>s.ShareUserID);
        }
    }
}