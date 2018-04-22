using Lshp.BaseWebApi.Data.Context;
using Lshp.BaseWebApi.Data.Entity;
using Lshp.BaseWebApi.Data.Repository.Interface;

namespace Lshp.BaseWebApi.Data.Repository
{

    /// <summary>
    /// JsonMessageRepository is used to do DML operation on JsonMessage table
    /// </summary>
    public class JsonMessageRepository : BaseRepository<JsonMessage>, IJsonMessageRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repositoryContext"></param>
        public JsonMessageRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}