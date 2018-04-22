using Lshp.BaseWebApi.Data.Context;
using Lshp.BaseWebApi.Data.Entity;
using Lshp.BaseWebApi.Data.Repository.Interface;

namespace Lshp.BaseWebApi.Data.Repository
{
    /// <summary>
    /// Template repository is used to do DML operation on Template table
    /// </summary>
    public class TemplateRepository : BaseRepository<Template>, ITemplateRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repositoryContext"></param>
        public TemplateRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}