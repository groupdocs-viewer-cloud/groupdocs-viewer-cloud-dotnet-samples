using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Delete All Fonts Cache
	class Delete_Font_Cache
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);

			var apiInstance = new ViewerApi(configuration);

			try
			{
				apiInstance.DeleteFontsCache();
				Console.WriteLine("Removed Fonts Cache");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}