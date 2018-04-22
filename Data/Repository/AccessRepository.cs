using Lshp.BaseWebApi.Data.Context;
using Lshp.BaseWebApi.Data.Entity;
using Lshp.BaseWebApi.Data.Repository.Interface;

namespace Lshp.BaseWebApi.Data.Repository
{
    /// <summary>
    /// AccessRepository is used to do DML operation on Acccess table
    /// </summary>
    public class AccessRepository : BaseRepository<Acccess>, IAccessRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repositoryContext"></param>
        public AccessRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}