using System;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingOutlookDataFiles
{
    /// <summary>
    /// This example demonstrates how to retrieve view information for outlook data file
    /// </summary>
    public class GetInfoForOutlookDataFile
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
                        FilePath = "SampleFiles/sample.ost"
                    }
                };

                var response = apiInstance.GetInfo(new GetInfoRequest(viewOptions));
                Console.WriteLine(" Folders count: " + response.OutlookViewInfo.Folders.Count);
                Console.WriteLine("GetInfoForOutlookDataFile completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling InfoApi: " + e.Message);
            }
        }
    }
}