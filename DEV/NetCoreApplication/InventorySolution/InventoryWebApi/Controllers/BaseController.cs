using EntitiesBL.ModelEntities.CommonBL;
using EntitiesBL.ModelEntities.GeneratedEnitities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryWebAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class BaseController<TEntity> : ControllerBase
		where TEntity : class, IDBCommon, new()
	{
		protected readonly IWebHostEnvironment _env;
		protected readonly InventoryDbContext _context;

		public BaseController(IWebHostEnvironment env, InventoryDbContext context)
		{
			_env = env;
			_context = context;
		}

		[HttpGet("GetAll")]
		public virtual async Task<ActionResult<List<TEntity>>> GetAll()
		{
			List <TEntity> entitiesList = await _context.Set<TEntity>().ToListAsync();
			return Ok(entitiesList);
		}
	}
}
