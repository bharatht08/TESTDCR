using Lshp.BaseWebApi.Data.Context;
using Lshp.BaseWebApi.Data.Entity;
using Lshp.BaseWebApi.Data.Repository.Interface;

namespace Lshp.BaseWebApi.Data.Repository
{
    /// <summary>
    /// LocalizationRepository is used to do DML operation on Localization table
    /// </summary>
    public class LocalizationRepository : BaseRepository<Localization>, ILocalizationRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repositoryContext"></param>
        public LocalizationRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}