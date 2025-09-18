using CommonBL.Models;
using EntitiesBL.ModelEntities.GeneratedEnitities;
using InventoryWebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace InventoryWebApi.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class InventoryStoreController : BaseController<InventoryStoreCu>
	{
		public InventoryStoreController(IWebHostEnvironment env, InventoryDbContext context) : base(env, context)
		{
		}

		//[HttpGet("GetInventoryStores")]
		//public virtual async Task<ActionResult<List<GetInventoryStores>>> GetInventoryStores(long inventoryStoreID)
		//{
		//    List<GetInventoryStores> result = await _context.ExecuteStoredProcedureAsync<GetInventoryStores>("GetInventoryStores", new() {
		//        { "inventoryStoreID", inventoryStoreID }
		//    });



		//    return Ok(result);
		//}

		[HttpGet("GetAllIsOnDuty")]
		public override async Task<ActionResult<List<InventoryStoreCu>>> GetAllIsOnDuty()
		{
			ActionResult<List<InventoryStoreCu>> entitiesList = await base.GetAllIsOnDuty();

			List<InventoryStoreCu>? stores = (entitiesList.Result as OkObjectResult)?.Value as List<InventoryStoreCu>;

			List<InventoryStoreModel> inventoryStoresList = CommonBL.Libs.CommonBL.GetInventoryStores(_context, stores);

			return Ok(inventoryStoresList);
		}
	}
}
