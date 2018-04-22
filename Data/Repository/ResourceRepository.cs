using System.Collections.Generic;
using System.Linq;
using Lshp.BaseWebApi.Data.Context;
using Lshp.BaseWebApi.Data.Entity;
using Lshp.BaseWebApi.Data.Repository.Interface;
namespace Lshp.BaseWebApi.Data.Repository
{
    /// <summary>
    /// ResourceRepository is used to do DML operation on Resource table
    /// </summary>
    public class ResourceRepository:BaseRepository<Resource>, IResourceRepository
    {
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repositoryContext"></param>
        public ResourceRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
       
        }
        
    }
}