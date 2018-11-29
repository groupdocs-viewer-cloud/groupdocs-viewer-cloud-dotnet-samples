using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get Pages from URL HTML
	class Get_Pages_URL_HTML
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlGetPagesFromUrlRequest
				{
					Url = "https://www.dropbox.com/s/r2eioe2atushqcf/with-notes.pptx?dl=1",
					FileName = "with-notes.pptx",
					ResourcePath = null,
					IgnoreResourcePathInResources = null,
					EmbedResources = null,
					StartPageNumber = null,
					CountPages = null,
					Password = null,
					RenderComments = null,
					RenderHiddenPages = null,
					DefaultFontName = null,
					FontsFolder = null,
					Folder = null,
					Storage = null,
				};

				var response = apiInstance.HtmlGetPagesFromUrl(request);
				Console.WriteLine("Expected response type is HtmlPageCollection: " + response.Pages.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}