using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Create View With Spreadsheet Render Hidden Rows
	class Create_View_With_Spreadsheet_Render_Hidden_Rows_Option
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var viewOptions = new ViewOptions()
				{
					FileInfo = new FileInfo()
					{
						FilePath = "viewerdocs/with-hidden-rows-and-columns.xlsx",
						Password = "",
						StorageName = Common.MyStorage
					},
					RenderOptions = new RenderOptions()
					{
						SpreadsheetOptions = new SpreadsheetOptions()
						{
							PaginateSheets = true,
							CountRowsPerPage = 5,
							RenderHiddenRows = true
						}
					}
				};

				var request = new CreateViewRequest(viewOptions);

				var response = apiInstance.CreateView(request);
				Console.WriteLine("Expected response type is ViewResult: " + response.Pages.Count.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}