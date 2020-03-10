using System;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingEmailMessages
{
    /// <summary>
    /// This example demonstrates how to adjust output page size
    /// </summary>
    public class AdjustPageSize
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
                        FilePath = "SampleFiles/sample.msg"
                    },
                    ViewFormat = ViewOptions.ViewFormatEnum.PDF,
                    RenderOptions = new PdfOptions
                    {
                        EmailOptions = new EmailOptions
                        {
                            PageSize = EmailOptions.PageSizeEnum.A4
                        }
                    }
                };

                var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));
                Console.WriteLine("AdjustPageSize completed: " + response.File.Path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}