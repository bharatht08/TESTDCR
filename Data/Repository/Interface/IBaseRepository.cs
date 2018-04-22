namespace Lshp.BaseWebApi.Data.Repository.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface IBaseRepository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseRepository<T> : IDisposable where T : class
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        T Add(T t);

        /// <summary>
        ///
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        Task<T> AddAsync(T t);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        int Count();

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        Task<int> CountAsync();

        /// <summary>
        ///
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        ///
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task DeleteAsync(T entity);

        /// <summary>
        ///
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        T Get(Expression<Func<T, bool>> match);

        /// <summary>
        ///
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IQueryable<T> GetBy(Expression<Func<T, bool>> predicate);

        /// <summary>
        ///
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<ICollection<T>> GetByAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(int id);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        Task<ICollection<T>> GetAllAsync();

        /// <summary>
        ///
        /// </summary>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetAsync(int id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetAsync(long id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        Task<T> GetAsync(Expression<Func<T, bool>> match);

        /// <summary>
        ///
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>> match);

        /// <summary>
        ///
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        ICollection<T> GetAll(Expression<Func<T, bool>> match);

        /// <summary>
        ///
        /// </summary>
        /// <param name="t"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        T Update(T t, object key);

        /// <summary>
        ///
        /// </summary>
        /// <param name="t"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<T> UpdateAsync(T t, object key);
    }
}