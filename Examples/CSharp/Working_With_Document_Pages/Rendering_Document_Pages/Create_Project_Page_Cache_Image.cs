using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Create Project Page Cache Image
	class Create_Project_Page_Cache_Image
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new ImageCreatePagesCacheRequest
				{
					FileName = "sample2.mpp",
					ImageOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.ImageOptions
					{
						Format = "jpg",
						Quality = 100,
						ProjectOptions = new ProjectOptions() { PageSize = "A4", TimeUnit = "Unknown" }
					},

					FontsFolder = null,
					Folder = null,
					Storage = null,
				};

				var response = apiInstance.ImageCreatePagesCache(request);
				Console.WriteLine("Expected response type is ImagePageCollection: " + response.Pages.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}