using Lshp.BaseWebApi.Data.Context;
using Lshp.BaseWebApi.Data.Entity;
using Lshp.BaseWebApi.Data.Repository.Interface;

namespace Lshp.BaseWebApi.Data.Repository
{
    /// <summary>
    /// StatusRepository is used to do DML operation on Status table
    /// </summary>
    public class StatusRepository : BaseRepository<Status>, IStatusRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repositoryContext"></param>
        public StatusRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}