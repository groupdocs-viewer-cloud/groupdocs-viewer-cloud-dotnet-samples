using System;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingCadDrawings
{
    /// <summary>
    /// This example demonstrates how to adjust output image size
    /// </summary>
    public class AdjustOutputImageSize
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
                        FilePath = "SampleFiles/with_layers_and_layouts.dwg"
                    },
                    ViewFormat = ViewOptions.ViewFormatEnum.HTML,
                    RenderOptions = new HtmlOptions
                    {
                        CadOptions = new CadOptions
                        {
                            ScaleFactor = 0.3
                        }
                    }
                };

                var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));
                Console.WriteLine("AdjustOutputImageSize completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}