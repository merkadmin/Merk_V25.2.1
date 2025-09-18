using CommonBL.DTO;
using EntitiesBL.EntitiesCommonBL;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using CommonBL;

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
	}
}