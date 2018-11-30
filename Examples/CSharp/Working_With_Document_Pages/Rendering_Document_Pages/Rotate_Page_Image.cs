using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Rotate Page Image
	class Rotate_Page_Image
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new ImageTransformPagesRequest
				{
					FileName = "sample.docx",
					Folder = "viewerdocs",
					Storage = null,
					TransformOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.RotateOptions
					{
						PageNumber = 1,
						Angle = 90
					}
				};

				var response = apiInstance.ImageTransformPages(request);
				Console.WriteLine("Expected response type is PageInfoCollection: " + response.Pages[0].Angle);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}