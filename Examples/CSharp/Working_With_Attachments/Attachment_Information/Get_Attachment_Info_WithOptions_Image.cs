using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get Attachment Information With Options Image
	class Get_Attachment_Info_WithOptions_Image
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new ImageGetAttachmentInfoWithOptionsRequest
				{
					FileName = "with-attachment.msg",
					AttachmentName = "TestAttachment-File.docx",
					DocumentInfoOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.DocumentInfoOptions
					{
						AttachmentPassword = ""
					},
					Folder = "viewerdocs",
					Storage = null
				};

				var response = apiInstance.ImageGetAttachmentInfoWithOptions(request);
				Console.WriteLine("Expected response type is DocumentInfo: " + response.FileName);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}