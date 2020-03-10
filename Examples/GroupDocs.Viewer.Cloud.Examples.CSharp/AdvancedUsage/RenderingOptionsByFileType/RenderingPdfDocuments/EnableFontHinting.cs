using System;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingPdfDocuments
{
    /// <summary>
    /// This example demonstrates how to adjust the display of an outline font
    /// </summary>
    public class EnableFontHinting
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
                        FilePath = "SampleFiles/sample.pdf"
                    },
                    ViewFormat = ViewOptions.ViewFormatEnum.PNG,
                    RenderOptions = new ImageOptions
                    {
                        PdfDocumentOptions = new PdfDocumentOptions
                        {
                            EnableFontHinting = true
                        }
                    }
                };

                var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));
                Console.WriteLine("EnableFontHinting completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}