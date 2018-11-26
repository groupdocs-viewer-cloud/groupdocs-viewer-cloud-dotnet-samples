using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get All Fonts Resources
	class Font_Resoruces
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);

			var apiInstance = new ViewerApi(configuration);

			try
			{
				var response = apiInstance.GetFonts();
				Console.WriteLine("Expected response type is FontCollection: " + response.Families.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}