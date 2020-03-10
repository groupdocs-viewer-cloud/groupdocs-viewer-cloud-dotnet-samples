using System;
using System.Collections.Generic;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.BasicUsage.HtmlViewer
{
    /// <summary>
    /// This example demonstrates how to exclude fonts from output HTML
    /// </summary>
    public class HtmlViewerExcludeFonts
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
                    RenderOptions = new HtmlOptions
                    {
                        FontsToExclude = new List<string> { "Times New Roman" }
                    }
                };

                var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));
                Console.WriteLine("HtmlViewerExcludeFonts completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}