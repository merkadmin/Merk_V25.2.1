//using EntitiesBL.ModelEntities.CommonBL;

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
			List<TEntity> entitiesList = await _context.Set<TEntity>().ToListAsync();
            return Ok(entitiesList);
		}

        [HttpGet("GetAllIsOnDuty")]
        public virtual async Task<ActionResult<List<TEntity>>> GetAllIsOnDuty()
        {
            List<TEntity> entitiesList = await _context.Set<TEntity>().Where(item => item.IsOnDuty).ToListAsync();
			
            return Ok(entitiesList);
        }

        [HttpGet("ExecuteStoredProcedureAsync")]
        public virtual async Task<ActionResult<List<TEntity>>> ExecuteStoredProcedureAsync(string storeProcedureName, Dictionary<string, object> parameters)
        {
            var result = await _context.ExecuteStoredProcedureAsync<TEntity>(storeProcedureName, parameters);
            return Ok(result);
        }

        [HttpPut("DeleteItem")]
        public virtual async Task<ActionResult<TEntity>> DeleteItem(long entityID)
        {
            List<InventoryCategoryCu> entity = await _context.InventoryCategoryCus.Where(item => item.Id == entityID).ToListAsync();
            entity[0].IsOnDuty = false;
            return Ok(_context.SaveChanges() != -1);
        }

    }
}
