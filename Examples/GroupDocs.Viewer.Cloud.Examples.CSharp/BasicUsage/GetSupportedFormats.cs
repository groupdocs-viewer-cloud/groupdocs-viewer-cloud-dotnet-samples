using System;
using System.Linq;
using GroupDocs.Viewer.Cloud.Sdk.Api;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to obtain all supported document formats
    /// </summary>
    public class GetSupportedFormats
    {
		public static void Run()
		{
            var apiInstance = new InfoApi(Constants.GetConfig());

			try
			{
				var response = apiInstance.GetSupportedFileFormats();

				foreach (var entry in response.Formats.Take(5))
				{
					Console.WriteLine($"{entry.FileFormat}: {entry.Extension}");
				}
                Console.WriteLine($"...");
            }
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling InfoApi: " + e.Message);
			}
		}
	}
}