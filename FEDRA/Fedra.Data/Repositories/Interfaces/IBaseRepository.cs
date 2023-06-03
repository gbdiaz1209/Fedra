namespace Fedra.Data.Repositories.Interfaces
{
    /// <summary>
    /// Interfaz generica para el repositorio base, donde TEntity es la clase generica
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseRepository<TEntity> where TEntity : class
    {       
        IQueryable<TEntity> GetAll();

        Task<TEntity?> Get(long id);

        void Add(TEntity entity);

        void Add(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void UpdateRange(IEnumerable<TEntity> entities);

        void Delete(TEntity entity);

        void Delete(IEnumerable<TEntity> entity);
    }
}
