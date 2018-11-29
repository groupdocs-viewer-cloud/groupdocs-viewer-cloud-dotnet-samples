using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get Attachment Pages Zip Html
	class Get_Attachment_Pages_ZIP_Html
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlGetZipWithAttachmentPagesRequest
				{
					FileName = "with-attachment.msg",
					AttachmentName = "TestAttachment-File.docx",
					ResourcePath = "./r{page-number}/{resource-name}",
					IgnoreResourcePathInResources = null,
					EmbedResources = null,
					StartPageNumber = null,
					CountPages = null,
					RenderComments = null,
					RenderHiddenPages = null,
					Password = null,
					AttachmentPassword = "",
					DefaultFontName = null,
					FontsFolder = null,
					Folder = "viewerdocs",
					Storage = null,
				};

				var response = apiInstance.HtmlGetZipWithAttachmentPages(request);
				Console.WriteLine("Expected response type is System.IO.Stream: " + response.Length);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}