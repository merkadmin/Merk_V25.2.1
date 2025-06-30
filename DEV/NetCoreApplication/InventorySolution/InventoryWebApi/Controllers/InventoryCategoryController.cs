using EntitiesBL.ModelEntities.GeneratedEnitities;
using InventoryWebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace InventoryWebApi.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class InventoryCategoryController : BaseController<InventoryCategoryCu>
	{
		public InventoryCategoryController(IWebHostEnvironment env, InventoryDbContext context) : base(env, context)
		{
		}
	}
}
