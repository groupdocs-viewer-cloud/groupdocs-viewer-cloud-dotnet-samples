using System;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingArchiveFiles
{
    /// <summary>
    /// This example demonstrates how to print out archive contents
    /// </summary>
    public class GetInfoForArchiveFile
    {
        public static void Run()
        {
            var apiInstance = new InfoApi(Constants.GetConfig());

            try
            {
                var viewOptions = new ViewOptions
                {
                    FileInfo = new FileInfo
                    {
                        FilePath = "SampleFiles/with_folders.zip"
                    }
                };

                var response = apiInstance.GetInfo(new GetInfoRequest(viewOptions));
                foreach (var folder in response.ArchiveViewInfo.Folders)
                    Console.WriteLine(folder);
                Console.WriteLine("GetInfoForArchiveFile completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling InfoApi: " + e.Message);
            }
        }
    }
}