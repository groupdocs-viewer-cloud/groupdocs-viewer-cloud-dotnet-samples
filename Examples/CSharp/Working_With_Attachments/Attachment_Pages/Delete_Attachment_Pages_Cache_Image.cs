using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Delete Attachment Pages Cache Image
	class Delete_Attachment_Pages_Cache_Image
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new ImageDeleteAttachmentPagesCacheRequest
				{
					FileName = "with-attachment.msg",
					AttachmentName = "TestAttachment-File.docx",
					Folder = "viewerdocs",
					Storage = null,
				};

				apiInstance.ImageDeleteAttachmentPagesCache(request);
				Console.WriteLine("Cache deleted successfully");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}