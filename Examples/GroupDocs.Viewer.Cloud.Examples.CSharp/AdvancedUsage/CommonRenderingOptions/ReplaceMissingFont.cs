using System;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.CommonRenderingOptions
{
    /// <summary>
    /// This example demonstrates how to set default font name
    /// </summary>
    public class ReplaceMissingFont
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
                        FilePath = "SampleFiles/with_missing_font.pptx"
                    },
                    ViewFormat = ViewOptions.ViewFormatEnum.HTML,

                    RenderOptions = new RenderOptions
                    {
                        DefaultFontName = "Courier New"
                    }
                };

                var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));
                Console.WriteLine("ReplaceMissingFont completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}