using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Render CAD Tiles
	class Render_CAD_Tiles
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlCreatePagesCacheRequest
				{
					FileName = "sample.DXF",
					Folder = null,
					Storage = null,
					HtmlOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.HtmlOptions
					{
						CadOptions = new CadOptions()
						{
							Tiles = new List<Tile>() {
								new Tile() { Height = 800, StartPointX = 0, StartPointY = 0, Width = 1300 },
								new Tile() { Height = 800, StartPointX = 1300, StartPointY = 0, Width = 1300 },
								new Tile() { Height = 800, StartPointX = 0, StartPointY = 800, Width = 1300 },
								new Tile() { Height = 800, StartPointX = 1300, StartPointY = 800, Width = 1300 }
							}
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