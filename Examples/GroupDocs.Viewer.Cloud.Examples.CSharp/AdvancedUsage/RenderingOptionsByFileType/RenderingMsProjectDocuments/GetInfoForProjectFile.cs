using System;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingMsProjectDocuments
{
    /// <summary>
    /// This example demonstrates how to retrieve view information for MS Project document
    /// </summary>
    public class GetInfoForProjectFile
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
                        FilePath = "SampleFiles/sample.mpp"
                    }
                };

                var response = apiInstance.GetInfo(new GetInfoRequest(viewOptions));
                Console.WriteLine(" Start date: " + response.ProjectManagementViewInfo.StartDate);
                Console.WriteLine(" End date: " + response.ProjectManagementViewInfo.EndDate);
                Console.WriteLine("GetInfoForProjectFile completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling InfoApi: " + e.Message);
            }
        }
    }
}