using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get Document Information with Options URL HTML
	class Get_DocumentInfo_with_Options_URL_HTML
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);

			var apiInstance = new ViewerApi(configuration);

			try
			{
				var documentInfoOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.DocumentInfoOptions();
				var request = new HtmlGetDocumentInfoFromUrlWithOptionsRequest
				{
					Url = "https://www.dropbox.com/s/j260ve4f90h1p41/one-page.docx?dl=1",
					DocumentInfoOptions = documentInfoOptions,
					FileName = "one-pageurl.docx",
					Folder = null,
					Storage = null
				};

				var response = apiInstance.HtmlGetDocumentInfoFromUrlWithOptions(request);

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