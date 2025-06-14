using CommonBL;
using CommonBL.DTO;
using EntitiesBL.ModelEntities.CommonBL;
using EntitiesBL.ModelEntities.GeneratedEnitities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryWebApi.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class BaseControllerMapping<TEntity, TDTO> : ControllerBase
		where TEntity : class, IDBCommon, new()
		where TDTO : class, IDTO, new()
	{
		protected readonly IWebHostEnvironment _env;
		protected readonly InventoryDbContext _context;

		public BaseControllerMapping(IWebHostEnvironment env, InventoryDbContext context)
		{
			_env = env;
			_context = context;
		}

		[HttpGet("GetAll")]
		public virtual async Task<ActionResult<List<TEntity>>> GetAll()
		{
			List<TEntity> entitiesList = await _context.Set<TEntity>().ToListAsync();
			List<TDTO> responseList = MappingLogic<TEntity, TDTO>.Map_Entity_To_DTO(entitiesList);

			return Ok(responseList);
		}
	}
}
