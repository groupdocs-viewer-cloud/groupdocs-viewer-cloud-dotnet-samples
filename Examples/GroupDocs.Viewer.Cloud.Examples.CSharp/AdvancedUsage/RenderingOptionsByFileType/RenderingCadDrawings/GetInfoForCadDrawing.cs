using System;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingCadDrawings
{
    /// <summary>
    /// This example demonstrates how to retrieve view information for CAD drawing
    /// </summary>
    public class GetInfoForCadDrawing
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
                        FilePath = "SampleFiles/with_layers_and_layouts.dwg"
                    }
                };

                var response = apiInstance.GetInfo(new GetInfoRequest(viewOptions));
                Console.WriteLine(" Layers count: " + response.CadViewInfo.Layers.Count);
                Console.WriteLine(" Layouts count: " + response.CadViewInfo.Layouts.Count);
                Console.WriteLine("GetInfoForCadDrawing completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling InfoApi: " + e.Message);
            }
        }
    }
}