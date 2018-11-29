using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get Responsive HTML with Options
	class Get_Responsive_HTML_Options
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);

			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlGetPageRequest
				{
					FileName = "one-page.docx",
					EnableResponsiveRendering = true,
					PageNumber = 1,
					EmbedResources = true,
					Folder = null,
					Storage = null,
				};

				var response = apiInstance.HtmlGetPage(request);

				Console.WriteLine("Result as IO Stream: " + response.Length.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}