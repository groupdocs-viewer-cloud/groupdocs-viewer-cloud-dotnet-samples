using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get Document Information With Render Hidden Pages
	class Get_Info_With_Render_Hidden_Pages
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var viewOptions = new ViewOptions()
				{
					FileInfo = new FileInfo()
					{
						FilePath = "viewerdocs/two-hidden-pages.vsd",
						Password = "",
						StorageName = Common.MyStorage
					},
					RenderOptions = new RenderOptions()
					{
						RenderHiddenPages = true
					}
				};

				var request = new GetInfoRequest(viewOptions);

				var response = apiInstance.GetInfo(request);
				Console.WriteLine("Expected response type is InfoResult: " + response.Pages.Count.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}