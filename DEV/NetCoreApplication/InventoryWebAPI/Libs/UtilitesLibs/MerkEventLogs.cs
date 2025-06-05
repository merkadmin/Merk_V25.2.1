using System.Diagnostics;

namespace InventoryWebAPI.Libs.UtilitesLibs
{
	public class EventsStatic
	{
		public const string InventoryWebAPI = "Merk Inventory Events";
	}

	public class MerkEventLogs
	{
		private const string LogName = "Merk Solutions";
		private static bool _initialized = false;

		private static void EnsureEventLogSource(string sourceEven)
		{
			if (!_initialized)
			{
				if (!EventLog.SourceExists(sourceEven))
				{
					// Creating an event source requires admin rights
					EventLog.CreateEventSource(sourceEven, LogName);
				}
				_initialized = true;
			}
		}

		public static void WriteEvent(string sourceEvent, string message, EventLogEntryType type = EventLogEntryType.Information)
		{
			try
			{
				EnsureEventLogSource(sourceEvent);
				using (var eventLog = new EventLog(LogName))
				{
					eventLog.Source = sourceEvent;
					eventLog.WriteEntry(message, type);
				}
			}
			catch (Exception ex)
			{
				// Optionally handle/log exceptions here
				// For example, write to a file or fallback logger
			}
		}
	}
}
