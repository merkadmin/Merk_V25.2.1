using Microsoft.AspNetCore.Mvc;

namespace InventoryWebAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class BaseController : ControllerBase
	{
		protected readonly IWebHostEnvironment _env;

		public BaseController(IWebHostEnvironment env)
		{
			_env = env;
		}
	}
}
