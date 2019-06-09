using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Delete View With Default ViewFormat
	class Delete_View_With_Default_ViewFormat
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewApi(configuration);

			try
			{
				var deleteOptions = new DeleteViewOptions()
				{
					FileInfo = new FileInfo()
					{
						FilePath = "viewerdocs/one-page.docx",
						Password = "",
						StorageName = Common.MyStorage
					}
				};

				var request = new DeleteViewRequest(deleteOptions);

				apiInstance.DeleteView(request);
				Console.WriteLine("Expected response type is Void: View deleted with default View Format.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewApi: " + e.Message);
			}
		}
	}
}