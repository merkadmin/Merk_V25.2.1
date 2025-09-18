using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace CommonBL
{
	public class ControllerBL
	{
		public static List<T> GetContentList<T>(IHttpActionResult response)
		{
			return ((OkNegotiatedContentResult<List<T>>)Task.FromResult(response).Result).Content;
		}
	}
}
