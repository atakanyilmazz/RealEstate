using RealEstate.DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace RealEstate.DataAccessLayer.Repositories.Abstracts;

public interface IGenericRepository<TEntity> where TEntity : BaseEntity
{
    IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");

    IEnumerable<TEntity> Get(
           List<Expression<Func<TEntity, bool>>> filter,
           Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
           string includeProperties = "");
    TEntity? GetByID(int id);
    void Insert(TEntity entity);
    void Delete(int id);
    void Delete(TEntity entityToDelete);
    void Update(TEntity entityToUpdate);
}