using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Create CAD Layers Cache HTML
	class Create_CAD_Layers_Cache_HTML
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
					HtmlOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.HtmlOptions
					{
						EmbedResources = true,
						CadOptions = new CadOptions() { Layers = new List<string>() { "SLD-0", "DEFAULT_3" } }
					},
					FontsFolder = null,
					Folder = null,
					Storage = null,
				};

				var response = apiInstance.HtmlCreatePagesCache(request);

				Console.WriteLine("File name:" + response.FileName);
				Console.WriteLine("PageCount: " + response.Pages.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}