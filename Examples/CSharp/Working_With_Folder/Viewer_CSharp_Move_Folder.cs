using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Move Folder
	class Move_Folder
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new FolderApi(configuration);

			try
			{
				var request = new MoveFolderRequest("viewerdocs1", "viewerdocs\viewerdocs1", Common.MyStorage, Common.MyStorage);

				apiInstance.MoveFolder(request);
				Console.WriteLine("Expected response type is Void: 'viewerdocs1' folder moved to 'viewerdocs/viewerdocs1'.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FolderApi: " + e.Message);
			}
		}
	}
}