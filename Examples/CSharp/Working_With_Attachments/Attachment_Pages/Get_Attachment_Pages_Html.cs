using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get Attachment Pages Html
	class Get_Attachment_Pages_Html
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlGetAttachmentPagesRequest
				{
					FileName = "with-attachment.msg",
					AttachmentName = "TestAttachment-File.docx",
					ResourcePath = null,
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

				var response = apiInstance.HtmlGetAttachmentPages(request);
				Console.WriteLine("Expected response type is HtmlAttachmentPageCollection: " + response.Pages.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}