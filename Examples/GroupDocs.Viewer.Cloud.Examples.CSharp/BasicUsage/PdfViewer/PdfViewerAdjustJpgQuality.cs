using System;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.BasicUsage.PdfViewer
{
    /// <summary>
    /// This example demonstrates how to adjust JPG image quality in the output PDF document
    /// </summary>
    public class PdfViewerAdjustJpgQuality
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
                        FilePath = "SampleFiles/with_jpg_image.pptx"
                    },
                    ViewFormat = ViewOptions.ViewFormatEnum.PDF,
                    RenderOptions = new PdfOptions
                    {
                        PdfOptimizationOptions = new PdfOptimizationOptions
                        {
                            CompressImages = true,
                            ImageQuality = 50
                        }
                    }
                };

                var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));
                Console.WriteLine("PdfViewerAdjustJpgQuality completed: " + response.File.Path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}