using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get Page Resoruces HTML
	class Page_Resoruces_API_HTML
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlGetPageResourceRequest
				{
					FileName = "one-page.docx",
					Folder = "viewerdocs",
					Storage = null,
					PageNumber = 1,
					ResourceName = "styles.css"
				};

				var response = apiInstance.HtmlGetPageResource(request);
				Console.WriteLine("Expected response type is System.IO.Stream: " + response.Length);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}