using System;
using System.Collections.Generic;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.CommonRenderingOptions
{
    /// <summary>
    /// This example demonstrates how to render selected pages
    /// </summary>
    public class RenderSelectedPages
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
                        PagesToRender = new List<int?> {2, 3}
                    }
                };

                var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));
                Console.WriteLine("RenderSelectedPages completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}