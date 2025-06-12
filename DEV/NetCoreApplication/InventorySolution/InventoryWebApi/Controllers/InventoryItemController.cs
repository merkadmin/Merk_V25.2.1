using InventoryWebApi.Libs.EntitiesBL.ModelEntities;
using InventoryWebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryWebApi.Controllers
{
	[ApiController]
	[Route("InventoryItem")]
	public class InventoryItemController : BaseController<InventoryItemCu>
	{
		public InventoryItemController(IWebHostEnvironment env, InventoryDbContext context) : base(env, context)
		{
		}

		//[HttpGet("GetItems")]
		//public async Task<ActionResult<List<InventoryItemCu>>> GetItems()
		//{
		//	return await _context.InventoryItemCus.ToListAsync();
		//}
	}
}
