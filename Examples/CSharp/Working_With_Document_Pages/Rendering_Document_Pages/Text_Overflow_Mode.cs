using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Text Overflow Mode Auto Fit to Column
	class Text_Overflow_Mode
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlCreatePagesCacheRequest
				{
					FileName = "with-overflowed-text.xlsx",
					Folder = null,
					Storage = null,
					HtmlOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.HtmlOptions()
					{
						CellsOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.CellsOptions()
						{
							TextOverflowMode = "AutoFitColumn"
						}
					}
				};

				var response = apiInstance.HtmlCreatePagesCache(request);
				Console.WriteLine("Expected response type is HtmlPageCollection: " + response.Pages.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}