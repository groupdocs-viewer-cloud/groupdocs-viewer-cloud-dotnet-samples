using System;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.BasicUsage.PdfViewer
{
    /// <summary>
    /// This example demonstrates how to protect output PDF document
    /// </summary>
    public class PdfViewerProtectPdf
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
                    ViewFormat = ViewOptions.ViewFormatEnum.PDF,
                    RenderOptions = new PdfOptions
                    {
                        Permissions = PdfOptions.PermissionsEnum.DenyModification,
                        PermissionsPassword = "p123",
                        DocumentOpenPassword = "o123"
                    }
                };

                var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));
                Console.WriteLine("PdfViewerProtectPdf completed: " + response.File.Path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}