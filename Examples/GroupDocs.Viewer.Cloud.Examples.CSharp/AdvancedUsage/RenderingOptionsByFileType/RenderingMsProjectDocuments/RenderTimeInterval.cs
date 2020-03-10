using System;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingMsProjectDocuments
{
    /// <summary>
    /// This example demonstrates how to render MS Project document using StartDate and EndDate
    /// </summary>
    public class RenderTimeInterval
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
                        FilePath = "SampleFiles/sample.mpp"
                    },
                    ViewFormat = ViewOptions.ViewFormatEnum.HTML,
                    RenderOptions = new HtmlOptions
                    {
                        ProjectManagementOptions = new ProjectManagementOptions
                        {
                            StartDate = new DateTime(2008, 6, 1),
                            EndDate = new DateTime(2008, 7, 1)
                        }
                    }
                };

                var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));
                Console.WriteLine("RenderTimeInterval completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}