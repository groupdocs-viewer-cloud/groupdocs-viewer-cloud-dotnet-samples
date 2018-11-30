using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Render Page Image
	class Reorder_Page_Image
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new ImageTransformPagesRequest
				{
					FileName = "sample2.docx",
					Folder = null,
					Storage = null,
					TransformOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.ReorderOptions
					{
						PageNumber = 1,
						NewPosition = 2
					}
				};

				var response = apiInstance.ImageTransformPages(request);
				Console.WriteLine("Expected response type is PageInfoCollection: " + response.Pages[0].Number);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}