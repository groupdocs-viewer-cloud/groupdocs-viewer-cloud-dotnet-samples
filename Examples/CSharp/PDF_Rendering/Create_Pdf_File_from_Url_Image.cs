using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Create PDF File from Url Image
	class Create_Pdf_File_from_Url_Image
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new ImageCreatePdfFileFromUrlRequest
				{
					Url = "https://www.dropbox.com/s/umokluz338w4ng7%2fone-page.docx",
					FontsFolder = null,
					Folder = "viewerdocs",
					PdfFileOptions = new PdfFileOptions() { Watermark = new Watermark() { Text = "GroupDocs Cloud API's", Color = "Magenta", Position = "Diagonal", Size = 50 } }
				};

				var response = apiInstance.ImageCreatePdfFileFromUrl(request);
				Console.WriteLine("Expected response type is PdfFileInfo: " + response.FileName);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}