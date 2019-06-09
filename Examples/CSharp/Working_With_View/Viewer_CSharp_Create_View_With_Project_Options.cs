using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Create View With Project Options
	class Create_View_With_Project_Options
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
						FilePath = "viewerdocs/sample.mpp",
						Password = "",
						StorageName = Common.MyStorage
					},
					RenderOptions = new RenderOptions()
					{
						ProjectManagementOptions = new ProjectManagementOptions()
						{
							PageSize = "Unknown",
							TimeUnit = "Months",
							StartDate = new DateTime(2008, 7, 1),
							EndDate = new DateTime(2008, 7, 31)
						}
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