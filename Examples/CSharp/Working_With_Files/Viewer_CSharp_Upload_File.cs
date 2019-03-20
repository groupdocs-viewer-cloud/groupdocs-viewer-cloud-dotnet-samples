using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;
using System.IO;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Upload File
	class Upload_File
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new FileApi(configuration);

			try
			{
				// Open file in IOStream from local/disc.
				var fileStream = File.Open("..\\..\\..\\Data\\viewerdocs\\one-page.docx", FileMode.Open);

				var request = new UploadFileRequest("viewerdocs/one-page1.docx", fileStream, Common.MyStorage);

				var response = apiInstance.UploadFile(request);
				Console.WriteLine("Expected response type is FilesUploadResult: " + response.Uploaded.Count.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FileApi: " + e.Message);
			}
		}
	}
}