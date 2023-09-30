using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using RealEstate.DataAccessLayer.DbContexts;
using RealEstate.DataAccessLayer.Entities;
using RealEstate.DataAccessLayer.Repositories.Abstracts;

namespace RealEstate.DataAccessLayer.Repositories;

public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity>
    where TEntity : BaseEntity
{
    internal RealEstateContext context;
    internal DbSet<TEntity> dbSet;

    public GenericRepository(RealEstateContext context)
    {
        this.context = context;
        this.dbSet = context.Set<TEntity>();
    }

    public virtual IEnumerable<TEntity> Get(
        Expression<Func<TEntity, bool>> filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeProperties = "")
    {
        IQueryable<TEntity> query = dbSet;

        query = query.Where(x => !x.IsDeleted);

        if (filter != null)
            query = query.Where(filter);

        foreach (var includeProperty in includeProperties.Split
            (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            query = query.Include(includeProperty);

        if (orderBy != null)
            return orderBy(query).ToList();
        else
            return query.ToList();
    }

    public virtual IEnumerable<TEntity> Get(
    List<Expression<Func<TEntity, bool>>> filters,
    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
    string includeProperties = "")
    {
        IQueryable<TEntity> query = dbSet;

        query = query.Where(x => !x.IsDeleted);

        foreach (var filter in filters)
            query = query.Where(filter);

        foreach (var includeProperty in includeProperties.Split
            (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            query = query.Include(includeProperty);

        if (orderBy != null)
            return orderBy(query).ToList();
        else
            return query.ToList();
    }

    public virtual TEntity? GetByID(int id)
    {
        return dbSet.Find(id);
    }

    public virtual void Insert(TEntity entity)
    {
        entity.CreateTime = DateTime.Now;
        entity.IsDeleted = false;
        dbSet.Add(entity);
    }

    public virtual void Delete(int id)
    {
        TEntity? entityToDelete = dbSet.Find(id);
        if (entityToDelete != null)
        {
            entityToDelete.IsDeleted = true;
            entityToDelete.DeleteTime = DateTime.Now;
            Update(entityToDelete);
        }
    }

    public virtual void Delete(TEntity entityToDelete)
    {
        if (context.Entry(entityToDelete).State == EntityState.Detached)
        {
            dbSet.Attach(entityToDelete);
        }
        if (entityToDelete != null)
        {
            entityToDelete.IsDeleted = true;
            entityToDelete.DeleteTime = DateTime.Now;
            Update(entityToDelete);
        }
    }

    public virtual void Update(TEntity entityToUpdate)
    {
        dbSet.Attach(entityToUpdate);
        context.Entry(entityToUpdate).State = EntityState.Modified;
    }
}
