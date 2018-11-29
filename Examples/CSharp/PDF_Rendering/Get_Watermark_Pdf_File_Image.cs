using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get PDF File with Watermark Image
	class Get_Watermark_Pdf_File_Image
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var pdfFileOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.PdfFileOptions
				{
					Watermark = new GroupDocs.Viewer.Cloud.Sdk.Model.Watermark { Text = "Test" }
				};
				var request = new ImageCreatePdfFileRequest
				{
					FileName = "one-page.docx",
					PdfFileOptions = pdfFileOptions,
					FontsFolder = null,
					Folder = null,
					Storage = null,
				};

				var response = apiInstance.ImageCreatePdfFile(request);

				Console.WriteLine("Document Processed.");
				Console.WriteLine(response.FileName);
				Console.WriteLine(response.Folder);
				Console.WriteLine(response.PdfFileName);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}