using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get Document Information With Project Options
	class Get_Info_With_Project_Options
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