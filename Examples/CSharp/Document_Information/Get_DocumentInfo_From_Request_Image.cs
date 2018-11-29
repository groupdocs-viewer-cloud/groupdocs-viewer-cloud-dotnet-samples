using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get Document Infomation From Request Image
	class Get_DocumentInfo_From_Request_Image
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);

			var apiInstance = new ViewerApi(configuration);

			try
			{
				var documentInfoOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.DocumentInfoOptions
				{
					Password = ""
				};

				var options = new JsonSerializerSettings
				{
					NullValueHandling = NullValueHandling.Ignore
				};
				var json = JsonConvert.SerializeObject(documentInfoOptions, options);

				var bytes = Encoding.UTF8.GetBytes(json);

				var request = new ImageGetDocumentInfoFromContentRequest
				{
					DocumentInfoOptions = new MemoryStream(bytes),
					File = new MemoryStream(File.ReadAllBytes("..\\..\\..\\Data\\sample2.docx")),
					FileName = null,
					Folder = null,
					Storage = null
				};

				var response = apiInstance.ImageGetDocumentInfoFromContent(request);
				Console.WriteLine("Expected response type is DocumentInfo: " + response.Pages.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}