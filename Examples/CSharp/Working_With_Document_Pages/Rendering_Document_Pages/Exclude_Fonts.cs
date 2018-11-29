using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Exclude Fonts from Pages
	class Exclude_Fonts
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlGetPagesRequest
				{
					FileName = "sample.docx",
					Folder = "viewerdocs",
					Storage = null,
					ResourcePath = null,
					IgnoreResourcePathInResources = null,
					EmbedResources = null,
					Password = null,
					RenderComments = null,
					RenderHiddenPages = null,
					DefaultFontName = null,
					FontsFolder = null,
					ExcludeFonts = true
				};

				var response = apiInstance.HtmlGetPages(request);
				Console.WriteLine("Expected response type is HtmlPageCollection: " + response.Pages.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}