using Lshp.BaseWebApi.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lshp.BaseWebApi.Data.EntityConfigurations
{
    /// <summary>
    /// UsersEntityConfiguration table configuration 
    /// </summary>
    public class UsersEntityConfiguration:IEntityTypeConfiguration<Users>
    {
        /// <summary>
        /// Table configuration 
        /// </summary>
        /// <param name="entity"></param>
        public void Configure(EntityTypeBuilder<Users> entity)
        {
            entity.ToTable("Users");
            entity.HasKey("UserID");
        }
    }
}