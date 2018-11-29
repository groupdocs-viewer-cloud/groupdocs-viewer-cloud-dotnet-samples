using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Create Document Cache Image
	class Create_Document_Cache_Image
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new ImageCreatePagesCacheRequest
				{
					FileName = "sample.docx",
					Folder = "viewerdocs",
					Storage = null,
					ImageOptions = new ImageOptions
					{
						Format = "jpg"
					},
					FontsFolder = null
				};

				var response = apiInstance.ImageCreatePagesCache(request);
				Console.WriteLine("Expected response type is ImagePageCollection: " + response.FileName);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}