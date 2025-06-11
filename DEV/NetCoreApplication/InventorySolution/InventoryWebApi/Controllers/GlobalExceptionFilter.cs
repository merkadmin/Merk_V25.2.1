using InventoryWebAPI.Libs.UtilitesLibs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace InventoryWebAPI.Controllers
{
	public class GlobalExceptionFilter : IExceptionFilter
	{
		public void OnException(ExceptionContext context)
		{
			// Log the exception
			MerkEventLogs.WriteEvent(EventsStatic.InventoryWebAPI, "Unhandled Exception: " + context.Exception, EventLogEntryType.Error);

			context.Result = new BadRequestObjectResult("ERROR: " + context.Exception.Message);
			context.ExceptionHandled = true;
		}
	}
}