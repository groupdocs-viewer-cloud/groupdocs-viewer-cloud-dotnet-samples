using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Remove Document Cache for HTML & Image
	class Remove_Document_Cache_for_HTML_Image
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlDeletePagesCacheRequest
				{
					FileName = "one-page.docx",
					Folder = "viewerdocs",
					Storage = null
				};

				apiInstance.HtmlDeletePagesCache(request);
				Console.WriteLine("Document Cache Removed for HTML & Image");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}