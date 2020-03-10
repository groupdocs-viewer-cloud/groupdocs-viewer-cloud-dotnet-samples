using System;
using System.Linq;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to retrieve and print out text with coordinates
    /// </summary>
    public class ImageViewerGetTextCoordinates
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
                        FilePath = "SampleFiles/sample.docx"
                    },
                    ViewFormat = ViewOptions.ViewFormatEnum.PNG,
                    RenderOptions = new ImageOptions
                    {
                        ExtractText = true
                    }
                };

                var response = apiInstance.GetInfo(new GetInfoRequest(viewOptions));
                foreach (var line in response.Pages[0].Lines.Take(3))
                    Console.WriteLine($"x: {line.X}; y: {line.Y}; text: {line.Value}");
                Console.WriteLine("...");
                Console.WriteLine("ImageViewerGetTextCoordinates completed");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling InfoApi: " + e.Message);
            }
        }
    }
}