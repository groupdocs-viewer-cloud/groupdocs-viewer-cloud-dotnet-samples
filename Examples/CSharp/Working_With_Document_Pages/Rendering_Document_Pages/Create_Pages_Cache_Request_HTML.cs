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
	// Create Pages Cache Request HTML
	class Create_Pages_Cache_Request_HTML
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var htmlOptions = new HtmlOptions
				{
					Watermark = new Watermark() { Text = "GroupDocs API" }
				};

				var options = new JsonSerializerSettings
				{
					NullValueHandling = NullValueHandling.Ignore
				};
				var json = JsonConvert.SerializeObject(htmlOptions, options);

				var bytes = Encoding.UTF8.GetBytes(json);

				var request = new HtmlCreatePagesCacheFromContentRequest
				{
					HtmlOptions = new MemoryStream(bytes),
					File = new MemoryStream(File.ReadAllBytes("..\\..\\..\\Data\\sample2.docx")),
					FileName = "sample2-output.docx",
					FontsFolder = null,
					Folder = "viewerdocs",
					Storage = null,
				};

				var response = apiInstance.HtmlCreatePagesCacheFromContent(request);
				Console.WriteLine("Expected response type is HtmlPageCollection: " + response.Pages.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}