using System;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingArchiveFiles
{
    /// <summary>
    /// This example demonstrates how to print out archive contents
    /// </summary>
    public class RenderArchiveFolder
    {
        public static void Run()
        {
            var apiInstance = new ViewApi(Constants.GetConfig());

            try
            {
                var viewOptions = new ViewOptions
                {
                    FileInfo = new FileInfo
                    {
                        FilePath = "SampleFiles/with_folders.zip"
                    },
                    RenderOptions = new RenderOptions
                    {
                        ArchiveOptions = new ArchiveOptions
                        {
                            Folder = "ThirdFolderWithItems"
                        }
                    }
                };

                var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));

                Console.WriteLine("RenderArchiveFolder completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}