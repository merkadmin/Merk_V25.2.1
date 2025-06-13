using EntitiesBL.ModelEntities.GeneratedEnitities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EntitiesBL.ModelEntities.RepositoryBL
{
	public class Repository<TEntity> : IRepository<TEntity>
		where TEntity : class, new()
	{
		protected readonly InventoryDbContext _context;
		public Repository(InventoryDbContext context)
		{
			_context = context;
		}

		#region Implementation of IRepository<TEntity>

		public TEntity CreateDBEntity()
		{
			return new TEntity();
		}
		public TEntity GetEntity(long id)
		{
			try
			{
				return _context.Set<TEntity>().Find(id);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}

			return null;
		}
		//public TEntity GetEntity()
		//{
		//	return _context.Set<TEntity>().FirstOrDefault();
		//}
		public IEnumerable<TEntity> GetAllEntities()
		{
			return _context.Set<TEntity>().ToList();
		}
		public IEnumerable<TEntity> GetEntities(Expression<Func<TEntity, bool>> predicate)
		{
			return _context.Set<TEntity>().Where(predicate);
		}
		public long GetEntitiesCount<TEntity>(Expression<Func<TEntity, bool>> predicate)
			where TEntity : class
		{
			return _context.Set<TEntity>().Where(predicate).Count();
		}
		public TEntity GetEntity(Expression<Func<TEntity, bool>> predicate)
		{
			return (TEntity)_context.Set<TEntity>().Where(predicate);
		}
		public void AddEntity(TEntity entity)
		{
			_context.Set<TEntity>().Add(entity);
		}
		public void AddEntitiesRange(IEnumerable<TEntity> entities)
		{
			IEnumerable<TEntity> enumerable = entities as TEntity[] ?? entities.ToArray();
			if (entities != null && enumerable.ToList().Count > 0)
				foreach (TEntity entity in enumerable)
					_context.Set<TEntity>().Add(entity);
		}
		public void RemoveEntity(TEntity entity)
		{
			_context.Set<TEntity>().Remove(entity);
		}
		public void RemoveEntitiesRange(IEnumerable<TEntity> entities)
		{
			IEnumerable<TEntity> enumerable = entities as TEntity[] ?? entities.ToArray();
			if (entities != null && enumerable.ToList().Count > 0)
				foreach (TEntity entity in enumerable)
					_context.Set<TEntity>().Remove(entity);
		}

		#endregion
	}
}
