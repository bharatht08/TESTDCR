using Lshp.BaseWebApi.Data.Context;
using Lshp.BaseWebApi.Data.Entity;
using Lshp.BaseWebApi.Data.Repository.Interface;

namespace Lshp.BaseWebApi.Data.Repository
{
    /// <summary>
    /// MessageRepository is used to do DML operation on Message table
    /// </summary>
    public class MessageRepository : BaseRepository<Message>, IMessageRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repositoryContext"></param>
        public MessageRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}