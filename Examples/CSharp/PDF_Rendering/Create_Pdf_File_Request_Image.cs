using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Create PDF File Request Image
	class Create_Pdf_File_Request_Image
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var pdfFileOptions = new PdfFileOptions
				{
					Watermark = new Watermark() { Text = "GroupDocs API" }
				};

				var options = new JsonSerializerSettings
				{
					NullValueHandling = NullValueHandling.Ignore
				};
				var json = JsonConvert.SerializeObject(pdfFileOptions, options);

				var bytes = Encoding.UTF8.GetBytes(json);

				var request = new ImageCreatePdfFileFromContentRequest
				{
					PdfFileOptions = new MemoryStream(bytes),
					File = new MemoryStream(File.ReadAllBytes("..\\..\\..\\Data\\viewerdocs\\one-page.docx")),
					FileName = "one-page.docx",
					FontsFolder = null,
					Folder = "viewerdocs"
				};

				var response = apiInstance.ImageCreatePdfFileFromContent(request);
				Console.WriteLine("Expected response type is PdfFileInfo: " + response.FileName);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}