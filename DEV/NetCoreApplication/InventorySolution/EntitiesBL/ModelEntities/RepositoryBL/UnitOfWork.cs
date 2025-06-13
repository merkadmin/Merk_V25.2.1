using EntitiesBL.ModelEntities.CommonBL;
using EntitiesBL.ModelEntities.GeneratedEnitities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq.Expressions;

namespace EntitiesBL.ModelEntities.RepositoryBL
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly InventoryDbContext _context;

		public UnitOfWork(InventoryDbContext conetxt)
		{
			_context = conetxt;
		}

		#region Implementation of IDisposable

		public void Dispose()
		{
			
		}

		public int SaveChanges()
		{
			try
			{
				int num = _context.SaveChanges();

				return num;
			}
			catch (DbUpdateException e)
			{
				foreach (var entry in _context.ChangeTracker.Entries())
				{
					var foundEntity = entry.Entity;
					var validationContext = new ValidationContext(foundEntity);
					Validator.ValidateObject(foundEntity, validationContext, validateAllProperties: true);
				}

				throw;
			}
		}

		public int UpdateChanges<TEntity>(TEntity entity)
			where TEntity : class, IDBCommon, new()
		{
			try
			{
				TEntity existingEntity = GetEntity<TEntity>(entity.EntityID);
				_context.Entry(existingEntity).CurrentValues.SetValues(entity);
				return SaveChanges();
			}
			catch (DbUpdateException e)
			{
				foreach (var entry in _context.ChangeTracker.Entries())
				{
					var foundEntity = entry.Entity;
					var validationContext = new ValidationContext(foundEntity);
					Validator.ValidateObject(foundEntity, validationContext, validateAllProperties: true);
				}

				throw;
			}
		}

		public TEntity CreateDBEntity<TEntity>()
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_context).CreateDBEntity();
		}

		public int RemoveEntity<TEntity>(TEntity entity)
			where TEntity : class, IDBCommon, new()
		{
			try
			{
				//TODO :: Check from System Configuration if the owner wants to delete forever or just mark it as IsOnDuty = false
				Repository<TEntity> repository = new Repository<TEntity>(_context);
				TEntity updatedEntity = GetEntity<TEntity>(entity.EntityID);
				repository.RemoveEntity(updatedEntity);
				return SaveChanges();

				//This is to Update After Making IsOnDuty = false;
				//return UpdateChanges<TEntity>(entity);
			}
			catch (DbUpdateException e)
			{
				foreach (var entry in _context.ChangeTracker.Entries())
				{
					var foundEntity = entry.Entity;
					var validationContext = new ValidationContext(foundEntity);
					Validator.ValidateObject(foundEntity, validationContext, validateAllProperties: true);
				}

				throw;
			}
		}

		public int UpdateChanges<TEntity>(IDBCommon activeDbItem) where TEntity : class, new()
		{
			try
			{
				TEntity updatedEntity = GetEntity<TEntity>(activeDbItem.EntityID);
				_context.Entry(updatedEntity).CurrentValues.SetValues(activeDbItem);
				return SaveChanges();
			}
			catch (DbUpdateException e)
			{
				foreach (var entry in _context.ChangeTracker.Entries())
				{
					var foundEntity = entry.Entity;
					var validationContext = new ValidationContext(foundEntity);
					Validator.ValidateObject(foundEntity, validationContext, validateAllProperties: true);
				}

				throw;
			}
		}

		public Repository<TEntity> GetList<TEntity>()
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_context);
		}

		public IEnumerable<TEntity> GetAllEntities<TEntity>()
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_context).GetAllEntities();
		}

		public IEnumerable<TEntity> GetAllEntities<TEntity>(Expression<Func<TEntity, bool>> predicate)
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_context).GetEntities(predicate);
		}

		public long GetEntitiesCount<TEntity>(Expression<Func<TEntity, bool>> predicatE)
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_context).GetEntitiesCount<TEntity>(predicatE);
		}

		public TEntity GetEntity<TEntity>(int id)
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_context).GetEntity(id);
		}

		public TEntity GetEntity<TEntity>(Expression<Func<TEntity, bool>> predicate)
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_context).GetEntity(predicate);
		}

		public TEntity GetEntity<TEntity>(long id)
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_context).GetEntity(id);
		}

		#endregion
	}
}
