using System;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingVisioDocuments
{
    /// <summary>
    /// This example demonstrates how to render Visio documents figures
    /// </summary>
    public class RenderVisioDocumentFigures
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
                        FilePath = "SampleFiles/sample.vssx"
                    },
                    ViewFormat = ViewOptions.ViewFormatEnum.PNG,
                    RenderOptions = new ImageOptions()
                    {
                        VisioRenderingOptions = new VisioRenderingOptions
                        {
                            RenderFiguresOnly = true,
                            FigureWidth = 250
                        }
                    }
                };

                var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));
                Console.WriteLine("RenderVisioDocumentFigures completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}