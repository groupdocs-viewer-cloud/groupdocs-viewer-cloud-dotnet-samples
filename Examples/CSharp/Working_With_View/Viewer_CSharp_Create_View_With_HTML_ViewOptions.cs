using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Create View With HTML ViewOptions
	class Create_View_With_HTML_ViewOptions
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewApi(configuration);

			try
			{
				var viewOptions = new ViewOptions()
				{
					FileInfo = new FileInfo()
					{
						FilePath = "viewerdocs/three-layouts.dwf",
						Password = "",
						StorageName = Common.MyStorage
					},
					RenderOptions = new HtmlOptions()
					{
						ExternalResources = true
					}
				};

				var request = new CreateViewRequest(viewOptions);

				var response = apiInstance.CreateView(request);
				Console.WriteLine("Expected response type is ViewResult: " + response.Pages.Count.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewApi: " + e.Message);
			}
		}
	}
}