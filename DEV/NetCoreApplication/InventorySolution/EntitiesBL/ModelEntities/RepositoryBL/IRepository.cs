using System.Linq.Expressions;

namespace EntitiesBL.ModelEntities.RepositoryBL
{
	public interface IRepository<TEntity> where TEntity : class
	{
		TEntity CreateDBEntity();
		TEntity GetEntity(long id);
		//TEntity GetEntity();
		TEntity GetEntity(Expression<Func<TEntity, bool>> predicate);
		IEnumerable<TEntity> GetAllEntities();
		IEnumerable<TEntity> GetEntities(Expression<Func<TEntity, bool>> predicate);
		long GetEntitiesCount<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
		void AddEntity(TEntity entity);
		void AddEntitiesRange(IEnumerable<TEntity> entities);
		void RemoveEntity(TEntity entity);
		void RemoveEntitiesRange(IEnumerable<TEntity> entities);
	}
}
