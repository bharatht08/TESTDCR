using Lshp.BaseWebApi.Data.Context;
using Lshp.BaseWebApi.Data.Entity;
using Lshp.BaseWebApi.Data.Repository.Interface;

namespace Lshp.BaseWebApi.Data.Repository
{
    /// <summary>
    /// MessageTypeRepository is used to do DML operation on MessageType table
    /// </summary>
    public class MessageTypeRepository : BaseRepository<MessageType>, IMessageTypeRepository
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="repositoryContext"></param>
        public MessageTypeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}