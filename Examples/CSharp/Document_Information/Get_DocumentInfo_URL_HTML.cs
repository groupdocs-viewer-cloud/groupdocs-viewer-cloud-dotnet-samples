using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get DocumentInformation URL HTML
	class Get_DocumentInfo_URL_HTML
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);

			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlGetDocumentInfoFromUrlRequest
				{
					Url = "https://www.dropbox.com/s/j260ve4f90h1p41/one-page.docx?dl=1",
					FileName = "one-pagetest.docx",
					Password = null,
					RenderComments = null,
					RenderHiddenPages = null,
					Folder = null,
					Storage = null
				};

				var response = apiInstance.HtmlGetDocumentInfoFromUrl(request);

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