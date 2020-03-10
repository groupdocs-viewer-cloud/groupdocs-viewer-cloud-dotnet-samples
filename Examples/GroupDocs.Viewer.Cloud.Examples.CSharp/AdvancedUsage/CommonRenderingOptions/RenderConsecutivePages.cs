using System;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.CommonRenderingOptions
{
    /// <summary>
    /// This example demonstrates how to render consecutive pages
    /// </summary>
    public class RenderConsecutivePages
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
                        FilePath = "SampleFiles/sample.docx"
                    },
                    ViewFormat = ViewOptions.ViewFormatEnum.HTML,

                    RenderOptions = new RenderOptions
                    {
                        StartPageNumber = 1,
                        CountPagesToRender = 2
                    }
                };

                var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));
                Console.WriteLine("RenderConsecutivePages completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}