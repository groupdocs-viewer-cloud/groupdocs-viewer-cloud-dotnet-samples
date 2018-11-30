using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Create PDF File from URL HTML
	class Get_Pdf_File_from_Url_HTML
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlGetPdfFileFromUrlRequest
				{
					Url = "https://www.dropbox.com/s/umokluz338w4ng7%2fone-page.docx",
					FileName = null,
					Password = null,
					RenderComments = null,
					RenderHiddenPages = null,
					DefaultFontName = null,
					FontsFolder = null,
					Folder = ""
				};

				var response = apiInstance.HtmlGetPdfFileFromUrl(request);
				Console.WriteLine("Expected response type is System.IO.Stream: " + response.Length);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}