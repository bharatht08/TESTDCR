using Lshp.BaseWebApi.Data.Context;
using Lshp.BaseWebApi.Data.Entity;
using Lshp.BaseWebApi.Data.Repository.Interface;
using System.Collections.Generic;
using System.Linq;
using Lshp.BaseWebApi.Mappings;
using Lshp.BaseWebApi.ViewModel;

namespace Lshp.BaseWebApi.Data.Repository
{
    /// <summary>
    /// UserRepository is used to do DML operation on Users table
    /// </summary>
    public class UserRepository:BaseRepository<Users>, IUserRepository
    {
        private RepositoryContext _repositoryContext;
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repositoryContext"></param>
        
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
          _repositoryContext = repositoryContext;
        }
        
    }
}