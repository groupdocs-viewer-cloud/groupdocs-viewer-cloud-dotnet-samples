using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get Document Information with Options HTML
	class Get_DocumentInfo_with_Options_HTML
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);

			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlGetDocumentInfoWithOptionsRequest
				{
					FileName = "sample2.docx",
					DocumentInfoOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.DocumentInfoOptions
					{
						Password = "password"
					},
					Folder = null,
					Storage = null
				};

				var response = apiInstance.HtmlGetDocumentInfoWithOptions(request);

				Console.WriteLine("File name:" + response.FileName);
				Console.WriteLine("Extension: " + response.Extension);
				Console.WriteLine("PageCount: " + response.Pages.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}