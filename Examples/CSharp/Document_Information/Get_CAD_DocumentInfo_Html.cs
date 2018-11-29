using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get CAD Document Information Html
	class Get_CAD_DocumentInfo_Html
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);

			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlGetDocumentInfoRequest
				{
					FileName = "sample.DXF",
					Password = null,
					RenderComments = null,
					RenderHiddenPages = null,
					Folder = null,
					Storage = null,
				};

				var response = apiInstance.HtmlGetDocumentInfo(request);


				Console.WriteLine("Document processed successfully");
				Console.WriteLine("Layers count:" + response.Layers.Count);
				Console.WriteLine("File name:" + response.FileName);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}