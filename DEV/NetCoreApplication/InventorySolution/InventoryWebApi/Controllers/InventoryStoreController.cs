using EntitiesBL.ModelEntities.CommonBL;
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

        [HttpGet("GetInventoryStores")]
        public virtual async Task<ActionResult<List<GetInventoryStores>>> GetInventoryStores(long inventoryStoreID)
        {
            var result = await _context.ExecuteStoredProcedureAsync<GetInventoryStores>("GetInventoryStores", new() {
                { "inventoryStoreID", inventoryStoreID }
            });

            return Ok(result);
        }
    }
}
