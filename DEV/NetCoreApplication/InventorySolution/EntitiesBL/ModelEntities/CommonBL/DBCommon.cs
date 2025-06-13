using EntitiesBL.ModelEntities.RepositoryBL;
using System.Linq.Expressions;
using EntitiesBL.ModelEntities.GeneratedEnitities;

namespace EntitiesBL.ModelEntities.CommonBL
{
	public class DBCommon : IDBCommon
	{
		#region Implementation of IDBCommon

		public virtual long EntityID { get; }

		public virtual bool IsOnDuty { get; set; }

		public long InsertedBy { get; set; }

		public DateTime InsertedDate { get; set; }

		public DB_CommonTransactionType DBCommonTransactionType { get; set; }

		#endregion

		public static IDBCommon ActiveDBItem { get; set; }

		public static string ServerName { get; set; }

		public static string DBName { get; set; }

		public static bool UseMerkCredentials { get; set; }

		public virtual bool LoadFromDB { get; }

		public virtual DBCommonEntitiesType TableType { get; private set; }

		public static InventoryDbContext _context;

		public static InventoryDbContext DBContext_External
		{
			get
			{
				if (_context == null)
					return new InventoryDbContext();
				return _context;
			}
		}

		public static InventoryDbContext DBContext_Embedded
		{
			get
			{
				if (_context == null)
					return new InventoryDbContext();
				return _context;
			}
		}

		public static IEnumerable<TEntity> GetItemsList<TEntity>()
			where TEntity : class, IDBCommon, new()
		{
			IEnumerable<TEntity> itemList;

			using (UnitOfWork unitOfWork = new UnitOfWork(DBContext_External))
				itemList = unitOfWork.GetAllEntities<TEntity>(item => item.IsOnDuty);

			return itemList;
		}

		public static IEnumerable<TEntity> GetItemsList<TEntity>(List<long> ids)
			where TEntity : class, IDBCommon, new()
		{
			IEnumerable<TEntity> itemList;

			using (UnitOfWork unitOfWork = new UnitOfWork(DBContext_External))
				itemList = unitOfWork.GetAllEntities<TEntity>(item => item.IsOnDuty && ids.Contains(item.EntityID));

			return itemList;
		}

		public static long GetEntitiesCount<TEntity>()
			where TEntity : class, IDBCommon, new()
		{
			using (UnitOfWork unitOfWork = new UnitOfWork(DBContext_External))
				return unitOfWork.GetEntitiesCount<TEntity>(item => item.IsOnDuty);
		}

		public static string GetNextInternalCode<TEntity>(string prefix = "", int increment = 1)
			where TEntity : class, IDBCommon, new()
		{
			long itemsCount = GetEntitiesCount<TEntity>();
			itemsCount += increment;
			string internalCode = prefix + itemsCount.ToString("00000");

			return internalCode;
		}

		public static IEnumerable<TEntity> GetItemsList<TEntity>(Expression<Func<TEntity, bool>> predicate)
			where TEntity : class, new()
		{
			IEnumerable<TEntity> list = null;

			using (UnitOfWork unitOfWork = new UnitOfWork(DBContext_External))
				list = unitOfWork.GetAllEntities<TEntity>(predicate);

			return list;
		}

		public static TEntity GetItemByID<TEntity>(long id)
			where TEntity : class, new()
		{
			using (UnitOfWork unitOfWork = new UnitOfWork(DBContext_External))
				return unitOfWork.GetEntity<TEntity>(id);
		}

		public static bool SaveChanges<TEntity>(TEntity entity)
			where TEntity : DBCommon, IDBCommon, new()
		{
			int count = 0;
			using (UnitOfWork unitOfWork = new UnitOfWork(DBCommon.DBContext_External))
			{
				if (entity.DBCommonTransactionType == DB_CommonTransactionType.SaveNew)
				{
					unitOfWork.GetList<TEntity>().AddEntity(entity);
					count = unitOfWork.SaveChanges();
				}
				else
				{
					unitOfWork.UpdateChanges(entity);
					count = 1;
				}
			}

			return count > 0;
		}
	}
}
