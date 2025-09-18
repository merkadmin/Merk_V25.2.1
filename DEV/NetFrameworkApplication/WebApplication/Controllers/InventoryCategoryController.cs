using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using EntitiesBL;

namespace WebApplication.Controllers
{
	public class InventoryCategoryController : BaseController
	{
		[ActionName("getAllItems")]
		[HttpGet]
		public override async Task<IHttpActionResult> GetAllItems()
		{
			using (ERPSystemEntities context = new ERPSystemEntities())
			{
				List<InventoryCategory_cu> list = context.InventoryCategory_cu.ToList();
				return Ok(list);
			}
		}
	}
}