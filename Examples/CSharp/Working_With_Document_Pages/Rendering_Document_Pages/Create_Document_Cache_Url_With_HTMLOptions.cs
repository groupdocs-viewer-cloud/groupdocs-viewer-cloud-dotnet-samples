using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Create Document Cache URL with HTML Options
	class Create_Document_Cache_Url_With_HTMLOptions
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlCreatePagesCacheFromUrlRequest
				{
					Url = "https://www.dropbox.com/s/umokluz338w4ng7%2fone-page.docx",
					HtmlOptions = new HtmlOptions
					{
						EmbedResources = false
					},
					FileName = "one-page.docx",
					FontsFolder = null,
					Folder = null,
					Storage = null,
				};

				var response = apiInstance.HtmlCreatePagesCacheFromUrl(request);
				Console.WriteLine("Expected response type is HtmlPageCollection: " + response.Pages.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}