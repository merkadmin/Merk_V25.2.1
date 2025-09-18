using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EntitiesBL.EntitiesCommonBL.EntitiesLogicLayer.Repositories
{
	public class Repository<TEntity> : IRepository<TEntity>
		where TEntity : class, new()
	{
		private readonly ERPSystemEntities _dbContext;

		public Repository(ERPSystemEntities dbContext)
		{
			_dbContext = dbContext;
		}

		public TEntity CreateDBEntity()
		{
			return new TEntity();
		}

		public TEntity GetEntity(long id)
		{
			try
			{
				return _dbContext.Set<TEntity>().Find(id);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}

			return null;
		}

		public TEntity GetEntity(Expression<Func<TEntity, bool>> predicate)
		{
			return (TEntity)_dbContext.Set<TEntity>().Where(predicate);
		}

		public IEnumerable<TEntity> GetAllEntities()
		{
			return _dbContext.Set<TEntity>().ToList();
		}

		public IEnumerable<TEntity> GetEntities(Expression<Func<TEntity, bool>> predicate)
		{
			return _dbContext.Set<TEntity>().Where(predicate);
		}

		public long GetEntitiesCount<TEntity>(Expression<Func<TEntity, bool>> predicate)
			where TEntity : class
		{
			return _dbContext.Set<TEntity>().Where(predicate).Count();
		}

		public void AddEntity(TEntity entity)
		{
			_dbContext.Set<TEntity>().Add(entity);
		}

		public void AddEntitiesRange(IEnumerable<TEntity> entities)
		{
			IEnumerable<TEntity> enumerable = entities as TEntity[] ?? entities.ToArray();
			if (entities != null && enumerable.ToList().Count > 0)
				foreach (TEntity entity in enumerable)
					_dbContext.Set<TEntity>().Add(entity);
		}

		public void RemoveEntity(TEntity entity)
		{
			_dbContext.Set<TEntity>().Remove(entity);
		}

		public void RemoveEntitiesRange(IEnumerable<TEntity> entities)
		{
			IEnumerable<TEntity> enumerable = entities as TEntity[] ?? entities.ToArray();
			if (entities != null && enumerable.ToList().Count > 0)
				foreach (TEntity entity in enumerable)
					_dbContext.Set<TEntity>().Remove(entity);
		}
	}
}
