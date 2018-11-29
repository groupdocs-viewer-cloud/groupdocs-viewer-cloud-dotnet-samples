using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Render Email Image PageSize
	class Render_Email_Image_PageSize
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);

			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new ImageCreatePagesCacheRequest
				{
					FileName = "with-attachment.msg",
					Folder = "viewerdocs",
					ImageOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.ImageOptions()
					{
						EmailOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.EmailOptions()
						{
							PageSize = "A0"
						}
					}
				};

				var response = apiInstance.ImageCreatePagesCache(request);
				Console.WriteLine("Result as ImagePageCollection: " + response.Pages.Count.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}