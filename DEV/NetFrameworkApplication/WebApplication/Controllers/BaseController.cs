using System.Threading.Tasks;
using System.Web.Http;

namespace WebApplication.Controllers
{
	public class BaseController : ApiController
	{
		public BaseController()
		{
		}

		[ActionName("getAllItems")]
		[HttpGet]
		public virtual async Task<IHttpActionResult> GetAllItems()
		{
			return Ok("From Parent");
		}
	}
}