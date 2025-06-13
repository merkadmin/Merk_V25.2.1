using EntitiesBL.ModelEntities.GeneratedEnitities;
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
	}
}
