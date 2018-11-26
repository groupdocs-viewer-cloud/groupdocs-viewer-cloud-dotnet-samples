using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	class RunExamples
	{
		static void Main(string[] args)
		{
			// ***********************************************************
			//          GroupDocs.Viewer Cloud API Examples
			// ***********************************************************

			//TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
			Common.MyAppSid = "d215ce72-1609-4282-8d55-5810942236fb";
			Common.MyAppKey = "715d18b0afef2f303882c769921fe05a";

			// Uploading sample test files from local to default storage under folder 'viewerdocs'
			Common.UploadSampleTestFiles();

			// Get All Supported Formats
			Get_All_Supported_Formats.Run();

			// Delete All Fonts Cache
			Delete_Font_Cache.Run();

			// Get All Fonts Resources
			Font_Resoruces.Run();

			// Get Responsive HTML
			Get_Responsive_HTML.Run();
		}
	}
}