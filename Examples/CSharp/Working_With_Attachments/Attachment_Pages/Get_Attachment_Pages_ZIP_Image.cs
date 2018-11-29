using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get Attachment Pages Zip Image
	class Get_Attachment_Pages_ZIP_Image
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new ImageGetZipWithAttachmentPagesRequest
				{
					FileName = "with-attachment.msg",
					AttachmentName = "TestAttachment-File.docx",
					Format = null,
					Width = null,
					Height = null,
					Quality = null,
					StartPageNumber = null,
					CountPages = null,
					RenderComments = null,
					RenderHiddenPages = null,
					Password = null,
					AttachmentPassword = "",
					ExtractText = null,
					DefaultFontName = null,
					FontsFolder = null,
					Folder = "viewerdocs",
					Storage = null
				};

				var response = apiInstance.ImageGetZipWithAttachmentPages(request);
				Console.WriteLine("Expected response type is System.IO.Stream: " + response.Length);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}