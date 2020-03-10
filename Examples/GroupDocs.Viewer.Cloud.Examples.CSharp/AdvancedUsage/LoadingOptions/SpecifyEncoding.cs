using System;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.LoadingOptions
{
    /// <summary>
    /// This example demonstrates how to specify encoding when rendering documents
    /// </summary>
    public class SpecifyEncoding
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
                        FilePath = "SampleFiles/shift_jis_encoded.txt"
                    },
                    ViewFormat = ViewOptions.ViewFormatEnum.HTML,
                    RenderOptions = new RenderOptions
                    {
                        DefaultEncoding = "shift_jis"
                    }
                };

                var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));
                Console.WriteLine("SpecifyEncoding completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}