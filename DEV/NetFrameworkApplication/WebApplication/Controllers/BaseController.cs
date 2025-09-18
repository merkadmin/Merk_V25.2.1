using CommonBL;
using CommonBL.DTO;
using EntitiesBL.EntitiesCommonBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class BaseMappedController<TEntity, TDTO> : ApiController
		where TEntity : class, IDBCommon, new()
		where TDTO : class, IDTO, new()
	{
		public virtual int _pageRowsCount { get; set; }

		public BaseMappedController()
		{
			_pageRowsCount = 20;
		}

		[ActionName("getAllItems")]
		[HttpGet]
		public virtual async Task<IHttpActionResult> GetAllItems()
		{
			List<TEntity> entitiesList = DBCommon.GetItemsList<TEntity>().ToList();
			List<TDTO> responseList = MappingLogic<TEntity, TDTO>.Map_Entity_To_DTO(entitiesList);

			return Ok(responseList);
		}

		[ActionName("getItemsByRange")]
		[HttpGet]
		public virtual async Task<IHttpActionResult> GetItemsByRange(int pageIndex)
		{
			/* ------------------------------------------------------------------------------------------
			 TODO:: Should add to PaginationConfiguration_cu the order column index
			 ------------------------------------------------------------------------------------------*/
			try
			{
				//List<TEntity> entitiesList = null;
				//string tableName = typeof(TEntity).Name;

				//if (string.IsNullOrEmpty(tableName))
				//	entitiesList = DBCommon.GetItemsList<TEntity>().ToList();
				//else
				//{
				//	PaginationConfiguration_cu paginatiopn = DBCommon.GetItemsList<PaginationConfiguration_cu>()
				//		.FirstOrDefault(item => item.TableName == tableName);

				//	if (paginatiopn == null)
				//		entitiesList = DBCommon.GetItemsList<TEntity>().ToList();
				//	else
				//	{
				//		paginatiopn.LatestPageIndex = pageIndex;
				//		paginatiopn.InsertedDate = DateTime.Now;
				//		paginatiopn.IsOnDuty = true;
				//		paginatiopn.DBCommonTransactionType = DB_CommonTransactionType.UpdateExisting;
				//		paginatiopn.SaveChanges();

				//		if (pageIndex > 0)
				//			if (pageIndex == 1)
				//				entitiesList = DBCommon.GetItemsList<TEntity>().Take(paginatiopn.PageRowCount).ToList();
				//			else
				//				entitiesList = DBCommon.GetItemsList<TEntity>()
				//					.Skip(paginatiopn.PageRowCount * (paginatiopn.LatestPageIndex - 1))
				//					.Take(paginatiopn.PageRowCount).ToList();
				//	}
				//}

				//List<TDTO> responseList = MappingLogic<TEntity, TDTO>.Map_Entity_To_DTO(entitiesList);

				//return Ok(responseList);

				return Ok(new List<TDTO>());
			}
			catch (Exception ex)
			{
				return BadRequest("Error Occurred:: " + ex);
			}
		}

		[ActionName("getPagesCount")]
		[HttpGet]
		public virtual IHttpActionResult GetPagesCount()
		{
			//int pagesCount = 1;
			//string tableName = typeof(TEntity).Name;
			//if (string.IsNullOrEmpty(tableName))
			//	return Ok(pagesCount);
			//long itemsCount = DBCommon.GetEntitiesCount<TEntity>();
			//PaginationConfiguration_cu paginatiopn = DBCommon.GetItemsList<PaginationConfiguration_cu>().FirstOrDefault(item => item.TableName == tableName);
			//if (paginatiopn == null)
			//	return Ok(pagesCount);
			//double count = itemsCount / Convert.ToDouble(paginatiopn.PageRowCount);
			//if (count % 1 > 0)
			//	count++;
			//return Ok(Math.Floor(count));

			return Ok(1);
		}

		[ActionName("getPageRowsCount")]
		[HttpGet]
		public virtual IHttpActionResult GetPageRowsCount()
		{
			//int pagesCount = 1;
			//string tableName = typeof(TEntity).Name;
			//if (string.IsNullOrEmpty(tableName))
			//	return Ok(pagesCount);

			//PaginationConfiguration_cu paginatiopn = DBCommon.GetItemsList<PaginationConfiguration_cu>().FirstOrDefault(item => item.TableName == tableName);
			//if (paginatiopn == null)
			//	return Ok(pagesCount);

			//return Ok(paginatiopn.PageRowCount);

			return Ok(1);
		}

		[ActionName("getItemsCount")]
		[HttpGet]
		public virtual IHttpActionResult GetItemsCount()
		{
			long itemsCount = DBCommon.GetEntitiesCount<TEntity>();

			return Ok(itemsCount);
		}

		[ActionName("getItem")]
		[HttpGet]
		public IHttpActionResult GetItem(long entityID)
		{
			if (entityID == 0)
				return Ok(new TDTO());

			TEntity entityDB = DBCommon.GetItemByID<TEntity>(entityID);
			TDTO response = new TDTO();
			if (entityDB != null)
				response = MappingLogic<TEntity, TDTO>.Map_Entity_To_DTO(entityDB);

			return Ok(response);
		}

		[ActionName("getNextInternalCode")]
		[HttpGet]
		public IHttpActionResult GetNextInternalCode(string prefix)
		{
			string internalCode = DBCommon.GetNextInternalCode<TEntity>(prefix);
			return Ok(internalCode);
		}

		[ActionName("deleteItem")]
		[HttpDelete]
		public IHttpActionResult DeleteItem(long entityID, bool setIsOnDuty = true)
		{
			if (entityID == 0)
				return BadRequest("Entity ID can not be equal to zero");

			TEntity entityDB = DBCommon.GetItemByID<TEntity>(entityID);
			if (entityDB != null)
			{
				entityDB.IsOnDuty = false;
				entityDB.DBCommonTransactionType = DB_CommonTransactionType.UpdateExisting;
				entityDB.InsertedBy = 1;
				entityDB.InsertedDate = DateTime.Now;
				return Ok(entityDB.SaveChanges());
			}

			return Ok(false);
		}

		[ActionName("saveChanges")]
		[HttpPost]
		public IHttpActionResult SaveChanges(TDTO dtoToSave)
		{
			if (dtoToSave == null)
				return BadRequest("Item to be saved is null");

			TEntity response = MappingLogic<TEntity, TDTO>.Map_DTO_To_Entity(dtoToSave);
			response.IsOnDuty = true;
			response.DBCommonTransactionType = dtoToSave.DB_CommonTransactionType;
			response.InsertedBy = 1;
			response.InsertedDate = DateTime.Now;

			return Ok(response.SaveChanges());
		}
	}
}