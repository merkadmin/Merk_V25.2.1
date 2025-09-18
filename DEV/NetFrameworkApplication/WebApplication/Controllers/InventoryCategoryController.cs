using System.Threading.Tasks;
using System.Web.Http;

namespace WebApplication.Controllers
{
	public class InventoryCategoryController : BaseController
	{
		[ActionName("getAllItems")]
		[HttpGet]
		public override async Task<IHttpActionResult> GetAllItems()
		{
			return Ok("From Child");
		}
	}
}