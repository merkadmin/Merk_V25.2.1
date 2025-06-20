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
    }
}
