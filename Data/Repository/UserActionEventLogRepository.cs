using Lshp.BaseWebApi.Data.Context;
using Lshp.BaseWebApi.Data.Entity;
using Lshp.BaseWebApi.Data.Repository.Interface;

namespace Lshp.BaseWebApi.Data.Repository
{
    /// <summary>
    /// This repository will be used to log all the user events
    /// </summary>
    public class UserActionEventLogRepository : BaseRepository<UserActionEventLog>, IUserActionEventLogRepository
    {
        /// <summary>
        /// UserActionEventLogRepository Repository
        /// </summary>
        /// <param name="repositoryContext"></param>
        public UserActionEventLogRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}