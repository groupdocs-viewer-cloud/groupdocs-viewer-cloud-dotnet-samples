using System;
using System.Collections.Generic;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.CommonRenderingOptions
{
    /// <summary>
    /// This example demonstrates how to reorder pages
    /// </summary>
    public class ReorderPages
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
                        // Pass page numbers in the order you want to render them
                        PagesToRender = new List<int?> {2, 1}
                    }
                };

                var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));
                Console.WriteLine("ReorderPages completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}