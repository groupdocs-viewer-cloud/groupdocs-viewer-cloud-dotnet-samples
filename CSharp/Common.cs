using Aspose.Storage.Cloud.Sdk;
using Aspose.Storage.Cloud.Sdk.Api;
using System.IO;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	class Common
	{
		public static string MyAppSid = Common.MyAppSid;
		public static string MyAppKey = Common.MyAppKey;

		public static void UploadSampleTestFiles()
		{
			var storageConfig = new Configuration
			{
				AppSid = MyAppSid,
				AppKey = MyAppKey,
				ApiBaseUrl = "https://api.groupdocs.cloud"
			};

			StorageApi storageApi = new StorageApi(storageConfig);
			var path = "..\\..\\..\\Data";

			Console.WriteLine("File Upload Processing...");

			var dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
			foreach (var dir in dirs)
			{
				var relativeDirPath = dir.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);

				var response = storageApi.GetIsExist(new Aspose.Storage.Cloud.Sdk.Model.Requests.GetIsExistRequest() { Path = relativeDirPath });
				if (!response.FileExist.IsExist.Value)
					storageApi.PutCreateFolder(new Aspose.Storage.Cloud.Sdk.Model.Requests.PutCreateFolderRequest() { Path = relativeDirPath });
			}

			var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
			foreach (var file in files)
			{
				var relativeFilePath = file.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);

				var response = storageApi.GetIsExist(new Aspose.Storage.Cloud.Sdk.Model.Requests.GetIsExistRequest() { Path = relativeFilePath });
				if (!response.FileExist.IsExist.Value)
				{
					var fileName = Path.GetFileName(file);
					var relativeDirPath = relativeFilePath.Replace(fileName, string.Empty).Trim(Path.DirectorySeparatorChar);
					var fileStream = File.Open(file, FileMode.Open);

					storageApi.PutCreate(new Aspose.Storage.Cloud.Sdk.Model.Requests.PutCreateRequest() { File = fileStream, Path = relativeDirPath });
					fileStream.Close();
				}
			}

			Console.WriteLine("File Upload Process Completed.");
		}
	}
}
