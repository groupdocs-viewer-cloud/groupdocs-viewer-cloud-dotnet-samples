using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Render PDF Default Fonts
	class Render_PDF_DefaultFont
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlCreatePdfFileRequest
				{
					FileName = "sample2.pdf",
					Folder = null,
					Storage = null,
					PdfFileOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.PdfFileOptions
					{
						DefaultFontName = "Arial"
					}
				};

				var response = apiInstance.HtmlCreatePdfFile(request);
				Console.WriteLine("Expected response type is PdfFileInfo: " + response.FileName);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}