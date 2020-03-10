using System;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingSpreadsheets
{
    /// <summary>
    /// This example demonstrates how to render only the print areas from worksheets
    /// </summary>
    public class RenderPrintAreas
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
                        FilePath = "SampleFiles/with_four_print_areas.xlsx"
                    },
                    ViewFormat = ViewOptions.ViewFormatEnum.HTML,
                    RenderOptions = new HtmlOptions
                    {
                        SpreadsheetOptions = new SpreadsheetOptions
                        {
                            RenderPrintAreaOnly = true
                        }
                    }
                };

                var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));
                Console.WriteLine("RenderPrintAreas completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}