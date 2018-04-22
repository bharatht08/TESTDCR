using System;
using Lshp.BaseWebApi.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace Lshp.BaseWebApi.Data.Repository.Interface
{
    /// <summary>
    /// Interface for Users repository Inherited from IBaseRepository
    /// </summary>
    public interface IUserRepository:IBaseRepository<Users>
    {
        
    }
}