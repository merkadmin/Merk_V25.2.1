using System.Net;

namespace InventoryWebAPI.Libs.UtilitesLibs
{
	public class FileUtilitiesLib
	{
		public static string _configFilePath = @"config\Web.config";

		public static bool FileExists(string fileFullPath)
		{
			if (string.IsNullOrWhiteSpace(fileFullPath))
				return false;
			return File.Exists(fileFullPath);
		}

		public static string GetRelativePath(string sourceURL, string keyToSubString)
		{
			int index = sourceURL.IndexOf(keyToSubString, StringComparison.OrdinalIgnoreCase);
			string relativePath = index >= 0 ? sourceURL.Substring(index) : sourceURL;
			int queryIndex = relativePath.IndexOf('?');
			if (queryIndex >= 0)
				relativePath = relativePath.Substring(0, queryIndex);
			relativePath = relativePath.Replace('/', Path.DirectorySeparatorChar).Replace('\\', Path.DirectorySeparatorChar);
			return relativePath;
		}
	}
}