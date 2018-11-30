using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Render Email PDF
	class Render_Email_PDF
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new ImageCreatePdfFileRequest
				{
					FileName = "with-attachment.msg",
					Folder = "viewerdocs",
					PdfFileOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.PdfFileOptions()
					{
						EmailOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.EmailOptions()
						{
							PageSize = "A0"
						}
					}
				};

				var response = apiInstance.ImageCreatePdfFile(request);
				Console.WriteLine("Expected response type is PdfFileInfo: " + response.PdfFileName);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}