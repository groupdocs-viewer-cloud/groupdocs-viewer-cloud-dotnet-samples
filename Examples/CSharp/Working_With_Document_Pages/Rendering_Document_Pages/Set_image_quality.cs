using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Set Image Quality
	class Set_image_quality
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlCreatePagesCacheRequest
				{
					FileName = "sample2.pdf",
					Folder = null,
					Storage = null,
					HtmlOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.HtmlOptions()
					{
						PdfOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.PdfOptions()
						{
							ImageQuality = "High"
						}
					}
				};

				var response = apiInstance.HtmlCreatePagesCache(request);
				Console.WriteLine("Expected response type is HtmlPageCollection: " + response.Pages.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}