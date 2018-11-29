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
	// Create Pages Cache Request Image
	class Create_Pages_Cache_Request_Image
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var imageOptions = new ImageOptions
				{
					Format = "jpg"
				};

				var options = new JsonSerializerSettings
				{
					NullValueHandling = NullValueHandling.Ignore
				};
				var json = JsonConvert.SerializeObject(imageOptions, options);

				var bytes = Encoding.UTF8.GetBytes(json);

				var request = new ImageCreatePagesCacheFromContentRequest
				{
					ImageOptions = new MemoryStream(bytes),
					File = new MemoryStream(File.ReadAllBytes("..\\..\\..\\Data\\sample2.docx")),
					FileName = "sample2-output.docx",
					FontsFolder = null,
					Folder = "viewerdocs",
					Storage = null,
				};

				var response = apiInstance.ImageCreatePagesCacheFromContent(request);
				Console.WriteLine("Expected response type is ImagePageCollection: " + response.Pages.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}