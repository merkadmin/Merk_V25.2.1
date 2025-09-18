using CommonBL.DTO;
using EntitiesBL;

namespace WebApplication.Controllers
{
	public class InventoryCategoryController : BaseMappedController<InventoryCategory_cu, InventoryCategory_DTO>
	{
		//[ActionName("GetAllItems")]
		//[HttpGet]
		//public async Task<IHttpActionResult> GetAllItems()
		//{
		//	using (ERPSystemEntities context = new ERPSystemEntities())
		//	{
		//		List<InventoryCategory_cu> list = context.InventoryCategory_cu.ToList();
		//		return Ok(list);
		//	}
		//}
	}
}