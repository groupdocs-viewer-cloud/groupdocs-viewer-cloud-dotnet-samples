using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	class RunExamples
	{
		static void Main(string[] args)
		{
			//// ***********************************************************
			////          GroupDocs.Viewer Cloud API Examples
			//// ***********************************************************

			//TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
			Common.MyAppSid = "XXXXX-XXXXX-XXXXX";
			Common.MyAppKey = "XXXXXXXXXX";
			Common.MyStorage = "XXXXX";

			// Uploading sample test files from local to storage under folder 'viewerdocs'
			//Common.UploadSampleTestFiles();

			//// ***********************************************************
			///// ***** WORKING WITH STORAGE *****
			//// ***********************************************************

			// Is Storage Exist
			//Storage_Exist.Run();

			// Get Get Disc Usage
			//Get_Disc_Usage.Run();

			// Get File Versions
			//Get_File_Versions.Run();

			// Is Object Exists
			//Object_Exists.Run();


			//// ***********************************************************
			//// ***** WORKING WITH FOLDER *****
			//// ***********************************************************

			// Create Folder
			//Create_Folder.Run();

			// Copy Folder
			//Copy_Folder.Run();

			// Move Folder
			//Move_Folder.Run();

			// Delete Folder
			//Delete_Folder.Run();

			// Get Files List
			//Get_Files_List.Run();


			//// ***********************************************************
			//// ***** WORKING WITH FILES *****
			//// ***********************************************************

			// Upload File
			//Upload_File.Run();

			// Copy File
			//Copy_File.Run();

			// Move File
			//Move_File.Run();

			// Delete File
			//Delete_File.Run();

			// Download_File
			//Download_File.Run();


			//// ***********************************************************
			//// ***** WORKING WITH SUPPORTED FORMATS *****
			//// ***********************************************************

			// Get All Supported Formats
			Get_All_Supported_Formats.Run();


			//// ***********************************************************
			//// ***** WORKING WITH VIEW *****
			//// ***********************************************************

			// Create View With Minimal & Default ViewFormat & ViewOptions
			//Create_View_With_Minimal_ViewOptions.Run();

			// Create View With HTML View Format
			//Create_View_With_HTML_View_Format.Run();

			// Create View With Image View Format
			//Create_View_With_Image_View_Format.Run(Sdk.Model.ViewOptions.ViewFormatEnum.JPG);

			// Create View With Render Hidden Pages
			//Create_View_With_Render_Hidden_Pages.Run();

			// Create View With Spreadsheet Options
			//Create_View_With_SpreadsheetOptions.Run();

			// Create View With Spreadsheet Render Hidden Rows
			//Create_View_With_Spreadsheet_Render_Hidden_Rows_Option.Run();

			// Create View With Spreadsheet Options
			//Create_View_With_SpreadsheetOptions.Run();

			// Create View With Project Options
			//Create_View_With_Project_Options.Run();

			// Create View With Fonts Path Options
			//Create_View_With_Fonts_Path_Options.Run();

			// Create View With Start Page & To Count Pages
			//Create_View_With_StartPage_And_CountPages.Run();

			// Create View With HTML ViewOptions
			//Create_View_With_HTML_ViewOptions.Run();

			// Delete View With Default ViewFormat
			//Delete_View_With_Default_ViewFormat.Run();

			// Create View With Responsive HTML & ViewOptions
			//Create_View_With_Responsive_HTML.Run();

			// Create View With Output Path & ViewOptions
			//Create_View_With_OutputPath.Run();

			//// ***********************************************************
			/////// ***** WORKING WITH DOCUMENT INFORMATION *****
			//// ***********************************************************

			// Get Document Information With Minimal ViewOptions
			//Get_Info_With_Minimal_ViewOptions.Run();

			// Get Document Information With HTML View Format
			//Get_Info_With_HTML_View_Format.Run();

			// Get Document Information With Image View Format
			//Get_Info_With_Image_View_Format.Run(Sdk.Model.ViewOptions.ViewFormatEnum.PNG);

			// Get Document Information With Render Hidden Pages
			//Get_Info_With_Render_Hidden_Pages.Run();

			// Get Document Information With Spreadsheet Options
			//Get_Info_With_SpreadsheetOptions.Run();

			// Get Document Information With Spreadsheet Render Hidden Rows
			//Get_Info_With_Spreadsheet_Render_Hidden_Rows_Option.Run();

			// Get Document Information With CAD Options
			//Get_Info_With_CAD_Options.Run();

			// Get Document Information With Project Options
			//Get_Info_With_Project_Options.Run();

			// Get Document Information With Image View Options
			//Get_Info_With_Image_View_Options_Options.Run();
		}
	}
}