using System;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingPdfDocuments
{
    /// <summary>
    /// This example demonstrates how to retrieve view information for pdf file
    /// </summary>
    public class GetInfoForPdfFile
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
                        FilePath = "SampleFiles/sample.pdf"
                    }
                };

                var response = apiInstance.GetInfo(new GetInfoRequest(viewOptions));
                Console.WriteLine(" PrintingAllowed: " + response.PdfViewInfo.PrintingAllowed);
                Console.WriteLine("GetInfoForPdfFile completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling InfoApi: " + e.Message);
            }
        }
    }
}