using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq.Expressions;
using EntitiesBL.EntitiesCommonBL.EntitiesLogicLayer.Repositories;

namespace EntitiesBL.EntitiesCommonBL.EntitiesLogicLayer.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ERPSystemEntities _dbContext;

		public UnitOfWork(ERPSystemEntities dbContext)
		{
			_dbContext = dbContext;
		}

		public void Dispose()
		{
			
		}

		public int SaveChanges()
		{
			try
			{
				int num = _dbContext.SaveChanges();
				return num;
			}
			catch (DbEntityValidationException e)
			{
				foreach (var eve in e.EntityValidationErrors)
				{
					Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
						eve.Entry.Entity.GetType().Name, eve.Entry.State);
					foreach (var ve in eve.ValidationErrors)
					{
						Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
							ve.PropertyName, ve.ErrorMessage);
					}
				}
				throw;
			}
		}

		public void RejectChanges()
		{
			foreach (var entry in _dbContext.ChangeTracker.Entries())
			{
				switch (entry.State)
				{
					case System.Data.Entity.EntityState.Modified:
						entry.CurrentValues.SetValues(entry.OriginalValues);
						entry.State = System.Data.Entity.EntityState.Unchanged;
						break;
					case System.Data.Entity.EntityState.Added:
						entry.State = System.Data.Entity.EntityState.Detached;
						break;
					case System.Data.Entity.EntityState.Deleted:
						entry.State = System.Data.Entity.EntityState.Unchanged;
						break;
				}
			}
		}

		public int UpdateChanges<TEntity>(TEntity entity)
			where TEntity : class, IDBCommon, new()
		{
			try
			{
				TEntity existingEntity = GetEntity<TEntity>(entity.EntityID);
				_dbContext.Entry(existingEntity).CurrentValues.SetValues(entity);
				return SaveChanges();
			}
			catch (DbEntityValidationException e)
			{
				foreach (var eve in e.EntityValidationErrors)
				{
					Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
						eve.Entry.Entity.GetType().Name, eve.Entry.State);
					foreach (var ve in eve.ValidationErrors)
					{
						Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
							ve.PropertyName, ve.ErrorMessage);
					}
				}
				throw;
			}
		}

		public int UpdateChanges<TEntity>(IDBCommon activeDbItem) where TEntity : class, new()
		{
			try
			{
				TEntity updatedEntity = GetEntity<TEntity>(activeDbItem.EntityID);
				_dbContext.Entry(updatedEntity).CurrentValues.SetValues(activeDbItem);
				return SaveChanges();
			}
			catch (DbEntityValidationException e)
			{
				foreach (var eve in e.EntityValidationErrors)
				{
					Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
						eve.Entry.Entity.GetType().Name, eve.Entry.State);
					foreach (var ve in eve.ValidationErrors)
					{
						Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
							ve.PropertyName, ve.ErrorMessage);
					}
				}
				throw;
			}
		}

		public TEntity GetEntity<TEntity>(long id)
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_dbContext).GetEntity(id);
		}

		public TEntity CreateDBEntity<TEntity>()
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_dbContext).CreateDBEntity();
		}

		public int RemoveEntity<TEntity>(TEntity entity)
			where TEntity : class, IDBCommon, new()
		{
			try
			{
				//TODO :: Check from System Configuration if the owner wants to delete forever or just mark it as IsOnDuty = false
				Repository<TEntity> repository = new Repository<TEntity>(_dbContext);
				TEntity updatedEntity = GetEntity<TEntity>(entity.EntityID);
				repository.RemoveEntity(updatedEntity);
				return SaveChanges();

				//This is to Update After Making IsOnDuty = false;
				//return UpdateChanges<TEntity>(entity);
			}
			catch (DbEntityValidationException e)
			{
				foreach (var eve in e.EntityValidationErrors)
				{
					Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
						eve.Entry.Entity.GetType().Name, eve.Entry.State);
					foreach (var ve in eve.ValidationErrors)
					{
						Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
							ve.PropertyName, ve.ErrorMessage);
					}
				}
				throw;
			}
		}

		public Repository<TEntity> GetList<TEntity>()
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_dbContext);
		}

		public IEnumerable<TEntity> GetAllEntities<TEntity>()
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_dbContext).GetAllEntities();
		}

		public IEnumerable<TEntity> GetAllEntities<TEntity>(Expression<Func<TEntity, bool>> predicate)
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_dbContext).GetEntities(predicate);
		}

		public long GetEntitiesCount<TEntity>(Expression<Func<TEntity, bool>> predicatE)
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_dbContext).GetEntitiesCount<TEntity>(predicatE);
		}

		public TEntity GetEntity<TEntity>(Expression<Func<TEntity, bool>> predicate)
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_dbContext).GetEntity(predicate);
		}

		public TEntity GetEntity<TEntity>(int id)
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_dbContext).GetEntity(id);
		}
	}
}
