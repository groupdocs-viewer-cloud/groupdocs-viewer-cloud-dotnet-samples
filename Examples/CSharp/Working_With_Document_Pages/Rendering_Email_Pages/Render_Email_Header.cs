using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Render Email Header
	class Render_Email_Header
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);

			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlCreatePagesCacheRequest
				{
					FileName = "with-attachment.msg",
					Folder = "viewerdocs",
					HtmlOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.HtmlOptions()
					{
						EmailOptions = new GroupDocs.Viewer.Cloud.Sdk.Model.EmailOptions()
						{
							FieldLabels = new List<FieldLabel>() { new FieldLabel() { Field = "From", Label = "Sender" }, new FieldLabel() { Field = "To", Label = "Receiver" } }
						}
					}
				};

				var response = apiInstance.HtmlCreatePagesCache(request);
				Console.WriteLine("Result as HtmlPageCollection: " + response.Pages.Count.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}