using Lshp.BaseWebApi.Data.Context;
using Lshp.BaseWebApi.Data.Entity;
using Lshp.BaseWebApi.Data.Repository.Interface;
namespace Lshp.BaseWebApi.Data.Repository
{
    /// <summary>
    /// ShareResourceRepository is used to do DML operation on ShareResource table
    /// </summary>

    public class ShareResourceRepository:BaseRepository<ShareResource>, IShareResourceRepository
    {
         /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repositoryContext"></param>
        public ShareResourceRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}