using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get File Versions
	class Get_File_Versions
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new StorageApi(configuration);

			try
			{
				var request = new GetFileVersionsRequest("one-page.docx", Common.MyStorage);

				var response = apiInstance.GetFileVersions(request);
				Console.WriteLine("Expected response type is FileVersions: " + response.Value.Count.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling StorageApi: " + e.Message);
			}
		}
	}
}