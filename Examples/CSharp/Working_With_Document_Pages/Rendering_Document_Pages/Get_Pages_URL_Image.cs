using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get Pages from URL Image
	class Get_Pages_URL_Image
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new ImageGetPagesFromUrlRequest
				{
					Url = "https://www.dropbox.com/s/r2eioe2atushqcf/with-notes.pptx?dl=1",
					FileName = "with-notes.pptx",
					Format = null,
					Width = null,
					Height = null,
					Quality = null,
					StartPageNumber = null,
					CountPages = null,
					Password = null,
					ExtractText = null,
					RenderComments = null,
					RenderHiddenPages = null,
					DefaultFontName = null,
					FontsFolder = null,
					Folder = null,
					Storage = null,
				};

				var response = apiInstance.ImageGetPagesFromUrl(request);
				Console.WriteLine("Expected response type is ImagePageCollection: " + response.Pages.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}