using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Create Attachment Pages Cache Image
	class Create_Attachment_Pages_Cache_Image
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new ImageCreateAttachmentPagesCacheRequest
				{
					FileName = "with-attachment.msg",
					AttachmentName = "TestAttachment-File.docx",
					ImageOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.ImageOptions
					{
						AttachmentPassword = ""
					},
					FontsFolder = null,
					Folder = "viewerdocs",
					Storage = null,
				};

				var response = apiInstance.ImageCreateAttachmentPagesCache(request);
				Console.WriteLine("Expected response type is ImageAttachmentPageCollection: " + response.Pages.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}