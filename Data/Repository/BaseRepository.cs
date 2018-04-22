namespace Lshp.BaseWebApi.Data.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using System.Transactions;
    using Lshp.BaseWebApi.Data.Context;
    using Lshp.BaseWebApi.Data.Repository.Interface;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Baserepository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        #region Fields

        private readonly DbSet<T> dbset;

        private RepositoryContext repositoryContext;

        #endregion Fields

        #region Constructors and Destructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repositoryContext"></param>
        protected BaseRepository(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
            this.dbset = this.repositoryContext.Set<T>();
        }

        #endregion Constructors and Destructors

        //   using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))

        #region Public Methods and Operators

        /// <summary>
        /// Get all records from database
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll()
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return dbset;
            }
        }

        /// <summary>
        /// Get all records from databse with async call
        /// </summary>
        /// <returns></returns>
        public virtual async Task<ICollection<T>> GetAllAsync()
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return await dbset.ToListAsync();
            }
        }

        /// <summary>
        /// get single record from the database with primaryid
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T Get(int id)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return dbset.Find(id);
            }
        }

        /// <summary>
        /// get single record from the database with primaryid with async call
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<T> GetAsync(int id)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return await dbset.FindAsync(id);
            }
        }

        /// <summary>
        /// get single record from the database with primaryid long with async call
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<T> GetAsync(long id)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return await dbset.FindAsync(id);
            }
        }

        /// <summary>
        /// Insert new record into database
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public virtual T Add(T t)
        {
            dbset.Add(t);
            repositoryContext.SaveChanges();
            return t;
        }

        /// <summary>
        /// Find single record with the linq query
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        public virtual T Get(Expression<Func<T, bool>> match)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return dbset.SingleOrDefault(match);
            }
        }

        /// <summary>
        /// Find single record with the linq query using async calls
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        public virtual async Task<T> GetAsync(Expression<Func<T, bool>> match)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return await dbset.SingleOrDefaultAsync(match);
            }
        }

        /// <summary>
        /// find all records with the linq query
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        public ICollection<T> GetAll(Expression<Func<T, bool>> match)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return dbset.Where(match).ToList();
            }
        }

        /// <summary>
        /// find all records with the linq query  with the async call
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        public async Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>> match)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return await dbset.Where(match).ToListAsync();
            }
        }

        /// <summary>
        /// Delete the record from the database
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
            repositoryContext.SaveChanges();
        }

        /// <summary>
        /// update existing record with the primarykey
        /// </summary>
        /// <param name="t"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual T Update(T t, object key)
        {
            if (t == null)
                return null;
            T exist = dbset.Find(key);
            if (exist != null)
            {
                repositoryContext.Entry(exist).CurrentValues.SetValues(t);
                repositoryContext.SaveChanges();
            }
            return exist;
        }

        /// <summary>
        /// update existing record with the primarykey using async call
        /// </summary>
        /// <param name="t"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual async Task<T> UpdateAsync(T t, object key)
        {
            if (t == null)
                return null;
            T exist = await dbset.FindAsync(key);
            if (exist != null)
            {
                repositoryContext.Entry(exist).CurrentValues.SetValues(t);
                await repositoryContext.SaveChangesAsync();
            }
            return exist;
        }

        /// <summary>
        /// retrive the total number of records from the table
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return dbset.Count();
            }
        }

        /// <summary>
        /// retrive the total number of records from the table using async call
        /// </summary>
        /// <returns></returns>
        public async Task<int> CountAsync()
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return await dbset.CountAsync();
            }
        }

        /// <summary>
        /// find all records with the linq query with Queryable
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual IQueryable<T> GetBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = dbset.Where(predicate);
            return query;
        }

        /// <summary>
        /// Finall records with the ListAsync method
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual async Task<ICollection<T>> GetByAsync(Expression<Func<T, bool>> predicate)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return await dbset.Where(predicate).ToListAsync();
            }
        }

        /// <summary>
        /// Retrive only the selected properties in the list
        /// </summary>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> queryable = GetAll();
            foreach (Expression<Func<T, object>> includeProperty in includeProperties)
            {
                queryable = queryable.Include<T, object>(includeProperty);
            }

            return queryable;
        }

        /// <summary>
        /// add/insert the record to database with async
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public async Task<T> AddAsync(T t)
        {
            await dbset.AddAsync(t);
            await repositoryContext.SaveChangesAsync();
            return t;
        }

        /// <summary>
        /// Delete the records with Async
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task DeleteAsync(T entity)
        {
            dbset.Remove(entity);
            await repositoryContext.SaveChangesAsync();
        }

        /// <summary>
        /// Clear the object
        /// </summary>
        public void Dispose()
        {
            repositoryContext.Dispose();
            GC.SuppressFinalize(this);
        }

        #endregion Public Methods and Operators
    }
}