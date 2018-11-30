using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get ZIP With Pages HTML
	class Get_ZIP_With_Pages_HTML
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlGetZipWithPagesRequest
				{
					FileName = "sample.docx",
					Folder = "viewerdocs",
					Storage = null,
					ResourcePath = null,
					IgnoreResourcePathInResources = null,
					EmbedResources = null,
					StartPageNumber = null,
					CountPages = null,
					Password = null,
					RenderComments = null,
					RenderHiddenPages = null,
					DefaultFontName = null,
					FontsFolder = null
				};

				var response = apiInstance.HtmlGetZipWithPages(request);
				Console.WriteLine("Expected response type is System.IO.Stream: " + response.Length);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}