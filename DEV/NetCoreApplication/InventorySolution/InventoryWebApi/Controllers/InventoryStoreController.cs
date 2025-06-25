using EntitiesBL.ModelEntities.GeneratedEnitities;
using InventoryWebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InventoryStoreController : BaseController<InventoryStoreCu>
    {
        public InventoryStoreController(IWebHostEnvironment env, InventoryDbContext context) : base(env, context)
        {
        }

        //[HttpGet("GetStores")]
        //public virtual async Task<ActionResult<List<InventoryStoreCu>>> GetAllIsOnDuty()
        //{
        //    List<InventoryStoreCu> entitiesList = await _context.GetInventoryStores

        //    return Ok(entitiesList);
        //}
    }
}
