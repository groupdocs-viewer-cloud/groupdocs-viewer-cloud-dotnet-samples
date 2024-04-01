using System;
using System.IO;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert and download document without using cloud storage
    /// </summary>
    public class ConvertAndDownload
    {
        public static void Run()
        {
            var apiInstance = new ViewApi(Constants.GetConfig());
            try
            {
                var response = apiInstance.ConvertAndDownload(new ConvertAndDownloadRequest("jpg", File.OpenRead("..\\..\\..\\..\\Resources\\SampleFiles\\sample.docx")));
                Console.WriteLine("ConvertAndDownload completed: " + response.Length + " bytes received");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}