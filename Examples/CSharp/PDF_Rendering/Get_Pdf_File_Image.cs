using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get PDF File Image
	class Get_Pdf_File_Image
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new ImageGetPdfFileRequest
				{
					FileName = "one-page.docx",
					RenderComments = null,
					RenderHiddenPages = null,
					Password = null,
					DefaultFontName = null,
					FontsFolder = null,
					Folder = null,
					Storage = null,
				};

				var response = apiInstance.ImageGetPdfFile(request);
				Console.WriteLine("Expected response type is System.IO.Stream: " + response.Length);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}